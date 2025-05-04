using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient; // Already using SQL Client
using System.Drawing;
using System.Linq; // Used by .Any() if correcting HasDaysConflict
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enrollment_System
{
    public partial class StudentEnrollmentEntry : Form 
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Bryce Mendez\Documents\MENDEZ.mdf"";Integrated Security=True;Connect Timeout=30;";


        public StudentEnrollmentEntry()
        {
            InitializeComponent();
        }

        // --- Empty/Unrelated Event Handlers (Keep as is) ---
        private void label5_Click(object sender, EventArgs e) { }
        private void label6_Click(object sender, EventArgs e) { }
        private void SubjectChoosedDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void StudentEnrollmentEntry_Load(object sender, EventArgs e) {
        }
        
        private void EDPCodeTextBox_TextChanged(object sender, EventArgs e) { }
        private void StudentEnrollmentEntry_KeyPress(object sender, KeyPressEventArgs e) { }
        private void IDNumberTextBox_TextChanged(object sender, EventArgs e) { }

        private void EDPCodeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // Prevent the 'ding' sound
                string edpCodeInput = EDPCodeTextBox.Text.Trim();

                if (string.IsNullOrWhiteSpace(edpCodeInput))
                {
                    return; // Do nothing if input is empty
                }

                // --- 1. Check if EDP code already in DataGridView ---
                bool alreadyAdded = false;
                foreach (DataGridViewRow rw in SubjectChoosedDataGridView.Rows)
                {
                    if (rw.IsNewRow) continue;
                    if (rw.Cells["EDPCodeColumn"].Value?.ToString().Equals(edpCodeInput, StringComparison.OrdinalIgnoreCase) ?? false)
                    {
                        alreadyAdded = true;
                        break;
                    }
                }

                if (alreadyAdded)
                {
                    MessageBox.Show("Subject with this EDP Code is already added.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning); // Added Icon
                    EDPCodeTextBox.SelectAll();
                    return;
                }
                string subjectCode = null;
                DateTime startTime = DateTime.MinValue;
                DateTime endTime = DateTime.MinValue; 
                string days = null;
                string room = null;
                double units = 0.0;
                int maxSize = 0;
                int classSize = -1;
                bool scheduleFound = false;

                string combinedSql = @"
                    SELECT
                        ss.SSFSUBJCODE, ss.SSFSTARTTIME, ss.SSFENDTIME, ss.SSFDAYS,
                        ss.SSFROOM, ss.SSFMAXSIZE, ss.SSFCLASSSIZE, sf.SFSUBJUNITS
                    FROM SUBJECTSCHEDFILE ss
                    LEFT JOIN SUBJECTFILE sf ON ss.SSFSUBJCODE = sf.SFSUBJCODE
                    WHERE ss.SSFEDPCODE = @EdpCode";

                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(combinedSql, conn))
                {
                    cmd.Parameters.AddWithValue("@EdpCode", edpCodeInput);
                    SqlDataReader reader = null;

                    try
                    {
                        conn.Open();
                        reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            scheduleFound = true;
                            subjectCode = reader["SSFSUBJCODE"] as string;
                            startTime = reader["SSFSTARTTIME"] as DateTime? ?? DateTime.MinValue;
                            endTime = reader["SSFENDTIME"] as DateTime? ?? DateTime.MinValue;

                            days = reader["SSFDAYS"] as string;
                            room = reader["SSFROOM"] as string;
                            maxSize = reader["SSFMAXSIZE"] != DBNull.Value ? Convert.ToInt32(reader["SSFMAXSIZE"]) : 0;
                            classSize = reader["SSFCLASSSIZE"] != DBNull.Value ? Convert.ToInt32(reader["SSFCLASSSIZE"]) : 0;
                            units = reader["SFSUBJUNITS"] != DBNull.Value ? Convert.ToDouble(reader["SFSUBJUNITS"]) : 0.0;

                            if (string.IsNullOrWhiteSpace(subjectCode))
                            {
                                MessageBox.Show($"Schedule found for EDP Code '{edpCodeInput}', but linked Subject Code is missing.", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                scheduleFound = false;
                            }
                        }
                    }
                    catch (SqlException sqlEx)
                    {
                        MessageBox.Show($"SQL Database Error: {sqlEx.Message}\nError Code: {sqlEx.Number}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred while fetching data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    finally
                    {
                        reader?.Close();
                    }
                }


                if (!scheduleFound)
                {
                    MessageBox.Show("EDP Code Not Found.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    EDPCodeTextBox.SelectAll();
                    return;
                }

                if (classSize >= maxSize)
                {
                    MessageBox.Show("Subject for this EDP Code is already closed (Class Full).", "Class Full", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    EDPCodeTextBox.SelectAll();
                    return;
                }

                double currentTotalUnits = 0.0;
                double.TryParse(TotalUnitsLabel.Text, out currentTotalUnits);
                if ((currentTotalUnits + units) > 24.0)
                {
                    MessageBox.Show($"Adding this subject ({units} units) would exceed the 24 unit limit.", "Unit Limit Exceeded", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    EDPCodeTextBox.SelectAll();
                    return;
                }
                bool conflictFound = false;
                foreach (DataGridViewRow rw in SubjectChoosedDataGridView.Rows)
                {
                    if (rw.IsNewRow) continue;

                    try
                    {
                        string existingDays = rw.Cells["DaysColumn"].Value?.ToString() ?? "";

                        DateTime existingStartTime = DateTime.MinValue;
                        DateTime existingEndTime = DateTime.MinValue;


                        if (rw.Cells["StartTimeColumn"].Value is DateTime dtStart)
                            existingStartTime = dtStart;
                        else if (DateTime.TryParse(rw.Cells["StartTimeColumn"].Value?.ToString(), out DateTime parsedDtStart))
                            existingStartTime = parsedDtStart;


                        if (rw.Cells["EndTimeColumn"].Value is DateTime dtEnd)
                            existingEndTime = dtEnd;
                        else if (DateTime.TryParse(rw.Cells["EndTimeColumn"].Value?.ToString(), out DateTime parsedDtEnd))
                            existingEndTime = parsedDtEnd;


                        if (HasDaysConflict(days, existingDays))
                        {
                            if (HasTimeConflict(startTime, endTime, existingStartTime, existingEndTime))
                            {
                                conflictFound = true;
                                break;
                            }
                        }
                    }
                    catch (Exception parseEx)
                    {
                        Console.WriteLine($"Error parsing grid data for conflict check: {parseEx.Message}");
                    }
                }

                if (conflictFound)
                {
                    MessageBox.Show("Schedule conflict detected with an already added subject.", "Schedule Conflict", MessageBoxButtons.OK, MessageBoxIcon.Warning); // Added Icon
                    EDPCodeTextBox.SelectAll();
                    return;
                }

                int index = SubjectChoosedDataGridView.Rows.Add();
                DataGridViewRow newRow = SubjectChoosedDataGridView.Rows[index];

                newRow.Cells["EDPCodeColumn"].Value = edpCodeInput;
                newRow.Cells["SubjectCodeColumn"].Value = subjectCode;
                newRow.Cells["StartTimeColumn"].Value = startTime;
                newRow.Cells["EndTimeColumn"].Value = endTime;
                newRow.Cells["DaysColumn"].Value = days;
                newRow.Cells["RoomColumn"].Value = room;
                newRow.Cells["UnitsColumn"].Value = units;

                EDPCodeTextBox.Clear();
                EDPCodeTextBox.Focus();
            }
        }


        bool HasTimeConflict(DateTime start1, DateTime end1, DateTime start2, DateTime end2)
        {

            return (start1.TimeOfDay < end2.TimeOfDay && end1.TimeOfDay > start2.TimeOfDay);
        }

        bool HasDaysConflict(string days, string dayList)
        {
            bool daysConflict = false;
            if (string.IsNullOrWhiteSpace(days) || string.IsNullOrWhiteSpace(dayList)) return false; // Handle empty strings
            string daysUpper = days.ToUpper().Trim();
            string dayListUpper = dayList.ToUpper().Trim();
            for (int i = 0; i < dayListUpper.Length; i++)
            {
                char day = dayListUpper[i];
                if (dayListUpper.Contains(day)) // Problematic check
                {
                    daysConflict = true;
                    break;
                }
            }
            return daysConflict;
        }


        private void IDNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                string studentId = IDNumberTextBox.Text.Trim();
                if (string.IsNullOrWhiteSpace(studentId)) { return; }

                using (SqlConnection studConnection = new SqlConnection(connectionString))
                {
                    string studSql = @"SELECT STFSTUDLNAME, STFSTUDFNAME, STFSTUDMNAME, STFSTUDCOURSE, STFSTUDYEAR
                                       FROM STUDENTFILE
                                       WHERE STFSTUDID = @studentID";

                    using (SqlCommand studCommand = new SqlCommand(studSql, studConnection))
                    {
                        studCommand.Parameters.AddWithValue("@studentID", studentId);
                        SqlDataReader studDataReader = null;
                        try
                        {
                            studConnection.Open();
                            studDataReader = studCommand.ExecuteReader();
                            bool found = false;
                            if (studDataReader.Read())
                            {
                                found = true;

                                string course = studDataReader["STFSTUDCOURSE"].ToString();
                                string year = studDataReader["STFSTUDYEAR"].ToString();
            
                                string name = $"{studDataReader["STFSTUDLNAME"]}, {studDataReader["STFSTUDFNAME"]} {studDataReader["STFSTUDMNAME"]}.";

                                NameLabel.Text = name;
                                CourseLabel.Text = course;
                                YearLabel.Text = year;
                            }
                            if (!found)
                            {
                                MessageBox.Show("Student Not Found", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                NameLabel.Text = "";
                                CourseLabel.Text = "";
                                YearLabel.Text = "";
                            }
                        }
                        catch (SqlException sqlEx)
                        {
                            MessageBox.Show($"SQL Database Error: {sqlEx.Message}\nError Code: {sqlEx.Number}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            NameLabel.Text = ""; CourseLabel.Text = ""; YearLabel.Text = "";
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            NameLabel.Text = ""; CourseLabel.Text = ""; YearLabel.Text = "";
                        }
                        finally
                        {
                            studDataReader?.Close();
                        }
                    }
                }
            }
        }
        

        private void SubjectScheduleEntryButton_Click(object sender, EventArgs e)
        {
            SubjectScheduleEntryForm subjectScheduleEntryForm = new SubjectScheduleEntryForm();
            subjectScheduleEntryForm.StartPosition = FormStartPosition.CenterScreen; // Centers on screen
            subjectScheduleEntryForm.Show();
            this.Hide();
        }

        private void SubjectEntryButton_Click(object sender, EventArgs e)
        {
            SubjectEntry subjectEntryForm = new SubjectEntry();
            subjectEntryForm.StartPosition = FormStartPosition.CenterScreen; // Centers on screen
            subjectEntryForm.Show();
            this.Hide();
        }

        private void StudentEntryButton_Click(object sender, EventArgs e)
        {
            StudentEntryForm studentEntryForm = new StudentEntryForm();
            studentEntryForm.StartPosition = FormStartPosition.CenterScreen; // Centers on screen
            studentEntryForm.Show();
            this.Hide();
        }

        private void EnrollmentButton_Click(object sender, EventArgs e)
        {
            StudentEnrollmentEntry studentEnroll = new StudentEnrollmentEntry();
            studentEnroll.StartPosition = FormStartPosition.CenterScreen; // Centers on screen
            studentEnroll.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void SubjectChoosedDataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            double totalUnits = 0;
            foreach (DataGridViewRow row in SubjectChoosedDataGridView.Rows)
            {
                if (row.Cells["UnitsColumn"].Value != null && double.TryParse(row.Cells["UnitsColumn"].Value.ToString(), out double cellValue))
                {
                    totalUnits += cellValue;
                }
            }
            TotalUnitsLabel.Text = totalUnits.ToString("0.0");
        }

        private void SubjectChoosedDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            double totalUnits = 0;
            foreach (DataGridViewRow row in SubjectChoosedDataGridView.Rows)
            {
                if (row.Cells["UnitsColumn"].Value != null && double.TryParse(row.Cells["UnitsColumn"].Value.ToString(), out double cellValue))
                {
                    totalUnits += cellValue;
                }
            }
            TotalUnitsLabel.Text = totalUnits.ToString("0.0");
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            // UI Validation
            int numRows = SubjectChoosedDataGridView.Rows.Count;

            bool hasSubjects = numRows > 0 && !SubjectChoosedDataGridView.Rows[0].IsNewRow;
            if (numRows > 1) hasSubjects = true;

            if (!hasSubjects)
            {
                MessageBox.Show("YOU HAVEN'T CHOSEN A SUBJECT YET...", "Enrollment Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(IDNumberTextBox.Text) || string.IsNullOrWhiteSpace(NameLabel.Text) || string.IsNullOrWhiteSpace(CourseLabel.Text) || string.IsNullOrWhiteSpace(YearLabel.Text))
            {
                MessageBox.Show("STUDENT INFO INCOMPLETE... Please look up student ID first.", "Enrollment Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(EncoderTextBox.Text))
            {
                MessageBox.Show("PLEASE FILL YOUR NAME AS THE ENCODER...", "Enrollment Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                EncoderTextBox.Focus();
                return;
            }
            if (!float.TryParse(TotalUnitsLabel.Text, out float totalUnitsValue) || totalUnitsValue <= 0)
            {
                MessageBox.Show("Cannot enroll with zero or invalid total units.", "Enrollment Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string studentId = IDNumberTextBox.Text.Trim();
            //Database Operations
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlTransaction transaction = null;
                try
                {
                    conn.Open();
                    transaction = conn.BeginTransaction();

                    //checking if student is enrolled naba
                    string checkEnrollSql = "SELECT COUNT(*) FROM ENROLLMENTHEADERFILE WHERE ENRHFSTUDID = @StudentID";
                    int enrollmentCount = 0;
                    using (SqlCommand checkCmd = new SqlCommand(checkEnrollSql, conn, transaction))
                    {
                        checkCmd.Parameters.AddWithValue("@StudentID", studentId);
                        enrollmentCount = (int)checkCmd.ExecuteScalar();
                    }

                    if (enrollmentCount > 0)
                    {
                        MessageBox.Show("Student is Already Enrolled for this term/period.", "Already Enrolled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        transaction.Rollback();
                        return; 
                    }

                    //get student status
                    string getStatusSql = "SELECT STFSTUDSTATUS FROM STUDENTFILE WHERE STFSTUDID = @StudentID";
                    string studentStatus = null;
                    using (SqlCommand statusCmd = new SqlCommand(getStatusSql, conn, transaction))
                    {
                        statusCmd.Parameters.AddWithValue("@StudentID", studentId);
                        object result = statusCmd.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            studentStatus = result.ToString();
                        }
                    }

                    if (string.IsNullOrWhiteSpace(studentStatus))
                    {
                        MessageBox.Show($"Could not find status for student ID '{studentId}'. Cannot enroll.", "Enrollment Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        transaction.Rollback();
                        return; // Exit
                    }
                    string headerSql = @"INSERT INTO ENROLLMENTHEADERFILE
                                     (ENRHFSTUDID, ENRHFSTUDDATEENROLL, ENRHFSTUDSCHLYR,
                                      ENRHFSTUDENCODER, ENRHFSTUDTOTALUNITS, ENRHFSTUDSTATUS)
                                     VALUES
                                     (@StudentID, @EnrollDate, @SchoolYear,
                                      @Encoder, @TotalUnits, @Status)";
                    using (SqlCommand headerCmd = new SqlCommand(headerSql, conn, transaction))
                    {
                        headerCmd.Parameters.AddWithValue("@StudentID", studentId);
                        headerCmd.Parameters.AddWithValue("@EnrollDate", DateEnrolledDateTimePicker.Value.Date); // Use .Date for DATE type, full Value for DATETIME
                        headerCmd.Parameters.AddWithValue("@SchoolYear", YearLabel.Text); // Assumes YearLabel holds School Year
                        headerCmd.Parameters.AddWithValue("@Encoder", EncoderTextBox.Text.Trim());
                        headerCmd.Parameters.AddWithValue("@TotalUnits", totalUnitsValue); // Use parsed float value
                        headerCmd.Parameters.AddWithValue("@Status", studentStatus);

                        headerCmd.ExecuteNonQuery(); // Execute header insert
                    }


                    // Insert Detail Records and Update Class Sizes
                    string detailSql = @"INSERT INTO ENROLLMENTDETAILFILE
                                     (ENRDFSTUDID, ENRDFSTUDSUBJCDE, ENRDFSTUDEDPCODE, ENRDFSTUDSTATUS)
                                     VALUES
                                     (@StudentID, @SubjectCode, @EDPCode, @Status)";
                    using (SqlCommand detailCmd = new SqlCommand(detailSql, conn, transaction))
                    {
                        detailCmd.Parameters.AddWithValue("@StudentID", studentId);
                        detailCmd.Parameters.AddWithValue("@Status", studentStatus);
                        SqlParameter subjectCodeParam = detailCmd.Parameters.Add("@SubjectCode", SqlDbType.VarChar);
                        SqlParameter edpCodeParam = detailCmd.Parameters.Add("@EDPCode", SqlDbType.VarChar);
                        foreach (DataGridViewRow rw in SubjectChoosedDataGridView.Rows)
                        {
                            if (rw.IsNewRow) continue;

                            string edpCode = rw.Cells["EDPCodeColumn"].Value?.ToString();
                            string subjCode = rw.Cells["SubjectCodeColumn"].Value?.ToString();

                            if (!string.IsNullOrWhiteSpace(edpCode) && !string.IsNullOrWhiteSpace(subjCode))
                            {
                                subjectCodeParam.Value = subjCode;
                                edpCodeParam.Value = edpCode;

                                detailCmd.ExecuteNonQuery(); 
                                UpdateClassSize(edpCode, conn, transaction);
                            }
                            else
                            {
                                MessageBox.Show($"Missing EDP Code or Subject Code in grid row {rw.Index}. Enrollment cancelled.", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                transaction.Rollback();
                                return; // Exit
                            }
                        }
                    }
                    //Commit Transaction
                    transaction.Commit(); // If tanan operations succeeed, make changes permanent
                    MessageBox.Show("STUDENT ENROLLED SUCCESSFULLY!", "Enrollment Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);

                } // End Try block for transaction
                catch (SqlException sqlEx)
                {
                    MessageBox.Show($"Database Error during enrollment: {sqlEx.Message}\nError Code: {sqlEx.Number}\nEnrollment cancelled.", "Enrollment Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    try { transaction?.Rollback(); } catch { /* Ignore rollback failure */ }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An unexpected error occurred during enrollment: {ex.Message}\nEnrollment cancelled.", "Enrollment Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    try { transaction?.Rollback(); } catch { /* Ignore rollback failure */ }
                }
            }
        } 
        private void UpdateClassSize(string edpCode, SqlConnection connection, SqlTransaction transaction)
        {
            // Assumes connection is already open and transaction is active
            string updateSql = "UPDATE SUBJECTSCHEDFILE SET SSFCLASSSIZE = SSFCLASSSIZE + 1 WHERE SSFEDPCODE = @EDPCode";
            using (SqlCommand updateCommand = new SqlCommand(updateSql, connection, transaction)) // Use passed connection & transaction
            {
                // Use named parameter for SQL Server
                updateCommand.Parameters.AddWithValue("@EDPCode", edpCode);
                updateCommand.ExecuteNonQuery(); // Execute within the existing transaction
            }
        }

        //Clears form
        private void ClearForm()
        {
            IDNumberTextBox.Clear();
            NameLabel.Text = "";
            CourseLabel.Text = "";
            YearLabel.Text = "";
            EDPCodeTextBox.Clear();
            TotalUnitsLabel.Text = "0.0";
            EncoderTextBox.Clear();

            if (SubjectChoosedDataGridView != null)
            {
                SubjectChoosedDataGridView.RowsAdded -= SubjectChoosedDataGridView_RowsAdded;
                SubjectChoosedDataGridView.Rows.Clear();
                SubjectChoosedDataGridView.RowsAdded += SubjectChoosedDataGridView_RowsAdded;
            }
            if (DateEnrolledDateTimePicker != null)
            {
                DateEnrolledDateTimePicker.Value = DateTime.Now;
            }
        }
        private void CancelButton_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
    }
}