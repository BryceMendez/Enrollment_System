using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enrollment_System
{
    public partial class StudentEnrollmentEntry : Form
    {
        public StudentEnrollmentEntry()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            MenuForm mainMenu = new MenuForm();
            mainMenu.Show();
            this.Hide();
        }

        private void SubjectChoosedDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void StudentEnrollmentEntry_Load(object sender, EventArgs e)
        {

        }
    }
}
