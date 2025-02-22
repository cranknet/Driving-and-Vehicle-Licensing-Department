using DVLD_Logic;
using System.Windows.Forms;
namespace DVLD_UI.UserControls.Cards
{
    public partial class UserProfileCard : UserControl
    {
        clsUser User = null;
        clsPeople Person = null;
        private CardUtils.EnDisplayMode EnMode { get; set; }
        private void InitializeUser(int userID)
        {
            User = (EnMode == CardUtils.EnDisplayMode.Read || EnMode == CardUtils.EnDisplayMode.Update) ? clsUser.Find(userID) : new clsUser();
            Person = clsPeople.FindByPersonID(User.PersonID);
        }
        private void ShowReadMode()
        {
            if (User == null || Person == null) return;
            lblUserID.Text = $"USER ID: {User.UserID}";
            lblFullNameValue.Text = $"{Person.FirstName} {Person.LastName}";
            lblUserNameValue.Text = User.UserName;
            lblPhoneValue.Text = Person.Phone;
            lblEmailValue.Text = Person.Email;
            txtOldPassword.Text = string.Empty;
            txtNewPassword.Text = string.Empty;
            txtConfimPassword.Text = string.Empty;
            // Image does not refresh because its deleted.
            pbPersonImage.ImageLocation = Person.ImagePath;
            btnSave.Text = "SAVE";
            ToggleControlStatus(false);
        }
        private void ShowUpdateMode()
        {
            ShowReadMode();
            ToggleControlStatus();
        }
        private void ShowAddMode()
        {
            ShowReadMode();
            ToggleControlStatus();
            btnSave.Text = "ADD";
        }
        private void Display()
        {
            switch (EnMode)
            {
                case CardUtils.EnDisplayMode.Read:
                    ShowReadMode();
                    break;
                case CardUtils.EnDisplayMode.Update:
                    ShowUpdateMode();
                    break;
                case CardUtils.EnDisplayMode.Add:
                    ShowAddMode();
                    break;
            }
        }
        public void ToggleControlStatus(bool enabled = true)
        {
            grpUserPassword.Enabled = enabled;
            btnSave.Visible = enabled;
            btnReset.Visible = enabled;
            btnUserEditPerson.Visible = enabled;
        }
        private bool ValidateField(TextBox textBox, string emptyMsg, int minLength = 0, string minLengthMsg = "")
        {
            if (string.IsNullOrEmpty(textBox.Text))
            {
                errorProvider.SetError(textBox, emptyMsg);
                return false;
            }
            if (minLength > 0 && textBox.Text.Length < minLength)
            {
                errorProvider.SetError(textBox, minLengthMsg);
                return false;
            }
            errorProvider.SetError(textBox, "");
            return true;
        }
        private bool ValidatePasswordMatch(TextBox newPassword, TextBox confirmPassword, string mismatchMsg)
        {
            if (newPassword.Text != confirmPassword.Text)
            {
                errorProvider.SetError(confirmPassword, mismatchMsg);
                return false;
            }
            errorProvider.SetError(confirmPassword, "");
            return true;
        }
        private bool ValidatePasswordFields()
        {
            bool isValid = true;
            isValid &= ValidateField(txtOldPassword, "Old Password must not be empty");
            isValid &= ValidateField(txtNewPassword, "New Password must not be empty!", 6, "New password must be at least 6 characters!");
            isValid &= ValidateField(txtConfimPassword, "Confirm Password must not be empty!");
            isValid &= ValidatePasswordMatch(txtNewPassword, txtConfimPassword, "Passwords do not match!");
            return isValid;
        }

        private bool SaveUser()
        {
            if (!ValidatePasswordFields()) return false;
            User.Password = txtOldPassword.Text;
            User.NewPassword = txtNewPassword.Text;
            return User.Save();
        }
    }
}
