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
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Bryce Mendez\Documents\MENDEZ.mdf;Integrated Security=True;Connect Timeout=30";
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

        //CANCEL BUTTON
        private void CancelButton_Click_1(object sender, EventArgs e)
        {
            this.Close();
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
                string connectionString = @"your_connection_string_here";
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
                                    }
                                    else if (CoRequisiteRadioButton.Checked)
                                    {
                                        SubjectDataGridView.Rows[0].Cells["CoPreColumn"].Value = "Co-Requisite";
                                    }
                                    break;
                                }
                            }

                            if (!found)
                            {
                                MessageBox.Show("Subject Not Found");
                            }
                        }
                    }
                }
            }
        }
    }
}
