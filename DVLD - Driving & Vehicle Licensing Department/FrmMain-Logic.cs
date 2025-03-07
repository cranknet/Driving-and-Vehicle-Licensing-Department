using DVLD_Data;
using DVLD_Logic;
using DVLD_UI.UserControls.Cards;
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
        enum EnMainMenuOptions
        {
            enApplications = 0,
            enDrivers = 1,
            enPeoples = 2,
            enUsers = 3
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
            else
            {
                MessageBox.Show("Can't display profile card for selected menu option!");
            }
        }
        private bool DeleteDialog(int personID)
        {
            string deletionMessage = $"Are you sure you want to delete!\nPerson with selectedID {personID}";
            DialogResult deleteDialogResult = MessageBox.Show(deletionMessage, "Confirm Person Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (deleteDialogResult == DialogResult.Yes && People.DeleteBy(personID))
            {
                MessageBox.Show($"Person with selectedID: {personID} deleted successfully");
                return true;
            }
            else
            {
                MessageBox.Show($"Couldn't delete Person with selectedID: {personID}!");
                return false;
            }
        }
        private void RefreshMainGridViewOnFromClosing(object sender, FormClosingEventArgs e)
        {
            if (SelectedMenuOption.Equals(MainMenuOptions.Peoples))
            {
                //LoadMainGridView(EnMainMenuOptions.enPeoples, mainGridView);
                DataCache.Instance.RefreshPersons();
                mainGridView.DataSource = DataCache.Instance.GetPersons();
            }
            else if (SelectedMenuOption.Equals(MainMenuOptions.Users) || SelectedMenuOption.Equals(MainMenuOptions.UserSettings))
            {
                //LoadMainGridView(EnMainMenuOptions.enUsers, mainGridView);
                DataCache.Instance.RefreshUsers();
                mainGridView.DataSource = DataCache.Instance.GetUsers();
            }
        }
    }
}
