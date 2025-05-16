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
    public partial class SubjectScheduleEntryForm : Form
    {
        private SqlDataAdapter scheduleAdapter;
        private DataSet enrollmentDataSet;
        private DataTable scheduleTable;
        //string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\VS\Databases\EnrollmentSystem\Malalay.mdf;Integrated Security=True;Connect Timeout=30";
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Bryce Mendez\Documents\MENDEZ.mdf"";Integrated Security=True;Connect Timeout=30";
        
        
        public SubjectScheduleEntryForm()
        {
            InitializeComponent();
        }
        private void SubjectScheduleEntryForm_Load(object sender, EventArgs e)
        {
            //for the 00:00 time sa pag load
            DateTime todayAtMidnight = DateTime.Today;
            StartTimeDateTimePicker.Value = todayAtMidnight;
            EndTimeDateTimePicker.Value = todayAtMidnight.AddHours(1);

            StartTimeDateTimePicker.Format = DateTimePickerFormat.Custom;
            StartTimeDateTimePicker.CustomFormat = "hh:mm tt";
            StartTimeDateTimePicker.ShowUpDown = true;

            EndTimeDateTimePicker.Format = DateTimePickerFormat.Custom;
            EndTimeDateTimePicker.CustomFormat = "hh:mm tt";
            EndTimeDateTimePicker.ShowUpDown = true;

            enrollmentDataSet = new DataSet();
            scheduleAdapter = new SqlDataAdapter("SELECT * FROM SubjectSchedFile", connectionString);

            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(scheduleAdapter);
            scheduleAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;

            scheduleAdapter.Fill(enrollmentDataSet, "SubjectSchedFile");
            scheduleTable = enrollmentDataSet.Tables["SubjectSchedFile"];
        }

        private void SubjectCodeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
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
        private void SaveButton_Click_1(object sender, EventArgs e)
        {
            // Basic Empty Field Validation
            if (string.IsNullOrWhiteSpace(SubjectEdpCodeTextBox.Text))
            {
                MessageBox.Show("EDP Code cannot be empty.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                SubjectEdpCodeTextBox.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(SubjectCodeTextBox.Text) || string.IsNullOrWhiteSpace(DescriptionLabel.Text) || DescriptionLabel.Text == "Subject Code Not Found")
            {
                MessageBox.Show("Valid Subject Code and Description are required.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                SubjectCodeTextBox.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(DaysTextBox.Text))
            {
                MessageBox.Show("Days field cannot be empty. Please enter days (e.g., M,W,F).", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DaysTextBox.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(RoomTextBox.Text) ||
                string.IsNullOrWhiteSpace(SectionTextBox.Text) ||
                string.IsNullOrWhiteSpace(SchoolYearTextBox.Text))
            {
                MessageBox.Show("Room, Section, and School Year cannot be empty.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (string.IsNullOrWhiteSpace(RoomTextBox.Text)) RoomTextBox.Focus();
                else if (string.IsNullOrWhiteSpace(SectionTextBox.Text)) SectionTextBox.Focus();
                else SchoolYearTextBox.Focus();
                return;
            }
            // DaysTextBox Input Validation
            string rawDaysInput = DaysTextBox.Text.Trim();
            string processedDaysForStorage;
            List<string> dayTokens = rawDaysInput.Split(',')
                                             .Select(day => day.Trim().ToUpperInvariant())
                                             .Where(day => !string.IsNullOrEmpty(day))
                                             .ToList();
            if (!dayTokens.Any())
            {
                MessageBox.Show("Days field is invalid. Please enter valid day codes ( M,W,F or T,TH), separated by commas.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DaysTextBox.Focus();
                return;
            }
            var validDayCodesSet = new HashSet<string> { "M", "T", "W", "TH", "F", "S" };
            foreach (string token in dayTokens)
            {
                if (!validDayCodesSet.Contains(token))
                {
                    MessageBox.Show($"Invalid day code '{token}' found. Please use recognized day abbreviations ( M, T, W, TH, F, S), separated by commas.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    DaysTextBox.Focus();
                    return;
                }
            }
            List<string> distinctDayTokens = dayTokens.Distinct().ToList();

            //For Maximum of only 3 days cuz of the varchar length being only 3. change if maka kuhag further instructions
            if (distinctDayTokens.Count > 3)
            {
                MessageBox.Show("You can select a maximum of 3 distinct days for a schedule.", "Input Error - Too Many Days", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DaysTextBox.Focus();
                return;
            }

            var dayOrder = new Dictionary<string, int>
            {
                { "M", 1 }, { "T", 2 }, { "W", 3 }, { "TH", 4 }, { "F", 5 }, { "S", 6 }
            };
            distinctDayTokens.Sort((d1, d2) =>
            {
                int order1 = dayOrder.TryGetValue(d1, out int o1) ? o1 : int.MaxValue;
                int order2 = dayOrder.TryGetValue(d2, out int o2) ? o2 : int.MaxValue;
                return order1.CompareTo(order2);
            });
            processedDaysForStorage = string.Concat(distinctDayTokens);
            if (string.IsNullOrWhiteSpace(MaxSizeTextBox.Text))
            {
                MessageBox.Show("Max Size cannot be empty.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MaxSizeTextBox.Focus();
                return;
            }
            if (!int.TryParse(MaxSizeTextBox.Text, out int maxSize) || maxSize < 0)
            {
                MessageBox.Show("Max Size must be a valid non-negative number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MaxSizeTextBox.Focus();
                return;
            }
            if (!int.TryParse(ClassSizeTextBox.Text, out int classSize) || classSize < 0)
            {
                MessageBox.Show("Class Size must be a valid non-negative number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ClassSizeTextBox.Focus();
                return;
            }
            if (classSize > maxSize)
            {
                MessageBox.Show("Class size cannot exceed maximum size!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ClassSizeTextBox.Focus();
                return;
            }
            if (EndTimeDateTimePicker.Value <= StartTimeDateTimePicker.Value)
            {
                MessageBox.Show("End Time must be after Start Time.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                EndTimeDateTimePicker.Focus();
                return;
            }
            try
            {
                string filterExpression = $"SSFEDPCODE = '{SubjectEdpCodeTextBox.Text.Trim().Replace("'", "''")}'";
                DataRow[] existingRowsByEdpCode = scheduleTable.Select(filterExpression);
                if (existingRowsByEdpCode.Length > 0)
                {
                    MessageBox.Show("A subject schedule with this EDP code already exists.", "Duplicate EDP Code", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    SubjectEdpCodeTextBox.Focus();
                    return;
                }
                DataRow newRow = scheduleTable.NewRow();
                newRow["SSFEDPCODE"] = SubjectEdpCodeTextBox.Text.Trim();
                newRow["SSFSUBJCODE"] = SubjectCodeTextBox.Text.Trim();
                newRow["SSFSTARTTIME"] = StartTimeDateTimePicker.Value;
                newRow["SSFENDTIME"] = EndTimeDateTimePicker.Value;
                newRow["SSFXM"] = StartTimeDateTimePicker.Value.ToString("tt");
                newRow["SSFDAYS"] = processedDaysForStorage;
                newRow["SSFROOM"] = RoomTextBox.Text.Trim();
                newRow["SSFSECTION"] = SectionTextBox.Text.Trim();
                newRow["SSFSCHOOLYEAR"] = SchoolYearTextBox.Text.Trim();
                newRow["SSFMAXSIZE"] = maxSize;
                newRow["SSFCLASSSIZE"] = classSize;
                newRow["SSFSTATUS"] = "AC";

                scheduleTable.Rows.Add(newRow);
                scheduleAdapter.Update(enrollmentDataSet, "SubjectSchedFile");
                MessageBox.Show("Subject schedule added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearButton_Click_1(sender, e);
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"Database Error saving schedule: {sqlEx.Message}\nError Code: {sqlEx.Number}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred while saving the schedule: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            MaxSizeTextBox.Text = "";
            ClassSizeTextBox.Text = "";
            DateTime todayAtMidnight = DateTime.Today;
            StartTimeDateTimePicker.Value = todayAtMidnight;
            EndTimeDateTimePicker.Value = todayAtMidnight.AddHours(1);
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
        private void StudentEntryButton_Click(object sender, EventArgs e)
        {
            StudentEntryForm studentEntryForm = new StudentEntryForm();
            studentEntryForm.StartPosition = FormStartPosition.CenterScreen;
            studentEntryForm.Show();
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

