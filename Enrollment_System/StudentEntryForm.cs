using System;
using System.Configuration; // Required for App.config
using System.Data;
using System.Data.SqlClient; // Required for SQL Server
using System.Windows.Forms;

namespace Enrollment_System
{
    public partial class StudentEntryForm : Form
    {

        public StudentEntryForm()
        {
            InitializeComponent();
            RemarksComboBox.Items.Add("New");
            RemarksComboBox.Items.Add("Old");
            RemarksComboBox.Items.Add("Transferee");
            RemarksComboBox.Items.Add("Shiftee");
            RemarksComboBox.Items.Add("Cross Enrollee");
            RemarksComboBox.SelectedIndex = 0;
        } 

        //SAVE BUTTON
        private void SaveButton_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\VS\Databases\EnrollmentSystem\Malalay.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection myConnection = new SqlConnection(connectionString);
            string sql = "SELECT * FROM STUDENTFILE";
            myConnection.Open();
            SqlCommand thisCommand = myConnection.CreateCommand();
            thisCommand.CommandText = sql;
            SqlDataReader thisDataReader = thisCommand.ExecuteReader();

            int approve = 1;
            while (thisDataReader.Read())
            {
                if (thisDataReader["STFSTUDID"].ToString().Trim() == IDNumberTextBox.Text.Trim())
                {
                    approve = 0;
                    break;
                }
            }
            myConnection.Close();

            if (approve == 1)
            {
                try
                {
                    if (IDNumberTextBox.Text.Equals("") ||
                        LastNameTextBox.Text.Equals("") ||
                        MiddleNameTextBox.Text.Equals("") ||
                        FirstNameTextBox.Text.Equals("") ||
                        CourseTextBox.Text.Equals("") ||
                        YearTextBox.Text.Equals("") ||
                        RemarksComboBox.Text.Equals(""))
                    {
                        MessageBox.Show("Please Fill Up All Fields");
                    }
                    else
                    {
                        SqlDataAdapter thisAdapter = new SqlDataAdapter(sql, myConnection);
                        SqlCommandBuilder thisBuilder = new SqlCommandBuilder(thisAdapter);
                        DataSet thisDataSet = new DataSet();
                        thisAdapter.Fill(thisDataSet, "StudentFile");
                        DataRow thisRow = thisDataSet.Tables["StudentFile"].NewRow();
                        thisRow["STFSTUDID"] = Convert.ToInt64(IDNumberTextBox.Text);
                        thisRow["STFSTUDLNAME"] = LastNameTextBox.Text;
                        thisRow["STFSTUDMNAME"] = MiddleNameTextBox.Text;
                        thisRow["STFSTUDFNAME"] = FirstNameTextBox.Text;
                        thisRow["STFSTUDCOURSE"] = CourseTextBox.Text;
                        thisRow["STFSTUDYEAR"] = YearTextBox.Text;
                        thisRow["STFSTUDREMARKS"] = RemarksComboBox.Text;
                        thisRow["STFSTUDSTATUS"] = "AC";
                        thisDataSet.Tables["StudentFile"].Rows.Add(thisRow);
                        thisAdapter.Update(thisDataSet, "StudentFile");
                        MessageBox.Show("Student Record Added!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Student ID Already Exists...");
            }
        }

        //CANCEL BUTTON
        private void CancelButton_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        //CLEAR FORM
        private void ClearForm()
        {
            IDNumberTextBox.Clear();
            FirstNameTextBox.Clear();
            MiddleNameTextBox.Clear();
            LastNameTextBox.Clear();
            CourseTextBox.Clear();
            YearTextBox.Clear();
            if (RemarksComboBox.Items.Count > 0)
                RemarksComboBox.SelectedIndex = 0; // Reset to the first item
            else
                RemarksComboBox.SelectedIndex = -1; // Or clear selection if list is empty

            IDNumberTextBox.Focus(); // Set focus back to the first field
        }

        //BACK BUTTON
        private void BackButton_Click(object sender, EventArgs e)
        {
            MenuForm mainMenu = new MenuForm();
            mainMenu.Show();
            this.Hide();
        }

        private void StudentEntryButton_Click(object sender, EventArgs e)
        {
            StudentEntryForm studentEntryForm = new StudentEntryForm();
            studentEntryForm.StartPosition = FormStartPosition.CenterScreen; // Centers on screen
            studentEntryForm.Show();
            this.Hide();
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

        private void EnrollmentButton_Click(object sender, EventArgs e)
        {
            StudentEnrollmentEntry studentEnroll = new StudentEnrollmentEntry();
            studentEnroll.StartPosition = FormStartPosition.CenterScreen; // Centers on screen
            studentEnroll.Show();
            this.Hide();
        }

        private void StudentEntryLabel_Click(object sender, EventArgs e)
        {

        }
    }
}