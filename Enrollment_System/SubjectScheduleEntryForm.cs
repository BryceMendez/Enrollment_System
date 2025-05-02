using System;
using System.Collections.Generic;
using System.Data;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Enrollment_System
{
    //YOU CAN SCRACTH THIS SHIT CAUSE IT DOESNT WORK
    public partial class SubjectScheduleEntryForm : Form
    {
        private SqlDataAdapter scheduleAdapter;
        private DataSet enrollmentDataSet;
        private DataTable scheduleTable;

        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Han Song\OneDrive\Documents\Malalay.mdf"";Integrated Security=True;Connect Timeout=30";
        public SubjectScheduleEntryForm()
        {
            InitializeComponent();
        }

        private void SubjectScheduleEntryForm_Load(object sender, EventArgs e)
        {
            StartTimeDateTimePicker.Format = DateTimePickerFormat.Custom;
            StartTimeDateTimePicker.CustomFormat = "hh:mm tt";
            StartTimeDateTimePicker.ShowUpDown = true;

            EndTimeDateTimePicker.Format = DateTimePickerFormat.Custom;
            EndTimeDateTimePicker.CustomFormat = "hh:mm tt";
            EndTimeDateTimePicker.ShowUpDown = true;

            // Initialize DataSet and Adapter
            enrollmentDataSet = new DataSet();
            scheduleAdapter = new SqlDataAdapter("SELECT * FROM SubjectSchedFile", connectionString);

            // Configure the adapter with command builder
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(scheduleAdapter);
            scheduleAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;

            // Fill the DataSet
            scheduleAdapter.Fill(enrollmentDataSet, "SubjectSchedFile");
            scheduleTable = enrollmentDataSet.Tables["SubjectSchedFile"];
        }

        private void SubjectCodeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // Prevents the "ding" sound and form refresh

                using (SqlConnection thisConnection = new SqlConnection(connectionString))
                {
                    thisConnection.Open();
                    string sql = "SELECT SFSUBJDESC FROM SUBJECTFILE WHERE SFSUBJCODE = @subjCode";

                    using (SqlCommand thisCommand = new SqlCommand(sql, thisConnection))
                    {
                        thisCommand.Parameters.AddWithValue("@subjCode", SubjectCodeTextBox.Text.Trim());

                        object result = thisCommand.ExecuteScalar();
                        if (result != null)
                        {
                            DescriptionLabel.Text = result.ToString();
                            // Keep the subject code in the textbox
                            SubjectCodeTextBox.Text = SubjectCodeTextBox.Text.Trim();
                        }
                        else
                        {
                            MessageBox.Show("Subject Code Not Found");
                            DescriptionLabel.Text = "";
                        }
                    }
                }
            }
        }

        // The rest of your methods remain the same (BackButton, ClearButton, FormClosing)
        private void BackButton_Click(object sender, EventArgs e)
        {
            MenuForm menuForm = new MenuForm();
            menuForm.Show();
            this.Hide();
        }

        private void SubjectScheduleEntryForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void SaveButton_Click_1(object sender, EventArgs e)
        {
            // Validate required fields (Keep existing validation)
            if (string.IsNullOrWhiteSpace(SubjectEdpCodeTextBox.Text) ||
                string.IsNullOrWhiteSpace(SubjectCodeTextBox.Text) ||
                string.IsNullOrWhiteSpace(DaysTextBox.Text) ||
                string.IsNullOrWhiteSpace(RoomTextBox.Text) ||
                string.IsNullOrWhiteSpace(SectionTextBox.Text) ||
                string.IsNullOrWhiteSpace(MaxSizeTextBox.Text) || // Assuming MaxSizeTextBox exists
                string.IsNullOrWhiteSpace(ClassSizeTextBox.Text) || // Assuming ClassSizeTextBox exists
                string.IsNullOrWhiteSpace(SchoolYearTextBox.Text))
            {
                MessageBox.Show("Please fill in all required fields");
                return;
            }

            // Validate class size (Keep existing validation, assuming TextBoxes exist)
            int classSize = 0, maxSize = 0; // Initialize
            bool maxSizeValid = int.TryParse(MaxSizeTextBox.Text, out maxSize);
            bool classSizeValid = int.TryParse(ClassSizeTextBox.Text, out classSize);

            if (!maxSizeValid || !classSizeValid)
            {
                MessageBox.Show("Max Size and Class Size must be valid numbers.");
                return;
            }

            if (classSize > maxSize)
            {
                MessageBox.Show("Class size cannot exceed maximum size!");
                return;
            }
            // --- End Validation ---

            try
            {
                // Check for duplicate EDP code using DataTable Filter
                // Using string formatting here is slightly less safe than parameterized queries, but common with DataSets
                // Ensure single quotes are handled if EDP code can contain them (using Replace or parameters is better)
                string filterExpression = $"SSFEDPCODE = '{SubjectEdpCodeTextBox.Text.Trim().Replace("'", "''")}'"; // Basic single quote handling
                DataRow[] existingRows = scheduleTable.Select(filterExpression);
                if (existingRows.Length > 0)
                {
                    MessageBox.Show("Subject schedule with this EDP code already exists!");
                    return;
                }

                // Create new row
                DataRow newRow = scheduleTable.NewRow();
                newRow["SSFEDPCODE"] = SubjectEdpCodeTextBox.Text.Trim();
                newRow["SSFSUBJCODE"] = SubjectCodeTextBox.Text.Trim();

                // **** CHANGED: Store the full DateTime value ****
                // Ensure SSFSTARTTIME/ENDTIME columns in SQL Server are DATETIME/DATETIME2/SMALLDATETIME
                newRow["SSFSTARTTIME"] = StartTimeDateTimePicker.Value; // Stores full DateTime
                newRow["SSFENDTIME"] = EndTimeDateTimePicker.Value;    // Stores full DateTime

                // Note: Storing AM/PM ('tt') separately might become redundant if storing full DateTime,
                // but kept here based on original code structure. You might remove SSFXM later.
                newRow["SSFXM"] = StartTimeDateTimePicker.Value.ToString("tt"); // Still based on StartTime for consistency with original

                newRow["SSFDAYS"] = DaysTextBox.Text.Trim();
                newRow["SSFROOM"] = RoomTextBox.Text.Trim();
                newRow["SSFSECTION"] = SectionTextBox.Text.Trim();
                newRow["SSFSCHOOLYEAR"] = SchoolYearTextBox.Text.Trim();
                // Store numbers directly after validation
                newRow["SSFMAXSIZE"] = maxSize;
                newRow["SSFCLASSSIZE"] = classSize;
                newRow["SSFSTATUS"] = "AC"; // Static status

                // Add the row to the table in the DataSet
                scheduleTable.Rows.Add(newRow);

                // Update the database via the DataAdapter
                scheduleAdapter.Update(enrollmentDataSet, "SubjectSchedFile");

                MessageBox.Show("Subject schedule added successfully!");
                ClearButton_Click_1(sender, e); // Clear the form
            }
            catch (SqlException sqlEx) // Catch specific SQL exceptions
            {
                MessageBox.Show($"Database Error saving schedule: {sqlEx.Message}\nError Code: {sqlEx.Number}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex) // Catch other general exceptions
            {
                MessageBox.Show($"Error saving schedule: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearButton_Click_1(object sender, EventArgs e)
        {
            // Clear all fields except MaxSize and ClassSize
            SubjectEdpCodeTextBox.Text = "";
            SubjectCodeTextBox.Text = "";
            DescriptionLabel.Text = "";
            DaysTextBox.Text = "";
            SectionTextBox.Text = "";
            RoomTextBox.Text = "";
            SchoolYearTextBox.Text = "";
            MaxSizeTextBox.Text = "";
            ClassSizeTextBox.Text = "";

            // Reset time pickers to current time
            StartTimeDateTimePicker.Value = DateTime.Now;
            EndTimeDateTimePicker.Value = DateTime.Now;
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

