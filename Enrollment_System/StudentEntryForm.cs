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
            // Read the connection string when the form loads
            // Make sure the name "EnrollmentDBConnection" matches the name in App.config
            RemarksComboBox.Items.Add("New");
            RemarksComboBox.Items.Add("Old");
            RemarksComboBox.Items.Add("Transferee");
            RemarksComboBox.Items.Add("Shiftee");
            RemarksComboBox.Items.Add("Cross Enrollee");
            RemarksComboBox.SelectedIndex = 0;


        }

        // --- Keep your existing empty event handlers if needed ---
        private void IdNumTextBox_TextChanged(object sender, EventArgs e) { }
        private void FNameTextBox_TextChanged(object sender, EventArgs e) { }
        private void MNameTextBox_TextChanged(object sender, EventArgs e) { }
        private void LNameTextBox_TextChanged(object sender, EventArgs e) { }
        private void CourseTextBox_TextChanged(object sender, EventArgs e) { }
        private void YearTextBox_TextChanged(object sender, EventArgs e) { }
        private void RemarksComboBox_SelectedIndexChanged(object sender, EventArgs e) { }
        // --- ---

        private void SaveButton_Click(object sender, EventArgs e)
        {

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Bryce Mendez\Documents\MENDEZ.mdf;Integrated Security=True;Connect Timeout=30";

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
                        thisRow["STFSTUDFNAME"] = FirstNameTextBox.Text;
                        thisRow["STFSTUDCOURSE"] = CourseTextBox.Text;
                        thisRow["STFSTUDYEAR"] = YearTextBox.Text;
                        thisRow["STFSTUDREMARKS"] = RemarksComboBox.Text;

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

        private void CancelButton_Click(object sender, EventArgs e)
        {
            // Optional: Ask for confirmation before closing
            // if (MessageBox.Show("Are you sure you want to cancel and close?", "Confirm Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            // {
            //    this.Close(); // Close the current form
            // }

            // Or just clear the form:
            ClearForm();
        }

        // Helper method to clear form fields
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            MenuForm mainMenu = new MenuForm();
            mainMenu.Show();
            this.Hide();
        }
    }
}