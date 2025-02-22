using DVLD_Logic;
using DVLD_UI.Utils;
using System;
using System.Drawing;
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
        }
        private void lblExit_Click(object sender, EventArgs e)
        {
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
        private void ResetFields()
        {
            errorProviderLogin.Clear();
            panelUsernameSeperator.BackColor = Color.FromArgb(41, 128, 185);
            panelPasswordSeperator.BackColor = Color.FromArgb(41, 128, 185);
        }
        private void ClearFields()
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtUsername.Focus();
        }
        private bool ValidateLogin(string username, string password)
        {
            bool isValid = true;
            if (string.IsNullOrWhiteSpace(username) || username.Length < 4)
            {
                errorProviderLogin.SetError(txtUsername, "Invalid Username: Minimum 4 characters.");
                panelUsernameSeperator.BackColor = Color.DarkRed;
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(password) || password.Length < 4)
            {
                errorProviderLogin.SetError(txtPassword, "Invalid Password: Minimum 4 characters.");
                panelPasswordSeperator.BackColor = Color.DarkRed;
                isValid = false;
            }
            else
            {
                clsSettings.LoggedUserID = clsUser.IsUserExistsByUserNamePassword(username, password);
                if (clsSettings.LoggedUserID != clsSettings.DefaultUserID)
                {
                    isValid = true;
                    ResetFields();
                }
                else
                {
                    isValid = false;
                    ClearFields();
                }
            }
            return isValid;
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
