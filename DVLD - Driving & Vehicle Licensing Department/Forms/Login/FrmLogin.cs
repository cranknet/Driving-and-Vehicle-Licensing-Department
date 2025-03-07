using DVLD_UI.Utils;
using System;
using System.Windows.Forms;
namespace DVLD_UI.Login
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            LoadLoginInfo();
        }
        private void lblExit_Click(object sender, EventArgs e)
        {
            Settings.LoggedUserID = 0;
            Application.Exit();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            btnLogin.Enabled = false;
            try
            {
                ResetFields();
                if (ValidateLogin(txtUsername.Text.Trim(), txtPassword.Text))
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            finally
            {
                btnLogin.Enabled = true;
            }
        }
        private void pbUsername_Click(object sender, EventArgs e)
        {
            txtUsername.Focus();
        }
        private void pbPassword_Click(object sender, EventArgs e)
        {
            txtPassword.Focus();
        }
    }
}
