using System;
using System.Windows.Forms;

namespace Vault
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
            new Config().CreateDatabase();
            new frmInicio().ShowDialog();

            

        }
    }
}
