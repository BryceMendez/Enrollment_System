using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enrollment_System
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Create the form and set StartPosition before running
            var mainForm = new StudentEntryForm();
            mainForm.StartPosition = FormStartPosition.CenterScreen;
            Application.Run(mainForm);
        }
    }
}