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
            if (userID < 0) return;
            User = (EnMode == CardUtils.EnDisplayMode.Read || EnMode == CardUtils.EnDisplayMode.Update) ? clsUser.Find(userID) : new clsUser();
            if (User == null) return;
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
        private bool ValidateAllFields()
        {
            bool isValid = true;
            return isValid;
        }
        private bool SaveUser()
        {
            return true;
        }

    }
}
