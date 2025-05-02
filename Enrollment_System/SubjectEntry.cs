using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Enrollment_System
{
    public partial class SubjectEntry : Form
    {
        private object subjectAdapter;
        private object mainDataSet;

        public SubjectEntry()
        {
            InitializeComponent();
        }

        //SAVE BUTTON
        private void SaveButton_Click_1(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Han Song\OneDrive\Documents\Malalay.mdf"";Integrated Security=True;Connect Timeout=30";
            using (SqlConnection thisConnection = new SqlConnection(connectionString))
            {
                SqlDataAdapter subjectAdapter = null;
                DataSet mainDataSet = new DataSet();
                DataTable subjectTable = null;

                DataRow findRow = null;

                try
                {

                    string subjectSql = "SELECT * FROM SubjectFile";
                    subjectAdapter = new SqlDataAdapter(subjectSql, thisConnection);
                    SqlCommandBuilder subjectCmdBuilder = new SqlCommandBuilder(subjectAdapter);
                    subjectAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;

                    thisConnection.Open();
                    subjectAdapter.Fill(mainDataSet, "SubjectFile");
                    subjectTable = mainDataSet.Tables["SubjectFile"];

                    DataColumn[] keys = new DataColumn[2];
                    keys[0] = subjectTable.Columns["SFSUBJCODE"];
                    keys[1] = subjectTable.Columns["SFSUBJCOURSECODE"];
                    subjectTable.PrimaryKey = keys;
                    String[] valuesToSearch = new String[2];
                    valuesToSearch[0] = SubjectCodeTextBox.Text.Trim();
                    valuesToSearch[1] = CourseCodeComboBox.Text;
                    findRow = subjectTable.Rows.Find(valuesToSearch);

                    if (string.IsNullOrWhiteSpace(SubjectCodeTextBox.Text) ||
                        string.IsNullOrWhiteSpace(DescriptionTextBox.Text) ||
                        string.IsNullOrWhiteSpace(UnitsTextBox.Text) ||
                        string.IsNullOrWhiteSpace(CurriculumYearTextBox.Text) ||
                        OfferingsComboBox.SelectedIndex == -1 ||
                        CategoryComboBox.SelectedIndex == -1 ||
                        CourseCodeComboBox.SelectedIndex == -1)
                    {
                        MessageBox.Show("Please Fill Up All Required Subject Fields", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        return;
                    }

                    short unitsValue;
                    if (!short.TryParse(UnitsTextBox.Text, out unitsValue))
                    {
                        MessageBox.Show("Units must be a valid whole number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (OfferingsComboBox.SelectedIndex == -1 || OfferingsComboBox.Text.Length < 1)
                    {
                        MessageBox.Show("Please select a valid Offering.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (CategoryComboBox.SelectedIndex == -1 || CategoryComboBox.Text.Length < 3)
                    {
                        MessageBox.Show("Please select a valid Category.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Save Logic
                    if (findRow == null) 
                    {
                        DataRow newSubjectRow = subjectTable.NewRow();
                        newSubjectRow["SFSUBJCODE"] = SubjectCodeTextBox.Text.Trim();
                        newSubjectRow["SFSUBJDESC"] = DescriptionTextBox.Text.Trim();
                        newSubjectRow["SFSUBJUNITS"] = unitsValue; // Use the parsed short value
                        newSubjectRow["SFSUBJREGOFRNG"] = OfferingsComboBox.Text.Substring(0, 1);
                        newSubjectRow["SFSUBJCATEGORY"] = CategoryComboBox.Text.Substring(0, 3);
                        newSubjectRow["SFSUBJSTATUS"] = "AC";
                        newSubjectRow["SFSUBJCOURSECODE"] = CourseCodeComboBox.Text;
                        newSubjectRow["SFSUBJCURRCODE"] = CurriculumYearTextBox.Text.Trim();

                        subjectTable.Rows.Add(newSubjectRow);
                        subjectAdapter.Update(mainDataSet, "SubjectFile"); // Saves SubjectFile changes 

                        bool requisiteSaved = false;
                        if (!string.IsNullOrWhiteSpace(SubjectRequisiteTextBox.Text) &&
                            (PreRequisiteRadioButton.Checked || CoRequisiteRadioButton.Checked))
                        {
                            string requisiteSql = "SELECT * FROM SubjectPreqFile";
                            using (SqlDataAdapter requisiteAdapter = new SqlDataAdapter(requisiteSql, thisConnection))
                            {
                                try
                                {
                                    SqlCommandBuilder requisiteCmdBuilder = new SqlCommandBuilder(requisiteAdapter);
                                    requisiteAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;

                                    DataSet requisiteDataSet = new DataSet();
                                    requisiteAdapter.Fill(requisiteDataSet, "SubjectPreqFile");
                                    DataTable requisiteTable = requisiteDataSet.Tables["SubjectPreqFile"];
                                    string reqFilter = $"SUBJCODE = '{SubjectCodeTextBox.Text.Trim().Replace("'", "''")}' AND SUBJPRECODE = '{SubjectRequisiteTextBox.Text.Trim().Replace("'", "''")}'";
                                    if (requisiteTable.Select(reqFilter).Length > 0)
                                    {
                                        MessageBox.Show($"Requisite '{SubjectRequisiteTextBox.Text.Trim()}' already exists for subject '{SubjectCodeTextBox.Text.Trim()}'. Requisite not saved again.", "Duplicate Requisite", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                    else
                                    {
                                        DataRow requisiteRow = requisiteTable.NewRow();
                                        //ascertains thaat column names are in subjpreqfile
                                        requisiteRow["SUBJCODE"] = SubjectCodeTextBox.Text.Trim();    // Main subject code
                                        requisiteRow["SUBJPRECODE"] = SubjectRequisiteTextBox.Text.Trim(); // Requisite subject code
                                        requisiteRow["SUBJCATEGORY"] = PreRequisiteRadioButton.Checked ? "PR" : "CO"; // sets cagory

                                        requisiteTable.Rows.Add(requisiteRow);
                                        requisiteAdapter.Update(requisiteDataSet, "SubjectPreqFile"); 
                                        requisiteSaved = true;
                                    }
                                }
                                catch (SqlException sqlExReq)
                                {
                                    MessageBox.Show($"Database Error saving requisite: {sqlExReq.Message}\nError Code: {sqlExReq.Number}\n\n(Main subject was saved successfully)", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                catch (Exception exReq)
                                {
                                    MessageBox.Show($"Error saving requisite: {exReq.Message}\n\n(Main subject was saved successfully)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }

                        // Final Success Message
                        string successMessage = "Entries Recorded!"; // Original message
                        if (requisiteSaved)
                        {
                            successMessage = "Subject Recorded Successfully!\nRequisite Information also Saved.";
                        }
                        MessageBox.Show(successMessage, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Duplicate Subject Code and Course Code combination already exists.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning); // Modified message for clarity
                    }
                }
                catch (FormatException formatEx)
                {
                    MessageBox.Show($"Data Format Error: {formatEx.Message}\nPlease check numeric input for Units.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (ArgumentOutOfRangeException argEx) // Catch substring errors
                {
                    MessageBox.Show($"Data Error: {argEx.Message}\nPlease ensure Offering and Category are selected.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (SqlException sqlEx) // catch main SQL errors
                {
                    MessageBox.Show($"Database Error: {sqlEx.Message}\nError Code: {sqlEx.Number}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)//catch unsusepected errosr
                {
                    MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally 
                {
                    if (thisConnection != null && thisConnection.State == ConnectionState.Open)
                    {
                        thisConnection.Close();
                    }
                    subjectAdapter?.Dispose();
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
                string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Han Song\OneDrive\Documents\Malalay.mdf"";Integrated Security=True;Connect Timeout=30";
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
