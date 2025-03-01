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
            //while (clsSettings.LoggedUserID == clsSettings.DefaultUserID)
            //{
            //    using (FrmLogin frmLogin = new FrmLogin())
            //    {
            //        frmLogin.ShowDialog();
            //    }
            //}
            clsSettings.LoggedUserID = 1;
            Application.Run(new FrmMain(1));
        }
    }
}
