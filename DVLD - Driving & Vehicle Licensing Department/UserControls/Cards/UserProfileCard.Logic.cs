using DVLD_Logic;
using System.Linq;
using System.Windows.Forms;
namespace DVLD_UI.UserControls.Cards
{
    public partial class UserProfileCard : UserControl
    {
        User User = null;
        People Person = null;
        private CardUtils.EnDisplayMode EnMode { get; set; }
        private void InitializeUser(int userID)
        {
            User = (EnMode == CardUtils.EnDisplayMode.Read || EnMode == CardUtils.EnDisplayMode.Update) ? User.Find(userID) : new User();
            Person = People.FindByPersonID(User.PersonID);
        }
        private void LoadUserInfo()
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
            pbPersonImage.ImageLocation = Person.ImagePath;
        }
        private void ShowUserDetailsPage()
        {
            tabControlUser.TabPages.Clear();
            tabControlUser.TabPages.Add(tabPageUserDetails);
            LoadUserInfo();
        }
        private void ShowUserSettingsPage()
        {
            tabControlUser.TabPages.Clear();
            tabControlUser.TabPages.Add(tabPageUserSettings);
            LoadUserInfo();
            ToggleUserButtons(true);
        }
        private void ShowUserAddPage()
        {
            tabControlUser.TabPages.Clear();
            tabControlUser.TabPages.Add(tabPageUserAdd);
            ToggleUserButtons(true);
            ToggleAddUserTextBoxes(false);
            btnUserEditPerson.Text = "ADD PERSON";
        }
        private void Display()
        {
            switch (EnMode)
            {
                case CardUtils.EnDisplayMode.Read:
                    ShowUserDetailsPage();
                    break;
                case CardUtils.EnDisplayMode.Update:
                    ShowUserSettingsPage();
                    break;
                case CardUtils.EnDisplayMode.Add:
                    ShowUserAddPage();
                    break;
            }
        }
        public void ToggleUserButtons(bool enabled = true)
        {
            btnSave.Visible = enabled;
            btnReset.Visible = enabled;
            btnUserEditPerson.Visible = enabled;
            btnPersonSelect.Visible = enabled;
        }
        public void ToggleAddUserTextBoxes(bool enabled = true)
        {
            foreach (TextBox textBox in tabPageUserAdd.Controls.OfType<TextBox>())
            {
                textBox.Enabled = enabled;
            }
        }

        private bool ValidatePasswordFields()
        {
            bool isValid = true;
            isValid &= Utils.Utils.ValidateField(txtOldPassword, "Old Password must not be empty!", errorProvider, 6, "password must be at least 6 characters!");
            isValid &= Utils.Utils.ValidateField(txtNewPassword, "New Password must not be empty!", errorProvider, 6, "New password must be at least 6 characters!");
            isValid &= Utils.Utils.ValidateField(txtConfimPassword, "Confirm Password must not be empty!", errorProvider, 6, "New password must be at least 6 characters!");
            isValid &= Utils.Utils.ValidatePasswordMatch(txtNewPassword, txtConfimPassword, "Passwords do not match!", errorProvider);
            return isValid;
        }
        private bool ValidateAddUser()
        {
            bool isValid = true;
            isValid &= Utils.Utils.ValidateField(txtNewUserName, "User Name must not be empty!", errorProvider);
            isValid &= Utils.Utils.ValidateField(txtNewUserPassword, "User Name must not be empty!", errorProvider, 6, "Password must be at least 6 characters!");
            return isValid;
        }
        private bool SaveUser()
        {
            if (EnMode == CardUtils.EnDisplayMode.Update)
            {
                if (!ValidatePasswordFields()) return false;
                User.Password = txtOldPassword.Text;
                User.NewPassword = txtNewPassword.Text;
            }
            else if (EnMode == CardUtils.EnDisplayMode.Add)
            {
                if (!ValidateAddUser()) return false;
                User.PersonID = Person.PersonID;
                User.UserName = txtNewUserName.Text;
                User.Password = txtNewUserPassword.Text;
                User.IsActive = ckbNewUserIsActive.Checked;
            }
            return User.Save();
        }
    }
}
