using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            //string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\VS\Databases\EnrollmentSystem\Malalay.mdf;Integrated Security=True;Connect Timeout=30";
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Bryce Mendez\Documents\MENDEZ.mdf"";Integrated Security=True;Connect Timeout=30";
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
                        newSubjectRow["SFSUBJUNITS"] = unitsValue;
                        newSubjectRow["SFSUBJREGOFRNG"] = OfferingsComboBox.Text.Substring(0, 1);
                        newSubjectRow["SFSUBJCATEGORY"] = CategoryComboBox.Text.Substring(0, 3);
                        newSubjectRow["SFSUBJSTATUS"] = "AC";
                        newSubjectRow["SFSUBJCOURSECODE"] = CourseCodeComboBox.Text;
                        newSubjectRow["SFSUBJCURRCODE"] = CurriculumYearTextBox.Text.Trim();

                        subjectTable.Rows.Add(newSubjectRow);
                        subjectAdapter.Update(mainDataSet, "SubjectFile");

                        bool requisiteSaved = false;
                        int savedRequisiteCount = 0;

                        // MODIFIED SECTION - Now processes all rows in SubjectDataGridView
                        if (SubjectDataGridView.Rows.Count > 0 &&
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

                                    foreach (DataGridViewRow row in SubjectDataGridView.Rows)
                                    {
                                        if (row.IsNewRow) continue;

                                        string reqSubjectCode = row.Cells["SubjectCodeColumn"].Value?.ToString();
                                        if (string.IsNullOrWhiteSpace(reqSubjectCode)) continue;

                                        // Determine if this is Pre or Co requisite from the row
                                        string reqType = "PR"; // Default to Pre-Requisite
                                        if (row.Cells["CoPreColumn"].Value?.ToString() == "Co-Requisite")
                                        {
                                            reqType = "CO";
                                        }

                                        string reqFilter = $"SUBJCODE = '{SubjectCodeTextBox.Text.Trim().Replace("'", "''")}' " +
                                                        $"AND SUBJPRECODE = '{reqSubjectCode.Replace("'", "''")}'";

                                        if (requisiteTable.Select(reqFilter).Length > 0)
                                        {
                                            // Skip duplicates
                                            continue;
                                        }

                                        DataRow requisiteRow = requisiteTable.NewRow();
                                        requisiteRow["SUBJCODE"] = SubjectCodeTextBox.Text.Trim();
                                        requisiteRow["SUBJPRECODE"] = reqSubjectCode;
                                        requisiteRow["SUBJCATEGORY"] = reqType;
                                        requisiteTable.Rows.Add(requisiteRow);
                                        savedRequisiteCount++;
                                        requisiteSaved = true;
                                    }

                                    if (requisiteSaved)
                                    {
                                        requisiteAdapter.Update(requisiteDataSet, "SubjectPreqFile");
                                    }
                                }
                                catch (SqlException sqlExReq)
                                {
                                    MessageBox.Show($"Database Error saving requisites: {sqlExReq.Message}\nError Code: {sqlExReq.Number}\n\n(Main subject was saved successfully)", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                catch (Exception exReq)
                                {
                                    MessageBox.Show($"Error saving requisites: {exReq.Message}\n\n(Main subject was saved successfully)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }

                        // Final Success Message
                        string successMessage = "Subject Recorded Successfully!";
                        if (requisiteSaved)
                        {
                            successMessage += $"\n{savedRequisiteCount} requisite(s) saved.";
                        }
                        MessageBox.Show(successMessage, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Duplicate Subject Code and Course Code combination already exists.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (FormatException formatEx)
                {
                    MessageBox.Show($"Data Format Error: {formatEx.Message}\nPlease check numeric input for Units.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (ArgumentOutOfRangeException argEx)
                {
                    MessageBox.Show($"Data Error: {argEx.Message}\nPlease ensure Offering and Category are selected.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (SqlException sqlEx)
                {
                    MessageBox.Show($"Database Error: {sqlEx.Message}\nError Code: {sqlEx.Number}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
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
        //REQUISITE TEXT BOX
        private void SubjectRequisiteTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Bryce Mendez\Documents\MENDEZ.mdf"";Integrated Security=True;Connect Timeout=30";

                string requisiteCode = SubjectRequisiteTextBox.Text.Trim();

                // Check for duplicate in existing rows
                bool alreadyExists = false;
                foreach (DataGridViewRow row in SubjectDataGridView.Rows)
                {
                    if (row.IsNewRow) continue;
                    if (row.Cells["SubjectCodeColumn"].Value?.ToString() == requisiteCode)
                    {
                        alreadyExists = true;
                        break;
                    }
                }

                if (alreadyExists)
                {
                    MessageBox.Show("This subject is already added as a requisite.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    SubjectRequisiteTextBox.SelectAll();
                    return;
                }

                using (SqlConnection thisConnection = new SqlConnection(connectionString))
                {
                    thisConnection.Open();
                    string commandText = "SELECT * FROM SUBJECTFILE WHERE SFSUBJCODE = @SubjectCode";
                    using (SqlCommand thisCommand = new SqlCommand(commandText, thisConnection))
                    {
                        thisCommand.Parameters.AddWithValue("@SubjectCode", requisiteCode);
                        using (SqlDataReader thisReader = thisCommand.ExecuteReader())
                        {
                            if (thisReader.Read())
                            {
                                int newRowIndex = SubjectDataGridView.Rows.Add();
                                DataGridViewRow newRow = SubjectDataGridView.Rows[newRowIndex];

                                newRow.Cells["SubjectCodeColumn"].Value = thisReader["SFSUBJCODE"].ToString();
                                newRow.Cells["DescriptionColumn"].Value = thisReader["SFSUBJDESC"].ToString();
                                newRow.Cells["UnitsColumn"].Value = thisReader["SFSUBJUNITS"].ToString();

                                if (PreRequisiteRadioButton.Checked)
                                {
                                    newRow.Cells["CoPreColumn"].Value = "Pre-Requisite";
                                }
                                else if (CoRequisiteRadioButton.Checked)
                                {
                                    newRow.Cells["CoPreColumn"].Value = "Co-Requisite";
                                }

                                SubjectRequisiteTextBox.Clear();
                            }
                            else
                            {
                                MessageBox.Show("Subject Not Found", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            SubjectDataGridView.EndEdit();  // Force commit the edit
                            SubjectDataGridView.Refresh();  // Force UI refresh
                            SubjectDataGridView.CurrentCell = null; // Remove selection highlight

                            // Optional: Auto-scroll to the new row
                            SubjectDataGridView.FirstDisplayedScrollingRowIndex =
                            SubjectDataGridView.RowCount - 1;
                            SubjectDataGridView.RowTemplate.MinimumHeight = 30;
                        }
                    }
                }
            }
        }

        private void StudentEntryButton_Click(object sender, EventArgs e)
        {
            StudentEntryForm studentEntryForm = new StudentEntryForm();
            studentEntryForm.StartPosition = FormStartPosition.CenterScreen;
            studentEntryForm.Show();
            this.Hide();
        }
        private void SubjectScheduleEntryButton_Click(object sender, EventArgs e)
        {
            SubjectScheduleEntryForm subjectScheduleEntryForm = new SubjectScheduleEntryForm();
            subjectScheduleEntryForm.StartPosition = FormStartPosition.CenterScreen;
            subjectScheduleEntryForm.Show();
            this.Hide();
        }
        private void SubjectEntryButton_Click(object sender, EventArgs e)
        {
            SubjectEntry subjectEntryForm = new SubjectEntry();
            subjectEntryForm.StartPosition = FormStartPosition.CenterScreen;
            subjectEntryForm.Show();
            this.Hide();
        }
        private void EnrollmentButton_Click(object sender, EventArgs e)
        {
            StudentEnrollmentEntry studentEnroll = new StudentEnrollmentEntry();
            studentEnroll.StartPosition = FormStartPosition.CenterScreen;
            studentEnroll.Show();
            this.Hide();
        }
    }
}
