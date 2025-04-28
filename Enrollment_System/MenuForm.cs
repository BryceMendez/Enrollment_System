using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Enrollment_System;

namespace Enrollment_System
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void SubjectScheduleEntryButton_Click(object sender, EventArgs e)
        {
            SubjectScheduleEntryForm subjectScheduleEntryForm = new SubjectScheduleEntryForm();
            subjectScheduleEntryForm.Show();
            this.Hide();
        }

        private void MenuForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void SubjectEntryButton_Click(object sender, EventArgs e)
        {
            SubjectEntry subjectEntryForm = new SubjectEntry();
            subjectEntryForm.Show();
            this.Hide();
        }

        private void StudentEntryButton_Click(object sender, EventArgs e)
        {
            StudentEntryForm studentEntryForm = new StudentEntryForm();
            studentEntryForm.Show();
            this.Hide();
        }

        private void StudentEnrollmentButton_Click(object sender, EventArgs e)
        {
            StudentEnrollmentEntry studentEnroll = new StudentEnrollmentEntry();
            studentEnroll.Show();
            this.Hide();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void MenuForm_Load_1(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}