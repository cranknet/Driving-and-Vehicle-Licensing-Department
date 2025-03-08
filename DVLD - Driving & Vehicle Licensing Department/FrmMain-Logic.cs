using DVLD_Data;
using DVLD_Logic;
using DVLD_UI.UserControls.Cards;
using DVLD_UI.Utils;
using System;
using System.Linq;
using System.Windows.Forms;
namespace DVLD_UI
{
    public partial class FrmMain : Form
    {
        private static class MainMenuOptions
        {
            public const string Applications = "APPLICATIONS";
            public const string Drivers = "DRIVERS";
            public const string Peoples = "PEOPLES";
            public const string Users = "USERS";
            public const string UserSettings = "USERSETTINGS";
        }
        private User CurrentUser = null;
        private Button HighlightedButton;
        public int SelectedID;
        private string SelectedMenuOption { get; set; }
        private void HighlightButton(Button button)
        {
            if (HighlightedButton != null)
            {
                HighlightedButton.FlatAppearance.BorderSize = 0;
            }
            HighlightedButton = button;
            HighlightedButton.FlatAppearance.BorderSize = 2;
            HighlightedButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(31, 95, 137);
            SelectedMenuOption = button.Text;
        }
        private void HighlightMenuButtons(Panel currentForm)
        {
            foreach (Button button in currentForm.Controls.OfType<Button>())
            {
                button.Click += (s, e) => HighlightButton((Button)s);
            }
        }
        private void DisplayProfileCard(CardUtils.EnDisplayMode enMode, int selectedID, string selectedMenuOption)
        {
            if (string.IsNullOrEmpty(selectedMenuOption) || selectedID < 0) return;
            if (selectedMenuOption.Equals(MainMenuOptions.Peoples))
            {
                PersonProfileCard card = new PersonProfileCard(enMode, selectedID);
                using (FrmHost frmHost = new FrmHost(card))
                {
                    frmHost.FormClosing += RefreshMainGridViewOnFromClosing;
                    frmHost.ShowDialog();
                }
            }
            else if (selectedMenuOption.Equals(MainMenuOptions.Users) || selectedMenuOption.Equals(MainMenuOptions.UserSettings))
            {
                UserProfileCard card = new UserProfileCard(enMode, selectedID);
                using (FrmHost frmHost = new FrmHost(card))
                {
                    frmHost.FormClosing += RefreshMainGridViewOnFromClosing;
                    frmHost.ShowDialog();
                }
            }
            else if (selectedMenuOption.Equals(MainMenuOptions.Applications))
            {
                ApplicationTypeCard card = new ApplicationTypeCard(enMode, selectedID);
                using (FrmHost frmHost = new FrmHost(card))
                {
                    frmHost.FormClosing += RefreshMainGridViewOnFromClosing;
                    frmHost.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Can't display profile card for selected menu option!");
            }
        }
        private bool DeleteDialog(int selectedID)
        {
            switch (SelectedMenuOption)
            {
                case MainMenuOptions.Peoples:
                    return DeletePerson(selectedID);
                case MainMenuOptions.Users:
                    return DeleteUser(selectedID);
                case MainMenuOptions.Applications:
                    return DeleteApplication(selectedID);
                default:
                    return false;
            }
        }
        private bool DeleteApplication(int selectedID)
        {
            throw new NotImplementedException();
        }
        private bool DeleteUser(int selectedID)
        {
            DialogResult deleteDialogResult = MessageBox.Show(string.Format(Settings.ConfirmDeleteUser, selectedID), Settings.DeleteUserDialogTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (deleteDialogResult == DialogResult.Yes && User.DeleteBy(selectedID))
            {
                MessageBox.Show(string.Format(Settings.UserDeleteSuccess, selectedID));
                return true;
            }
            else
            {
                MessageBox.Show(string.Format(Settings.UserDeleteFailed, selectedID));
                return false;
            }
        }
        private bool DeletePerson(int selectedID)
        {
            DialogResult deleteDialogResult = MessageBox.Show(string.Format(Settings.ConfirmDeletePerson, selectedID), Settings.DeletePersonDialogTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (deleteDialogResult == DialogResult.Yes && People.DeleteBy(selectedID))
            {
                MessageBox.Show(string.Format(Settings.PersonDeleteSuccess, selectedID));
                return true;
            }
            else
            {
                MessageBox.Show(string.Format(Settings.PersonDeleteFailed, selectedID));
                return false;
            }
        }
        private void RefreshMainGridView()
        {
            if (SelectedMenuOption.Equals(MainMenuOptions.Peoples))
            {
                DataCache.Instance.RefreshPersons();
                mainGridView.DataSource = DataCache.Instance.GetPersons();
            }
            else if (SelectedMenuOption.Equals(MainMenuOptions.Users) || SelectedMenuOption.Equals(MainMenuOptions.UserSettings))
            {
                DataCache.Instance.RefreshUsers();
                mainGridView.DataSource = DataCache.Instance.GetUsers();
            }
            else if (SelectedMenuOption.Equals(MainMenuOptions.Applications))
            {
                DataCache.Instance.RefreshApplicationTypes();
                mainGridView.DataSource = DataCache.Instance.GetApplicationTypes();
            }
        }
        private void RefreshMainGridViewOnFromClosing(object sender, FormClosingEventArgs e)
        {
            RefreshMainGridView();
        }
    }
}
