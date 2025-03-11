using DVLD_Logic;
using DVLD_UI.Utils;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
namespace DVLD_UI.Login
{
    public partial class FrmLogin : Form
    {
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
                AppSettings.LoggedUserID = User.IsUserExistsByUserNamePassword(username, password);
                if (AppSettings.LoggedUserID != AppSettings.DefaultUserID)
                {
                    isValid = true;
                    ResetFields();
                    HandleRememberMe();
                }
                else
                {
                    isValid = false;
                    ClearFields();
                }
            }
            return isValid;
        }
        private void HandleRememberMe()
        {
            if (chkRemember.Checked)
            {
                if (!File.Exists(AppSettings.LoginSavePath)) SaveLoginInfo();
            }
            else
            {
                DeleteLoginInfo();
            }
        }
        private void SaveLoginInfo()
        {
            string formattedLoginRecord = string.Format(AppSettings.LoginRecord, txtUsername.Text.Trim(), txtPassword.Text);
            try
            {
                File.WriteAllText(AppSettings.LoginSavePath, formattedLoginRecord); // Allow overwriting
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving login info: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadLoginInfo()
        {
            if (File.Exists(AppSettings.LoginSavePath))
            {
                try
                {
                    string[] loginRecord = File.ReadAllText(AppSettings.LoginSavePath).Split(new string[] { "@-@" }, StringSplitOptions.None);
                    if (loginRecord.Length == 2) // Ensure valid format
                    {
                        chkRemember.Checked = true;
                        txtUsername.Text = loginRecord[0];
                        txtPassword.Text = loginRecord[1];
                    }
                    else
                    {
                        MessageBox.Show("Invalid login record format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        DeleteLoginInfo(); // Delete corrupted file
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading login info: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void DeleteLoginInfo()
        {
            try
            {
                if (File.Exists(AppSettings.LoginSavePath))
                {
                    File.Delete(AppSettings.LoginSavePath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting login info: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
