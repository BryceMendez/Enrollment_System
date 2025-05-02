using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Enrollment_System
{
    public partial class SubjectEntry : Form
    {
        public SubjectEntry()
        {
            InitializeComponent();
        }

        //SAVE BUTTON
        private void SaveButton_Click_1(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Bryce Mendez\Documents\MENDEZ.mdf"";Integrated Security=True;Connect Timeout=30;";
            using (SqlConnection thisConnection = new SqlConnection(connectionString))
            {
                string sql = "SELECT * FROM SubjectFile";
                SqlDataAdapter thisAdapter = new SqlDataAdapter(sql, thisConnection);
                SqlCommandBuilder thisBuilder = new SqlCommandBuilder(thisAdapter);
                DataSet thisDataSet = new DataSet();
                thisAdapter.Fill(thisDataSet, "SubjectFile");
                DataColumn[] keys = new DataColumn[2];
                keys[0] = thisDataSet.Tables["SubjectFile"].Columns["SFSUBJCODE"];
                keys[1] = thisDataSet.Tables["SubjectFile"].Columns["SFSUBJCOURSECODE"];
                thisDataSet.Tables["SubjectFile"].PrimaryKey = keys;
                String[] valuesToSearch = new String[2];
                valuesToSearch[0] = SubjectCodeTextBox.Text;
                valuesToSearch[1] = CourseCodeComboBox.Text;
                DataRow findRow = thisDataSet.Tables["SubjectFile"].Rows.Find(valuesToSearch);

                try {                     
                    if (SubjectCodeTextBox.Text.Equals("") ||
                        DescriptionTextBox.Text.Equals("") ||
                        UnitsTextBox.Text.Equals("") ||
                        CurriculumYearTextBox.Text.Equals("") ||
                        SubjectRequisiteTextBox.Text.Equals("") ||
                        OfferingsComboBox.SelectedIndex == -1 ||
                        CategoryComboBox.SelectedIndex == -1 ||
                        CourseCodeComboBox.SelectedIndex == -1)
                    {
                        MessageBox.Show("Please Fill Up All Fields");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                if (findRow == null)
                {
                    DataRow thisRow = thisDataSet.Tables["SubjectFile"].NewRow();
                    thisRow["SFSUBJCODE"] = SubjectCodeTextBox.Text;
                    thisRow["SFSUBJDESC"] = DescriptionTextBox.Text;
                    thisRow["SFSUBJUNITS"] = Convert.ToInt16(UnitsTextBox.Text);
                    thisRow["SFSUBJREGOFRNG"] = OfferingsComboBox.Text.Substring(0, 1);
                    thisRow["SFSUBJCATEGORY"] = CategoryComboBox.Text.Substring(0, 3);
                    thisRow["SFSUBJSTATUS"] = "AC";
                    thisRow["SFSUBJCOURSECODE"] = CourseCodeComboBox.Text;
                    thisRow["SFSUBJCURRCODE"] = CurriculumYearTextBox.Text;
                    thisDataSet.Tables["SubjectFile"].Rows.Add(thisRow);
                    thisAdapter.Update(thisDataSet, "SubjectFile");
                    MessageBox.Show("Entries Recorded!");
                }
                else
                {
                    MessageBox.Show("Duplicate Entry");
                }
            }
        }

        //CLEAR BUTTON
        private void CancelButton_Click_1(object sender, EventArgs e)
        {
            SubjectCodeTextBox.Text = "";
            DescriptionTextBox.Text = "";
            UnitsTextBox.Text = "";
            CurriculumYearTextBox.Text = "";
            SubjectRequisiteTextBox.Text = "";
            OfferingsComboBox.SelectedIndex = -1;
            CategoryComboBox.SelectedIndex = -1;
            CourseCodeComboBox.SelectedIndex = -1;
            PreRequisiteRadioButton.Checked = false;
            CoRequisiteRadioButton.Checked = false;
            SubjectRequisiteTextBox.Text = "";
            SubjectDataGridView.Rows.Clear();
        }

        //BACK BUTTON
        private void BackButton_Click(object sender, EventArgs e)
        {
            MenuForm mainMenu = new MenuForm();
            mainMenu.Show();
            this.Hide();
        }

        //REQUISITE TEXT BOX
        private void SubjectRequisiteTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Bryce Mendez\Documents\MENDEZ.mdf"";Integrated Security=True;Connect Timeout=30;";
                using (SqlConnection thisConnection = new SqlConnection(connectionString))
                {
                    thisConnection.Open();
                    string commandText = "SELECT * FROM SUBJECTFILE";
                    using (SqlCommand thisCommand = new SqlCommand(commandText, thisConnection))
                    {
                        using (SqlDataReader thisReader = thisCommand.ExecuteReader())
                        {
                            bool found = false;

                            while (thisReader.Read())
                            {
                                if (thisReader["SFSUBJCODE"].ToString().Trim() == SubjectRequisiteTextBox.Text.Trim())
                                {
                                    found = true;

                                    SubjectDataGridView.Rows[0].Cells["SubjectCodeColumn"].Value = thisReader["SFSUBJCODE"].ToString();
                                    SubjectDataGridView.Rows[0].Cells["DescriptionColumn"].Value = thisReader["SFSUBJDESC"].ToString();
                                    SubjectDataGridView.Rows[0].Cells["UnitsColumn"].Value = thisReader["SFSUBJUNITS"].ToString();

                                    if (PreRequisiteRadioButton.Checked)
                                    {
                                        SubjectDataGridView.Rows[0].Cells["CoPreColumn"].Value = "Pre-Requisite";
                                        if (CoRequisiteRadioButton.Checked)
                                        {
                                            SubjectDataGridView.Rows[0].Cells["CoPreColumn"].Value = "Co-Requisite";
                                        }
                                    }
                                    break;
                                }
                                else
                                    continue;                          
                            }

                            if (found == false)
                            {
                                MessageBox.Show("Subject Not Found");
                            }
                        }
                    }
                }
            }
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
    }
}
