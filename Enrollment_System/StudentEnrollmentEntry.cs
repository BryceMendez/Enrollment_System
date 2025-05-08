using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enrollment_System
{
    public partial class StudentEnrollmentEntry : Form
    {

        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Bryce Mendez\Documents\MENDEZ.mdf"";Integrated Security=True;Connect Timeout=30;";
        //connection string nimo brais
        // string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Bryce Mendez\Documents\MENDEZ.mdf"";Integrated Security=True;Connect Timeout=30;"; // Alternate from merge conflict


        public StudentEnrollmentEntry()
        {
            InitializeComponent();
        }

        private void EDPCodeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                string edpCodeInput = EDPCodeTextBox.Text.Trim();

                if (string.IsNullOrWhiteSpace(edpCodeInput))
                {
                    return;
                }

                //Check if EDP code already in DataGridView
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
                    MessageBox.Show("Subject with this EDP Code is already added.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    EDPCodeTextBox.SelectAll();
                    return;
                }

                //Fetch Subject Schedule and Details from Database
                string subjectCode = null;
                DateTime startTime = DateTime.MinValue;
                DateTime endTime = DateTime.MinValue;
                string days = null;
                string room = null;
                double units = 0.0;
                int maxSize = 0;
                int classSize = -1; // Use -1 to distinguish from 0
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
                            // Safely read DateTime values
                            startTime = reader["SSFSTARTTIME"] as DateTime? ?? DateTime.MinValue;
                            endTime = reader["SSFENDTIME"] as DateTime? ?? DateTime.MinValue;
                            days = reader["SSFDAYS"] as string;
                            room = reader["SSFROOM"] as string;
                            // Safely read numeric values
                            maxSize = reader["SSFMAXSIZE"] != DBNull.Value ? Convert.ToInt32(reader["SSFMAXSIZE"]) : 0;
                            classSize = reader["SSFCLASSSIZE"] != DBNull.Value ? Convert.ToInt32(reader["SSFCLASSSIZE"]) : -1;
                            units = reader["SFSUBJUNITS"] != DBNull.Value ? Convert.ToDouble(reader["SFSUBJUNITS"]) : 0.0;

                            // Basic data integrity check
                            if (string.IsNullOrWhiteSpace(subjectCode))
                            {
                                MessageBox.Show($"Schedule found for EDP Code '{edpCodeInput}', but linked Subject Code is missing.", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                scheduleFound = false; // Treat as not found if critical data missing
                            }
                            if (startTime == DateTime.MinValue || endTime == DateTime.MinValue || string.IsNullOrWhiteSpace(days))
                            {
                                // Optional: Warn about missing schedule details, but might still proceed
                                Console.WriteLine($"Warning: Missing schedule details (time/days) for EDP Code '{edpCodeInput}'.");
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

                // Perform Validations 
                if (!scheduleFound)
                {
                    MessageBox.Show("EDP Code Not Found.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    EDPCodeTextBox.SelectAll();
                    return;
                }
                if (classSize != -1 && maxSize > 0 && classSize >= maxSize)
                {
                    MessageBox.Show("Subject for this EDP Code is already closed (Class Full).", "Class Full", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    EDPCodeTextBox.SelectAll();
                    return;
                }

                // Unit limit check
                double currentTotalUnits = 0.0;
                double.TryParse(TotalUnitsLabel.Text, out currentTotalUnits);
                if (units > 0 && (currentTotalUnits + units) > 24.0)
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
                        if (existingStartTime != DateTime.MinValue && existingEndTime != DateTime.MinValue)
                        {
                            if (HasDaysConflict(days, existingDays))
                            {
                                if (HasTimeConflict(startTime, endTime, existingStartTime, existingEndTime))
                                {
                                    conflictFound = true;
                                    break;
                                }
                            }
                        }
                    }
                    catch (Exception parseEx)
                    {
                        Console.WriteLine($"Error parsing grid data for conflict check in row {rw.Index}: {parseEx.Message}");
                    }
                } 

                if (conflictFound)
                {
                    MessageBox.Show("Schedule conflict detected with an already added subject.", "Schedule Conflict", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    EDPCodeTextBox.SelectAll();
                    return;
                }

                // Add Subject to DataGridView
                int index = SubjectChoosedDataGridView.Rows.Add();
                DataGridViewRow newRow = SubjectChoosedDataGridView.Rows[index];

                newRow.Cells["EDPCodeColumn"].Value = edpCodeInput;
                newRow.Cells["SubjectCodeColumn"].Value = subjectCode;
                newRow.Cells["StartTimeColumn"].Value = startTime;
                newRow.Cells["EndTimeColumn"].Value = endTime;
                newRow.Cells["DaysColumn"].Value = days;
                newRow.Cells["RoomColumn"].Value = room;
                newRow.Cells["UnitsColumn"].Value = units;

                //Clear Input and Set Focus
                EDPCodeTextBox.Clear();
                EDPCodeTextBox.Focus();
            }
        }

        bool HasTimeConflict(DateTime start1, DateTime end1, DateTime start2, DateTime end2)
        {
            TimeSpan start1Time = start1.TimeOfDay;
            TimeSpan end1Time = end1.TimeOfDay;
            TimeSpan start2Time = start2.TimeOfDay;
            TimeSpan end2Time = end2.TimeOfDay;

            return (start1Time < end2Time && end1Time > start2Time);
        }

        bool HasDaysConflict(string day1, string day2)
        {
            // If either day is empty, no conflict
            if (string.IsNullOrEmpty(day1)) return false;
            if (string.IsNullOrEmpty(day2)) return false;

            // Direct comparison (ComboBox ensures consistent format/case)
            return day1 == day2;
        }

        private void IDNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                string studentId = IDNumberTextBox.Text.Trim();
                if (string.IsNullOrWhiteSpace(studentId)) { return; }

                // Clear previous student info before searching
                NameLabel.Text = "";
                CourseLabel.Text = "";
                YearLabel.Text = "";


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

                                string lname = studDataReader["STFSTUDLNAME"]?.ToString() ?? "";
                                string fname = studDataReader["STFSTUDFNAME"]?.ToString() ?? "";
                                string mname = studDataReader["STFSTUDMNAME"]?.ToString() ?? "";
                                string course = studDataReader["STFSTUDCOURSE"]?.ToString() ?? "";
                                string year = studDataReader["STFSTUDYEAR"]?.ToString() ?? "";

                                string name = $"{lname}, {fname}";
                                if (!string.IsNullOrWhiteSpace(mname))
                                {
                                    name += $" {mname.Substring(0, 1)}."; // Add middle initial if present
                                }

                                NameLabel.Text = name;
                                CourseLabel.Text = course;
                                YearLabel.Text = year;

                            }
                            if (!found)
                            {
                                MessageBox.Show("Student Not Found", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        catch (SqlException sqlEx)
                        {
                            MessageBox.Show($"SQL Database Error: {sqlEx.Message}\nError Code: {sqlEx.Number}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"An error occurred searching for student: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            studDataReader?.Close();
                        }
                    }
                }
            }
        }

        // Navigation Button Clicks 
        private void SubjectScheduleEntryButton_Click(object sender, EventArgs e)
        {
            SubjectScheduleEntryForm subjectScheduleEntryForm = new SubjectScheduleEntryForm();
            NavigateToForm(subjectScheduleEntryForm);
        }

        private void SubjectEntryButton_Click(object sender, EventArgs e)
        {
            SubjectEntry subjectEntryForm = new SubjectEntry();
            NavigateToForm(subjectEntryForm);
        }

        private void StudentEntryButton_Click(object sender, EventArgs e)
        {
            StudentEntryForm studentEntryForm = new StudentEntryForm();
            NavigateToForm(studentEntryForm);
        }

        private void EnrollmentButton_Click(object sender, EventArgs e)
        {
            ClearForm();
            IDNumberTextBox.Focus();
        }

        private void NavigateToForm(Form targetForm)
        {
            targetForm.StartPosition = FormStartPosition.CenterScreen;
            targetForm.Show();
            this.Hide();
        }

        // --- Update Total Units When Grid Changes ---
        private void SubjectChoosedDataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            UpdateTotalUnits();
        }

        private void SubjectChoosedDataGridView_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            UpdateTotalUnits(); // Also update when rows are removed
        }


        private void SubjectChoosedDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Update only if the "UnitsColumn" changed
            if (e.RowIndex >= 0 && e.ColumnIndex == SubjectChoosedDataGridView.Columns["UnitsColumn"].Index)
            {
                UpdateTotalUnits();
            }
        }

        private void UpdateTotalUnits()
        {
            double totalUnits = 0;
            foreach (DataGridViewRow row in SubjectChoosedDataGridView.Rows)
            {
                if (row.IsNewRow) continue; // Skip the template row

                if (row.Cells["UnitsColumn"].Value != null && double.TryParse(row.Cells["UnitsColumn"].Value.ToString(), out double cellValue))
                {
                    totalUnits += cellValue;
                }
            }
            TotalUnitsLabel.Text = totalUnits.ToString("0.0"); // Format to one decimal place
        }

        // --- Save Button Logic ---
        private void SaveButton_Click(object sender, EventArgs e)
        {
            //  UI Validation 
            bool hasSubjects = SubjectChoosedDataGridView.Rows.Cast<DataGridViewRow>().Any(r => !r.IsNewRow);
            if (!hasSubjects)
            {
                MessageBox.Show("No subjects have been added to the enrollment.", "Enrollment Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                EDPCodeTextBox.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(IDNumberTextBox.Text) || string.IsNullOrWhiteSpace(NameLabel.Text))
            {
                MessageBox.Show("Student information is incomplete. Please look up the student ID first.", "Enrollment Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                IDNumberTextBox.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(EncoderTextBox.Text))
            {
                MessageBox.Show("Please enter the encoder's name.", "Enrollment Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                EncoderTextBox.Focus();
                return;
            }

            if (!float.TryParse(TotalUnitsLabel.Text, out float totalUnitsValue) || totalUnitsValue <= 0)
            {
                MessageBox.Show("Cannot enroll with zero or invalid total units.", "Enrollment Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string studentId = IDNumberTextBox.Text.Trim();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlTransaction transaction = null;
                try
                {
                    conn.Open();
                    transaction = conn.BeginTransaction();

                    string checkEnrollSql = "SELECT COUNT(*) FROM ENROLLMENTHEADERFILE WHERE ENRHFSTUDID = @StudentID";
                    int enrollmentCount = 0;
                    using (SqlCommand checkCmd = new SqlCommand(checkEnrollSql, conn, transaction))
                    {
                        checkCmd.Parameters.AddWithValue("@StudentID", studentId);
                        enrollmentCount = (int)checkCmd.ExecuteScalar();
                    }

                    if (enrollmentCount > 0)
                    {
                        MessageBox.Show("This student appears to be already enrolled for this term/period.", "Already Enrolled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        transaction.Rollback();//already enrolled
                        return;
                    }
                    string getStatusSql = "SELECT STFSTUDSTATUS FROM STUDENTFILE WHERE STFSTUDID = @StudentID";
                    string studentStatus = null;
                    using (SqlCommand statusCmd = new SqlCommand(getStatusSql, conn, transaction))
                    {
                        statusCmd.Parameters.AddWithValue("@StudentID", studentId);
                        object result = statusCmd.ExecuteScalar();
                        studentStatus = result?.ToString();
                    }

                    if (string.IsNullOrWhiteSpace(studentStatus))
                    {
                        MessageBox.Show($"Could not retrieve status for student ID '{studentId}'. Cannot complete enrollment.", "Enrollment Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        transaction.Rollback();
                        return;
                    }

                    // Insert into Header Table
                    string headerSql = @"INSERT INTO ENROLLMENTHEADERFILE
                                         (ENRHFSTUDID, ENRHFSTUDDATEENROLL, ENRHFSTUDSCHLYR,
                                          ENRHFSTUDENCODER, ENRHFSTUDTOTALUNITS, ENRHFSTUDSTATUS)
                                         VALUES
                                         (@StudentID, @EnrollDate, @SchoolYear,
                                          @Encoder, @TotalUnits, @Status)";
                    using (SqlCommand headerCmd = new SqlCommand(headerSql, conn, transaction))
                    {
                        headerCmd.Parameters.AddWithValue("@StudentID", studentId);
                        headerCmd.Parameters.AddWithValue("@EnrollDate", DateEnrolledDateTimePicker.Value.Date);
                        headerCmd.Parameters.AddWithValue("@SchoolYear", YearLabel.Text);
                        headerCmd.Parameters.AddWithValue("@Encoder", EncoderTextBox.Text.Trim());
                        headerCmd.Parameters.AddWithValue("@TotalUnits", totalUnitsValue);
                        headerCmd.Parameters.AddWithValue("@Status", studentStatus);
                        headerCmd.ExecuteNonQuery();
                    }

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
                                MessageBox.Show($"Missing EDP Code or Subject Code in grid row {rw.Index}. Enrollment process cancelled.", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                transaction.Rollback();
                                return;
                            }
                        }
                    }
                    transaction.Commit();
                    MessageBox.Show("Student enrolled successfully!", "Enrollment Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ClearForm();

                }
                catch (SqlException sqlEx)
                {
                    MessageBox.Show($"Database error during enrollment: {sqlEx.Message}\nError Code: {sqlEx.Number}\nEnrollment cancelled.", "Enrollment Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    try { transaction?.Rollback(); } catch { /* Ignore rollback failure */ }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An unexpected error occurred during enrollment: {ex.Message}\nEnrollment cancelled.", "Enrollment Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    try { transaction?.Rollback(); } catch { /* Ignore rollback failure */ }
                }
            }
        }


        //class size increment 
        private void UpdateClassSize(string edpCode, SqlConnection connection, SqlTransaction transaction)
        {
            string updateSql = "UPDATE SUBJECTSCHEDFILE SET SSFCLASSSIZE = ISNULL(SSFCLASSSIZE, 0) + 1 WHERE SSFEDPCODE = @EDPCode";
            using (SqlCommand updateCommand = new SqlCommand(updateSql, connection, transaction))
            {
                updateCommand.Parameters.AddWithValue("@EDPCode", edpCode);
                int rowsAffected = updateCommand.ExecuteNonQuery();
                if (rowsAffected == 0)
                {
                    throw new InvalidOperationException($"Failed to update class size for EDP Code '{edpCode}'. Record may no longer exist.");
                }
            }
        }

        // Cancel Button / Clear Form
        private void CancelButton_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
        
        //clearForm method
        private void ClearForm()
        {
            IDNumberTextBox.Clear();
            NameLabel.Text = ""; // Use Text property for Labels
            CourseLabel.Text = "";
            YearLabel.Text = "";
            EDPCodeTextBox.Clear();
            TotalUnitsLabel.Text = "0.0"; // Reset units display
            EncoderTextBox.Clear();

            if (SubjectChoosedDataGridView != null)
            {
                SubjectChoosedDataGridView.RowsAdded -= SubjectChoosedDataGridView_RowsAdded;
                SubjectChoosedDataGridView.RowsRemoved -= SubjectChoosedDataGridView_RowsRemoved;
                SubjectChoosedDataGridView.CellValueChanged -= SubjectChoosedDataGridView_CellValueChanged;

                SubjectChoosedDataGridView.Rows.Clear();

                SubjectChoosedDataGridView.RowsAdded += SubjectChoosedDataGridView_RowsAdded;
                SubjectChoosedDataGridView.RowsRemoved += SubjectChoosedDataGridView_RowsRemoved;
                SubjectChoosedDataGridView.CellValueChanged += SubjectChoosedDataGridView_CellValueChanged;
            }

            if (DateEnrolledDateTimePicker != null)
            {
                DateEnrolledDateTimePicker.Value = DateTime.Now;
            }
            IDNumberTextBox.Focus();

        }

        private void StudentEnrollmentEntry_Load(object sender, EventArgs e)
        {
            SubjectChoosedDataGridView.Columns["StartTimeColumn"].DefaultCellStyle.Format = "HH:mm";
            SubjectChoosedDataGridView.Columns["EndTimeColumn"].DefaultCellStyle.Format = "HH:mm";
        }
    }
}