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

        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Bryce Mendez\Documents\MENDEZ.mdf"";Integrated Security=True;Connect Timeout=30;";
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
            // Validate required fields
            if (string.IsNullOrWhiteSpace(SubjectEdpCodeTextBox.Text) ||
                string.IsNullOrWhiteSpace(SubjectCodeTextBox.Text) ||
                string.IsNullOrWhiteSpace(DaysTextBox.Text) ||
                string.IsNullOrWhiteSpace(RoomTextBox.Text) ||
                string.IsNullOrWhiteSpace(SectionTextBox.Text) ||
                string.IsNullOrWhiteSpace(MaxSizeTextBox.Text) ||
                string.IsNullOrWhiteSpace(ClassSizeTextBox.Text) ||
                string.IsNullOrWhiteSpace(SchoolYearTextBox.Text))
            {
                MessageBox.Show("Please fill in all required fields");
                return;
            }

            // Validate class size
            if (int.TryParse(ClassSizeTextBox.Text, out int classSize) &&
                int.TryParse(MaxSizeTextBox.Text, out int maxSize))
            {
                if (classSize > maxSize)
                {
                    MessageBox.Show("Class size cannot exceed maximum size!");
                    return;
                }
            }

            try
            {
                // Check for duplicate EDP code
                DataRow[] existingRows = scheduleTable.Select($"SSFEDPCODE = '{SubjectEdpCodeTextBox.Text.Trim()}'");
                if (existingRows.Length > 0)
                {
                    MessageBox.Show("Subject schedule with this EDP code already exists!");
                    return;
                }

                // Create new row
                DataRow newRow = scheduleTable.NewRow();
                newRow["SSFEDPCODE"] = SubjectEdpCodeTextBox.Text.Trim();
                newRow["SSFSUBJCODE"] = SubjectCodeTextBox.Text.Trim();
                newRow["SSFSTARTTIME"] = StartTimeDateTimePicker.Value.TimeOfDay; // Stores as TimeSpan
                newRow["SSFENDTIME"] = EndTimeDateTimePicker.Value.TimeOfDay;    // Stores as TimeSpan
                newRow["SSFXM"] = StartTimeDateTimePicker.Value.ToString("tt");
                newRow["SSFDAYS"] = DaysTextBox.Text.Trim();
                newRow["SSFROOM"] = RoomTextBox.Text.Trim();
                newRow["SSFSECTION"] = SectionTextBox.Text.Trim();
                newRow["SSFSCHOOLYEAR"] = SchoolYearTextBox.Text.Trim();
                newRow["SSFMAXSIZE"] = MaxSizeTextBox.Text.Trim();
                newRow["SSFCLASSSIZE"] = ClassSizeTextBox.Text.Trim();
                newRow["SSFSTATUS"] = "AC"; // Static status

                // Add the row to the table
                scheduleTable.Rows.Add(newRow);

                // Update the database
                scheduleAdapter.Update(enrollmentDataSet, "SubjectSchedFile");

                MessageBox.Show("Subject schedule added successfully!");
                ClearButton_Click_1(sender, e); // Clear the form
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving schedule: {ex.Message}");
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
    }
}

