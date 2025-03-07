using DVLD_UI.Login;
using DVLD_UI.Utils;
using System;
using System.Windows.Forms;
namespace DVLD_UI
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ShowLoginForm();
            Application.Run(new FrmMain(Settings.LoggedUserID));
        }
        private static void ShowLoginForm()
        {
            while (Settings.LoggedUserID == Settings.DefaultUserID)
            {
                using (FrmLogin frmLogin = new FrmLogin())
                {
                    frmLogin.ShowDialog();
                }
            }
        }
    }
}
