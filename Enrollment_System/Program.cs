using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enrollment_System
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var mainForm = new StudentEntryForm();
            mainForm.StartPosition = FormStartPosition.CenterScreen;
            Application.Run(mainForm);
        }
    }
}