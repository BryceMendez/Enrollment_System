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
        public SubjectScheduleEntryForm()
        {
            InitializeComponent();
        }

        private void SubjectScheduleEntry_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void SubjectCodeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Han Song\OneDrive\Documents\Malalay.mdf"";Integrated Security=True;Connect Timeout=30";

                SqlConnection myConnection = new SqlConnection(connectionString);
                myConnection.Open();

                string commandText = "SELECT * FROM SUBJECTFILE";
                SqlCommand myCommand = myConnection.CreateCommand();
                myCommand.CommandText = commandText;

                SqlDataReader myReader = myCommand.ExecuteReader();

                bool flag = false;
                while (myReader.Read())
                {
                    if (myReader["SFSUBJCODE"].ToString().Trim() == SubjectCodeTextBox.Text.Trim())
                    {
                        flag = true;
                        DescriptionLabel.Text = myReader["SFSUBJDESC"].ToString();
                        break;
                    }
                    else
                    {
                        continue;
                    }


                }




                MessageBox.Show("Pressed Enter");
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Han Song\OneDrive\Documents\Malalay.mdf"";Integrated Security=True;Connect Timeout=30";

            SqlConnection myConnection = new SqlConnection(connectionString);

            string sql = "SELECT * FROM SUBJECTFILE";

            SqlDataAdapter thisAdapter = new SqlDataAdapter(sql, myConnection);

            SqlCommandBuilder thisBuilder = new SqlCommandBuilder(thisAdapter);

            DataSet thisDataSet = new DataSet();

            thisAdapter.Fill(thisDataSet, "SubjectFile");

            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void SubjectScheduleEntryForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click_1(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
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

