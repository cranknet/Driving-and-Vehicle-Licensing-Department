using DVLD_Data;
using DVLD_Logic;
using DVLD_UI.Utils;
using System;
using System.Windows.Forms;
using Application = System.Windows.Forms.Application;
namespace DVLD_UI
{
    public partial class FrmMain : Form
    {
        public FrmMain(int loggedUserID)
        {
            InitializeComponent();
            CurrentUser = User.Find(loggedUserID);
            filterOptionsUC.txtFilterValue.TextChanged += (s, e) => ApplyFilter();
            filterOptionsUC.cmbFilterOptions.SelectedIndexChanged += (s, e) => ApplyFilter();
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            InitializeMenu();
            Utils.Utils.AdjustGridViewColumns(mainGridView);
        }
        private void toolStripMenuPeopleCardShow_Click(object sender, EventArgs e)
        {
            DisplayProfileCard(AppSettings.EnMode.Read, SelectedID, SelectedMenuOption);
        }
        private void toolStripMenuPeopleDelete_Click(object sender, EventArgs e)
        {
            if (DeleteDialog(SelectedID))
            {
                RefreshMainGridView();
            }
        }
        private void pbUserPicture_Click(object sender, EventArgs e)
        {
            SelectedMenuOption = MainMenuOptions.UserSettings;
            contextMenuUserOptions.Show(pbUserPicture, 0, pbUserPicture.Height);
        }
        private void userInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayProfileCard(AppSettings.EnMode.Read, AppSettings.LoggedUserID, SelectedMenuOption);
        }
        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayProfileCard(AppSettings.EnMode.Update, AppSettings.LoggedUserID, SelectedMenuOption);
        }
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AppSettings.LoggedUserID = AppSettings.DefaultUserID;
            CurrentUser = null;
            this.Close();
        }
        private void pbCloseCard_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void iconButtonAdd_Click(object sender, EventArgs e)
        {
            DisplayProfileCard(AppSettings.EnMode.Add, SelectedID, SelectedMenuOption);
        }
        private void mainGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (mainGridView.Columns.Contains(AppSettings.UserIDColumnName))
            {
                SelectedID = Utils.Utils.GetIDFrom(AppSettings.UserIDColumnName, mainGridView);
            }
            else if (mainGridView.Columns.Contains(AppSettings.PersonIDColumnName))
            {
                SelectedID = Utils.Utils.GetIDFrom(AppSettings.PersonIDColumnName, mainGridView);
            }
            else if (mainGridView.Columns.Contains(AppSettings.ApplicationTypeIDColumnName))
            {
                SelectedID = Utils.Utils.GetIDFrom(AppSettings.ApplicationTypeIDColumnName, mainGridView);
            }
            else if (mainGridView.Columns.Contains(AppSettings.TestITypeDColumnName))
            {
                SelectedID = Utils.Utils.GetIDFrom(AppSettings.TestITypeDColumnName, mainGridView);
            }
            else if (mainGridView.Columns.Contains(AppSettings.LDLApplicationIDColumnName))
            {
                SelectedID = Utils.Utils.GetIDFrom(AppSettings.LDLApplicationIDColumnName, mainGridView);
            }
            else
            {
                SelectedID = -1;
            }
        }
        private void editPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayProfileCard(AppSettings.EnMode.Update, SelectedID, SelectedMenuOption);
        }
        private void editUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayProfileCard(AppSettings.EnMode.Update, SelectedID, SelectedMenuOption);
        }
        private void contextMenuStripMainDataView_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            editUserToolStripMenuItem.Visible = SelectedMenuItem == AppSettings.MenuItem.Users;
            editPersonToolStripMenuItem.Visible = SelectedMenuItem == AppSettings.MenuItem.Peoples;
        }
        private void btnApplications_MouseHover(object sender, EventArgs e)
        {
            contextMenuStripApplicationMenu.Show(btnApplications, 0, btnApplications.Height);
        }
        private void HandleMainMenuClick(object sender, EventArgs e)
        {
            if (sender is Button btnMenu && btnMenu.Tag is AppSettings.MenuItem menuItem)
            {
                SelectedMenuItem = menuItem;
                HighlightButton(btnMenu);
                iconButtonAdd.Enabled = true;
                AssignContextMainMenuGridView();
                ClearGridView();
                HandleSelectedMenuItem(menuItem);
            }
        }
        private void HandleApplicationMenuClick(object sender, EventArgs e)
        {
            if (sender is ToolStripMenuItem toolStripMenuItem && toolStripMenuItem.Tag is AppSettings.MenuItem applicationMenu)
            {
                SelectedMenuItem = applicationMenu;
                iconButtonAdd.Enabled = false;
                AssignContextApplicationsMenuGridView();
                ClearGridView();
                HandleSelectedMenuItem(applicationMenu);
            }
        }
        private void HandleApplicationTypeMenuClick(object sender, EventArgs e)
        {
            if (sender is ToolStripMenuItem toolStripMenuItem && toolStripMenuItem.Tag is AppSettings.MenuItem applicationTypeMenu)
            {
                SelectedMenuItem = applicationTypeMenu;
                iconButtonAdd.Enabled = false;
                HandleSelectedMenuItem(applicationTypeMenu);
            }
        }
        private void HandleTestTypeMenuClick(object sender, EventArgs e)
        {
            if (sender is ToolStripMenuItem toolStripMenuItem && toolStripMenuItem.Tag is AppSettings.MenuItem testTypeMenu)
            {
                SelectedMenuItem = testTypeMenu;
                iconButtonAdd.Enabled = false;
                HandleSelectedMenuItem(testTypeMenu);
            }
        }
        private void HandleLDLApplicationMenuClick(object sender, EventArgs e)
        {
            if (sender is ToolStripMenuItem toolStripMenuItem && toolStripMenuItem.Tag is AppSettings.MenuItem ldlApplicationMenu)
            {
                SelectedMenuItem = ldlApplicationMenu;
                iconButtonAdd.Enabled = false;
                HandleSelectedMenuItem(ldlApplicationMenu);
            }
        }
        // Handle Menu Items Click
        private void HandleSelectedMenuItem(AppSettings.MenuItem menuItem)
        {
            switch (menuItem)
            {
                // Main menu items
                case AppSettings.MenuItem.Drivers:
                    DataCache.Instance.RefreshDrivers();
                    LoadMainGridView(DataCache.Instance.GetDrivers());
                    ReLoadFilterOptions();
                    break;
                case AppSettings.MenuItem.Peoples:
                    DataCache.Instance.RefreshPersons();
                    LoadMainGridView(DataCache.Instance.GetPersons());
                    ReLoadFilterOptions();
                    break;
                case AppSettings.MenuItem.Users:
                    DataCache.Instance.RefreshUsers();
                    LoadMainGridView(DataCache.Instance.GetUsers());
                    ReLoadFilterOptions();
                    break;
                // Application sub-menu

                case AppSettings.MenuItem.ApplicationType:
                    DataCache.Instance.RefreshApplicationTypes();
                    LoadMainGridView(DataCache.Instance.GetApplicationTypes());
                    ReLoadFilterOptions();
                    break;
                case AppSettings.MenuItem.TestType:
                    DataCache.Instance.RefreshTestTypes();
                    LoadMainGridView(DataCache.Instance.GetTestTypes());
                    ReLoadFilterOptions();
                    break;
                case AppSettings.MenuItem.LocalDLApplication:
                    DataCache.Instance.RefreshLDLApplications();
                    LoadMainGridView(DataCache.Instance.GetLDLApplications());
                    ReLoadFilterOptions();
                    break;
                case AppSettings.MenuItem.AddLDLApplication:
                    ShowCard(AppSettings.MenuItem.AddLDLApplication, SelectedID);
                    DataCache.Instance.RefreshLDLApplications();
                    break;
                case AppSettings.MenuItem.AddInternationalDLApplication:
                    throw new NotImplementedException();
                case AppSettings.MenuItem.EditTestType:
                    ShowCard(AppSettings.MenuItem.TestType, SelectedID);
                    break;
                case AppSettings.MenuItem.EditApplicationType:
                    ShowCard(AppSettings.MenuItem.ApplicationType, SelectedID);
                    break;
                // LDL Application Schedule Tests
                case AppSettings.MenuItem.ScheduleVisionTest:
                    ShowCard(AppSettings.MenuItem.ScheduleVisionTest, SelectedID);
                    break;
                case AppSettings.MenuItem.ScheduleWritingTest:
                    ShowCard(AppSettings.MenuItem.ScheduleWritingTest, SelectedID);
                    break;
                case AppSettings.MenuItem.ScheduleDrivingTest:
                    ShowCard(AppSettings.MenuItem.ScheduleDrivingTest, SelectedID);
                    break;
                default:
                    break;
            }
        }
    }
}
