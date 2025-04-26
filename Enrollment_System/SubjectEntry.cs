using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enrollment_System
{
    public partial class SubjectEntry : Form
    {
        public SubjectEntry()
        {
            InitializeComponent();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Bryce Mendez\Documents\MENDEZ.mdf;Integrated Security=True;Connect Timeout=30";

            using (SqlConnection thisConnection = new SqlConnection(connectionString))
            {
                try
                {
                    thisConnection.Open();

                    // Check if subject already exists for this course
                    string checkSql = @"SELECT COUNT(*) FROM SUBJECTFILE 
                          WHERE SFSUBJCODE = @subjectCode
                          AND SFSUBJCOURSECODE = @courseCode";

                    using (SqlCommand checkCommand = new SqlCommand(checkSql, thisConnection))
                    {
                        checkCommand.Parameters.AddWithValue("@subjectCode", SubjectCodeTextBox.Text.Trim());
                        checkCommand.Parameters.AddWithValue("@courseCode", CourseCodeComboBox.Text.Trim());

                        int count = (int)checkCommand.ExecuteScalar();

                        if (count > 0)
                        {
                            MessageBox.Show("This subject code already exists for the selected course.");
                            return;
                        }
                    }

                    // Validate all required fields
                    if (string.IsNullOrWhiteSpace(SubjectCodeTextBox.Text) ||
                        string.IsNullOrWhiteSpace(DescriptionTextBox.Text) ||
                        string.IsNullOrWhiteSpace(UnitsTextBox.Text) ||
                        string.IsNullOrWhiteSpace(CategoryComboBox.Text) ||
                        string.IsNullOrWhiteSpace(OfferingsComboBox.Text) ||
                        string.IsNullOrWhiteSpace(CourseCodeComboBox.Text) ||
                        string.IsNullOrWhiteSpace(CurriculumYearTextBox.Text))
                    {
                        MessageBox.Show("Please fill in all required fields.");
                        return;
                    }

                    // Insert main subject record
                    string insertSubjectSql = @"INSERT INTO SUBJECTFILE 
                                  (SFSUBJCODE, SFSUBJDESC, SFSUBJUNITS, SFSUBJCATEGORY, 
                                   SFSUBJREGOFRNG, SFSUBJCOURSECODE, SFSUBJCURRCODE)
                                  VALUES (@code, @desc, @units, @category, @offering, @courseCode, @currCode)";

                    using (SqlCommand insertCommand = new SqlCommand(insertSubjectSql, thisConnection))
                    {
                        insertCommand.Parameters.AddWithValue("@code", SubjectCodeTextBox.Text.Trim());
                        insertCommand.Parameters.AddWithValue("@desc", DescriptionTextBox.Text.Trim());
                        insertCommand.Parameters.AddWithValue("@units", Convert.ToInt16(UnitsTextBox.Text));
                        insertCommand.Parameters.AddWithValue("@category", CategoryComboBox.Text.Substring(0, 3));
                        insertCommand.Parameters.AddWithValue("@offering", Convert.ToInt16(OfferingsComboBox.Text.Substring(0, 1)));
                        insertCommand.Parameters.AddWithValue("@courseCode", CourseCodeComboBox.Text.Trim());
                        insertCommand.Parameters.AddWithValue("@currCode", CurriculumYearTextBox.Text.Trim());

                        int rowsAffected = insertCommand.ExecuteNonQuery();

                        if (rowsAffected == 0)
                        {
                            MessageBox.Show("Failed to add subject.");
                            return;
                        }
                    }

                    // Handle prerequisite/co-requisite if specified
                    if (!string.IsNullOrWhiteSpace(RequisiteSubjectCodeTextBox.Text) &&
                        (PreRequisiteRadioButton.Checked || CoRequisiteRadioButton.Checked))
                    {
                        string insertRequisiteSql = @"INSERT INTO SubjectPreqFile 
                                        (SUBJCODE, SUBJPRECODE, SUBJCATEGORY)
                                        VALUES (@subjCode, @subjPreCode, @subjCategory)";

                        using (SqlCommand requisiteCommand = new SqlCommand(insertRequisiteSql, thisConnection))
                        {
                            requisiteCommand.Parameters.AddWithValue("@subjCode", SubjectCodeTextBox.Text.Trim());
                            requisiteCommand.Parameters.AddWithValue("@subjPreCode", RequisiteSubjectCodeTextBox.Text.Trim());
                            requisiteCommand.Parameters.AddWithValue("@subjCategory",
                                PreRequisiteRadioButton.Checked ? "PR" : "CO");

                            requisiteCommand.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Subject added successfully!");
                     // Optional: Add method to clear form fields after successful save
                }
                catch (FormatException)
                {
                    MessageBox.Show("Please enter valid numbers for Units and Offerings fields.");
                }
                catch (SqlException sqlEx) when (sqlEx.Number == 2627)
                {
                    MessageBox.Show("Error: This subject code already exists for the selected course.");
                }
                catch (SqlException sqlEx)
                {
                    MessageBox.Show($"Database error: {sqlEx.Message}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }
        

        private void BackButton_Click(object sender, EventArgs e)
        {
            MenuForm mainMenu = new MenuForm();
            mainMenu.Show();
            this.Hide();
        }

        private void SubjectEntry_Load(object sender, EventArgs e)
        {
            // Load UI elements first
            CategoryComboBox.Items.AddRange(new[] { "Lecture", "Laboratory" });
            OfferingsComboBox.Items.AddRange(new[] { "1st Semester", "2nd Semester", "Summer" });
            CourseCodeComboBox.Items.AddRange(new[] { "BSIT", "BSIS" });
            // Then load data asynchronously
            Task.Run(() => {
                this.Invoke((MethodInvoker)delegate {
                 
                    LoadSubjects();
                });
            });
        }

        private void LoadSubjects()
        {
            try
            {
                string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Bryce Mendez\Documents\MENDEZ.mdf;Integrated Security=True;Connect Timeout=30";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string sql = "SELECT SFSUBJCODE AS [Subject Code], SFSUBJDESC AS Description, " +
                                "SFSUBJUNITS AS Units FROM SUBJECTFILE";
                    using (SqlDataAdapter da = new SqlDataAdapter(sql, conn))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading subjects: {ex.Message}");
            }
        }


    }
}
