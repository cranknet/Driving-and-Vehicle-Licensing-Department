using System;
using System.Windows.Forms;
namespace DVLD_UI
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static int LoggedUserID = -1;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Login.FrmLogin frmLogin = new Login.FrmLogin();
            Application.Run(new FrmMain(15));
            if (LoggedUserID != -1)
            {
                Application.Run(new FrmMain(LoggedUserID));
            }
        }
    }
}
