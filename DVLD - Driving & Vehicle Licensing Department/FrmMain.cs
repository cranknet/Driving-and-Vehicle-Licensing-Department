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
        private int LoggedUserID { get; set; }
        private clsUser CurrentUser = null;
        private Button HighlightedButton;
        private int CurrentRowIndex { get; set; }
        private int SelectedID;
        private string SelectedMenuOption { get; set; }
        enum EnMainMenuOptions
        {
            enApplications = 0,
            enDrivers = 1,
            enPeoples = 2,
            enUsers = 3,
            enUserSettings = 4
        }
        public FrmMain(int loggedUserID)
        {
            InitializeCurrentUser(loggedUserID);
            InitializeComponent();
            LoggedUserID = loggedUserID;
            HighlightMenuButtons(panelMenu);
        }
        private void InitializeCurrentUser(int userID)
        {
            if (userID == -1)
            {
                Application.Run(new FrmLogin());
            }
            CurrentUser = clsUser.Find(userID);
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
                case EnMainMenuOptions.enUserSettings:
                    DisplayProfileCard(CardUtils.EnDisplayMode.Update, CurrentUser.PersonID, SelectedMenuOption);
                    SelectedMenuOption = "Home";

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
            SelectedMenuOption = button.Text;
        }
        private void HighlightMenuButtons(Panel panel)
        {
            foreach (Button button in panel.Controls.OfType<Button>())
            {
                button.Click += (s, e) => HighlightButton((Button)s);
            }
        }
        private void pbExitApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnApplications_Click(object sender, EventArgs e)
        {
        }
        private void btnDrivers_Click(object sender, EventArgs e)
        {
        }
        private void btnPeoples_Click(object sender, EventArgs e)
        {
            LoadMainGridView(EnMainMenuOptions.enPeoples, mainGridView);
        }
        // Users Button Click Event
        private void btnUsers_Click(object sender, EventArgs e)
        {
            LoadMainGridView(EnMainMenuOptions.enUsers, mainGridView);

        }
        // User Settings Button Click Event
        private void btnUserSettings_Click(object sender, EventArgs e)
        {
            LoadMainGridView(EnMainMenuOptions.enUserSettings, mainGridView);
        }
        private void mainGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DisplayProfileCard(CardUtils.EnDisplayMode.Read, SelectedID, SelectedMenuOption);
        }
        private int GetIDBy(string cellName, DataGridView mainView, int rowIndex)
        {
            if (rowIndex < 0) return -1;
            if (mainView.Columns.Contains(cellName))
            {
                return Convert.ToInt32(mainView.Rows[rowIndex].Cells[cellName].Value);
            }
            return -1;
        }
        private void DisplayProfileCard(CardUtils.EnDisplayMode enMode, int selectedID, string selectedMenuOption)
        {
            if (string.IsNullOrEmpty(selectedMenuOption)) return;
            if (selectedMenuOption == "PEOPLES")
            {
                PersonProfileCard card = new PersonProfileCard(enMode, selectedID);
                using (FrmPersonProfileCardHost frmHost = new FrmPersonProfileCardHost(card))
                {
                    frmHost.FormClosing += RefreshMainGridViewOnFromClosing;
                    frmHost.ShowDialog();
                }
            }
            else if (selectedMenuOption == "USERS")
            {
                UserProfileCard card = new UserProfileCard(enMode, selectedID);
                using (FrmPersonProfileCardHost frmHost = new FrmPersonProfileCardHost(card))
                {
                    frmHost.FormClosing += RefreshMainGridViewOnFromClosing;
                    frmHost.ShowDialog();
                }
            }

        }
        private void toolStripMenuPeopleCardShow_Click(object sender, EventArgs e)
        {
            DisplayProfileCard(CardUtils.EnDisplayMode.Read, SelectedID, SelectedMenuOption);
        }
        private void toolStripMenuIPeopleEdit_Click(object sender, EventArgs e)
        {
            DisplayProfileCard(CardUtils.EnDisplayMode.Update, SelectedID, SelectedMenuOption);
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
        private void toolStripMenuPeopleDelete_Click(object sender, EventArgs e)
        {
            if (DeleteDialog(SelectedID))
            {
                DeleteViewRow(mainGridView, CurrentRowIndex);
            }
        }
        private void DeleteViewRow(DataGridView dGView, int rowIndex)
        {
            if (dGView == null || rowIndex < 0) return;
            dGView.Rows.RemoveAt(rowIndex);
        }

        private void mainGridView_CurrentCellChanged(object sender, EventArgs e)
        {
            CurrentRowIndex = mainGridView.CurrentRow?.Index ?? -1;
            if (mainGridView.Columns.Contains("UserID"))
            {
                SelectedID = GetIDBy("UserID", mainGridView, CurrentRowIndex);
            }
            else
            {
                SelectedID = GetIDBy("PersonID", mainGridView, CurrentRowIndex);
            }

        }
        private void RefreshMainGridViewOnFromClosing(object sender, FormClosingEventArgs e)
        {
            switch (SelectedMenuOption)
            {
                case "APPLICATIONS":
                    break;
                case "DRIVERS":
                    break;
                case "PEOPLES":
                    mainGridView.DataSource = clsPeople.GetAllPeople();
                    break;
                case "USERS":
                    mainGridView.DataSource = clsUser.GetAllUsers();
                    break;
                case "USER SETTINGS":
                    break;
            }
        }
    }
}
