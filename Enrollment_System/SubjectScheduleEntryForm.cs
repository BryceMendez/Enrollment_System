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
        // SQL Server connection string
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Bryce Mendez\Documents\MENDEZ.mdf"";Integrated Security=True;Connect Timeout=30;";

        public SubjectScheduleEntryForm()
        {
            InitializeComponent();
        }

        private void SubjectScheduleEntryForm_Load(object sender, EventArgs e)
        {
            // Time picker formatting remains the same
            StartTimeDateTimePicker.Format = DateTimePickerFormat.Time;
            StartTimeDateTimePicker.ShowUpDown = true;
            StartTimeDateTimePicker.Format = DateTimePickerFormat.Custom;
            StartTimeDateTimePicker.CustomFormat = "HH:mm tt";

            EndTimeDateTimePicker.Format = DateTimePickerFormat.Time;
            EndTimeDateTimePicker.ShowUpDown = true;
            EndTimeDateTimePicker.Format = DateTimePickerFormat.Custom;
            EndTimeDateTimePicker.CustomFormat = "HH:mm tt";
        }

        private void SubjectCodeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
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
                        }
                        else
                        {
                            MessageBox.Show("Subject Code Not Found");
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
            using (SqlConnection thisConnection = new SqlConnection(connectionString))
            {
                // Check for duplicate schedule
                string checkSql = "SELECT COUNT(*) FROM SUBJECTSCHEDFILE WHERE SSFEDPCODE = @edpCode";
                thisConnection.Open();

                using (SqlCommand checkCommand = new SqlCommand(checkSql, thisConnection))
                {
                    checkCommand.Parameters.AddWithValue("@edpCode", SubjectEdpCodeTextBox.Text.Trim());
                    int count = (int)checkCommand.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("SUBJECT SCHEDULE ALREADY EXISTS...");
                        return;
                    }
                }

                // Insert new schedule
                try
                {
                    string insertSql = @"INSERT INTO SUBJECTSCHEDFILE 
                                    (SSFEDPCODE, SSFSUBJCODE, SSFSTARTTIME, SSFENDTIME, 
                                     SSFDAYS, SSFROOM, SSFSECTION, SSFSCHOOLYEAR, 
                                     SSFMAXSIZE, SSFCLASSSIZE) 
                                    VALUES 
                                    (@edpCode, @subjCode, @startTime, @endTime, 
                                     @days, @room, @section, @schoolYear, 
                                     @maxSize, @classSize)";

                    using (SqlCommand insertCommand = new SqlCommand(insertSql, thisConnection))
                    {
                        // Convert times to TimeSpan
                        TimeSpan startTime = StartTimeDateTimePicker.Value.TimeOfDay;
                        TimeSpan endTime = EndTimeDateTimePicker.Value.TimeOfDay;

                        // Add parameters
                        insertCommand.Parameters.AddWithValue("@edpCode", SubjectEdpCodeTextBox.Text);
                        insertCommand.Parameters.AddWithValue("@subjCode", SubjectCodeTextBox.Text);
                        insertCommand.Parameters.AddWithValue("@startTime", startTime);
                        insertCommand.Parameters.AddWithValue("@endTime", endTime);
                        insertCommand.Parameters.AddWithValue("@days", DaysTextBox.Text);
                        insertCommand.Parameters.AddWithValue("@room", RoomTextBox.Text);
                        insertCommand.Parameters.AddWithValue("@section", SectionTextBox.Text);
                        insertCommand.Parameters.AddWithValue("@schoolYear", SchoolYearTextBox.Text);
                        insertCommand.Parameters.AddWithValue("@maxSize", 50);
                        insertCommand.Parameters.AddWithValue("@classSize", 0);

                        int rowsAffected = insertCommand.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("SUBJECT SCHEDULE ADDED!");
                        }
                        else
                        {
                            MessageBox.Show("Failed to add schedule");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void ClearButton_Click_1(object sender, EventArgs e)
        {
            SubjectEdpCodeTextBox.Text = "";
            SubjectCodeTextBox.Text = "";
            DescriptionLabel.Text = "";
            DaysTextBox.Text = "";
            SectionTextBox.Text = "";
            RoomTextBox.Text = "";
            SchoolYearTextBox.Text = "";
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

