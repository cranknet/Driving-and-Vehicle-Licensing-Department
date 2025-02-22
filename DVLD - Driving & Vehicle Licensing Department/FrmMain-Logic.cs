using DVLD_Logic;
using DVLD_UI.Login;
using DVLD_UI.UserControls.Cards;
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
        }
        enum EnMainMenuOptions
        {
            enApplications = 0,
            enDrivers = 1,
            enPeoples = 2,
            enUsers = 3
        }
        private int LoggedUserID { get; set; }
        private clsUser CurrentUser = null;
        private Button HighlightedButton;
        private int CurrentRowIndex { get; set; }
        private int SelectedID;
        private string SelectedMenuOption { get; set; }
        private void InitializeCurrentUser(int userID)
        {
            if (userID == -1)
            {
                Application.Run(new FrmLogin());
            }
            CurrentUser = clsUser.Find(userID);
        }
        private int GetIDBy(string cellName, DataGridView mainView, int rowIndex)
        {
            if (rowIndex < 0 || mainView == null || !mainView.Columns.Contains(cellName)) return -1;
            return Convert.ToInt32(mainView.Rows[rowIndex].Cells[cellName].Value);
        }
        private void LoadMainGridView(EnMainMenuOptions enMenuOption, DataGridView mainView)
        {
            if (mainView == null) return;
            switch (enMenuOption)
            {
                case EnMainMenuOptions.enApplications:
                    break;
                case EnMainMenuOptions.enDrivers:
                    break;
                case EnMainMenuOptions.enPeoples:
                    mainView.DataSource = clsPeople.GetAllPeople();
                    CustomizePeopleViewColumns(mainView);
                    break;
                case EnMainMenuOptions.enUsers:
                    mainView.DataSource = clsUser.GetAllUsers();
                    break;
            }
        }
        private void CustomizePeopleViewColumns(DataGridView people)
        {
            people.Columns["PersonID"].Width = 80;
            people.Columns["NationalNo"].Width = 140;
            people.Columns["FirstName"].Width = 120;
            people.Columns["LastName"].Width = 120;
            people.Columns["Age"].Width = 50;
            people.Columns["Gender"].Width = 80;
            people.Columns["Phone"].Width = 120;
        }
        private void LoadUserControl(Panel panel, UserControl userControl)
        {
            if (panel == null) return;
            panel.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            panel.Controls.Add(userControl);
        }
        private void HighlightButton(Button button)
        {
            if (HighlightedButton != null)
            {
                HighlightedButton.FlatAppearance.BorderSize = 0;
            }
            HighlightedButton = button;
            HighlightedButton.FlatAppearance.BorderSize = 1;
            HighlightedButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(31, 95, 137);
            SelectedMenuOption = button.Text;
        }
        private void HighlightMenuButtons(Form currentForm)
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
                using (FrmPersonProfileCardHost frmHost = new FrmPersonProfileCardHost(card))
                {
                    frmHost.FormClosing += RefreshMainGridViewOnFromClosing;
                    frmHost.ShowDialog();
                }
            }
            else if (selectedMenuOption.Equals(MainMenuOptions.Users))
            {
                UserProfileCard card = new UserProfileCard(enMode, selectedID);
                using (FrmPersonProfileCardHost frmHost = new FrmPersonProfileCardHost(card))
                {
                    frmHost.FormClosing += RefreshMainGridViewOnFromClosing;
                }
            }
        }
        private bool DeleteDialog(int personID)
        {
            string deletionMessage = $"Are you sure you want to delete!\nPerson with selectedID {personID}";
            DialogResult deleteDialogResult = MessageBox.Show(deletionMessage, "Confirm Person Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (deleteDialogResult == DialogResult.Yes && clsPeople.DeleteBy(personID))
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
        private void DeleteViewRow(DataGridView dGView, int rowIndex)
        {
            if (dGView == null || rowIndex < 0) return;
            dGView.Rows.RemoveAt(rowIndex);
        }
        private void RefreshMainGridViewOnFromClosing(object sender, FormClosingEventArgs e)
        {
            if (SelectedMenuOption.Equals(MainMenuOptions.Peoples))
            {
                LoadMainGridView(EnMainMenuOptions.enPeoples, mainGridView);
            }
            else if (SelectedMenuOption.Equals(MainMenuOptions.Users))
            {
                LoadMainGridView(EnMainMenuOptions.enUsers, mainGridView);
            }
        }
    }
}
