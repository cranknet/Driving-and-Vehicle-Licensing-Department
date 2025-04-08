using DVLD_Data;
using DVLD_Logic;
using DVLD_UI.UserControls.Cards;
using DVLD_UI.Utils;
using System;
using System.Data;
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
        private AppSettings.MenuItem SelectedMenuItem { get; set; }
        private string SelectedMenuOption { get; set; }
        public void InitializeMenu()
        {
            // Main Menu Buttons
            btnApplications.Tag = AppSettings.MenuItem.Applications;
            btnDrivers.Tag = AppSettings.MenuItem.Drivers;
            btnPeoples.Tag = AppSettings.MenuItem.Peoples;
            btnUsers.Tag = AppSettings.MenuItem.Users;
            Utils.Utils.AttachClickEventsToMainButtons(panelMainMenu.Controls, HandleMainMenuClick);
            // Applications Menu ToolStrips
            applicationTypesToolStripMenuItem.Tag = AppSettings.MenuItem.ApplicationType;
            testTypesToolStripMenuItem.Tag = AppSettings.MenuItem.TestType;
            localLicensesToolStripMenuItem.Tag = AppSettings.MenuItem.LocalDLApplication;
            addLocalLicenseToolStripMenuItem.Tag = AppSettings.MenuItem.AddLDLApplication;
            Utils.Utils.AttachClickEventsToToolStripItems(contextMenuStripApplicationMenu.Items, HandleApplicationMenuClick);
            // Test Type Menu ToolStrips
            editTestTypeToolStripMenuItem.Tag = AppSettings.MenuItem.EditTestType;
            Utils.Utils.AttachClickEventsToToolStripItems(contextMenuStripTestTypes.Items, HandleTestTypeMenuClick);
            // Application Type Menu ToolStrips
            editApplicationTypeToolStripMenuItem.Tag = AppSettings.MenuItem.EditApplicationType;
            Utils.Utils.AttachClickEventsToToolStripItems(contextMenuStripApplicationTypes.Items, HandleApplicationTypeMenuClick);
            // LDL Application Menu ToolStrips
            // Schedule Test Menu ToolStrips
            scheduleVisionTestToolStripMenuItem.Tag = AppSettings.MenuItem.ScheduleVisionTest;
            scheduleWritingTestToolStripMenuItem.Tag = AppSettings.MenuItem.ScheduleWritingTest;
            scheduleDrivingTestToolStripMenuItem.Tag = AppSettings.MenuItem.ScheduleDrivingTest;
            Utils.Utils.AttachClickEventsToToolStripItems(contextMenuStripLDLApplication.Items, HandleLDLApplicationMenuClick);
        }
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
        private void DisplayProfileCard(AppSettings.EnMode enMode, int selectedID, string selectedMenuOption)
        {
            if (string.IsNullOrEmpty(selectedMenuOption) || selectedID < 0) return;
            if (selectedMenuOption.Equals(MainMenuOptions.Peoples))
            {
                PersonProfileCard card = new PersonProfileCard(enMode, selectedID);
                using (FrmHost frmHost = new FrmHost(card))
                {
                    frmHost.FormClosing += (s, e) => RefreshMainGridView();
                    frmHost.ShowDialog();
                }
            }
            else if (selectedMenuOption.Equals(MainMenuOptions.Users) || selectedMenuOption.Equals(MainMenuOptions.UserSettings))
            {
                UserProfileCard card = new UserProfileCard(enMode, selectedID);
                using (FrmHost frmHost = new FrmHost(card))
                {
                    frmHost.FormClosing += (s, e) => RefreshMainGridView();
                    frmHost.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Can't display any profile Card for selected menu option!");
            }
        }
        private void ShowCard(AppSettings.MenuItem options, int selectedID)
        {
            switch (options)
            {
                case AppSettings.MenuItem.ApplicationType:
                    ApplicationTypeCard applicationTypeCard = new ApplicationTypeCard(selectedID);
                    using (FrmHost frmHost = new FrmHost(applicationTypeCard))
                    {
                        frmHost.FormClosing += (s, e) =>
                        {
                            DataCache.Instance.RefreshApplicationTypes();
                            LoadMainGridView(DataCache.Instance.GetApplicationTypes());
                        };
                        frmHost.ShowDialog();
                    }
                    break;
                case AppSettings.MenuItem.TestType:
                    TestTypeCard testTypeCard = new TestTypeCard(selectedID);
                    using (FrmHost frmHost = new FrmHost(testTypeCard))
                    {
                        frmHost.FormClosing += (s, e) =>
                        {
                            DataCache.Instance.RefreshTestTypes();
                            LoadMainGridView(DataCache.Instance.GetTestTypes());
                        };
                        frmHost.ShowDialog();
                    }
                    break;
                case AppSettings.MenuItem.AddLDLApplication:
                    AddLDLApplicationCard addLDLApplicationCard = new AddLDLApplicationCard();
                    using (FrmHost frmHost = new FrmHost(addLDLApplicationCard))
                    {
                        frmHost.FormClosing += (s, e) =>
                        {
                            DataCache.Instance.RefreshLDLApplications();
                            LoadMainGridView(DataCache.Instance.GetLDLApplications());
                            SelectedMenuItem = AppSettings.MenuItem.LocalDLApplication;
                        };
                        frmHost.ShowDialog();
                    }
                    break;
                // Show Test Appointment Card for Each Local DL Application Test Type
                case AppSettings.MenuItem.ScheduleVisionTest:
                    TestAppointmentCard visionTestAppointmentCard = new TestAppointmentCard(selectedID, AppSettings.TestType.Vision);
                    using (FrmHost frmHost = new FrmHost(visionTestAppointmentCard))
                    {
                        frmHost.ShowDialog();
                    }
                    break;
                case AppSettings.MenuItem.ScheduleWritingTest:
                    TestAppointmentCard writingTestAppointmentCard = new TestAppointmentCard(selectedID, AppSettings.TestType.Writing);
                    using (FrmHost frmHost = new FrmHost(writingTestAppointmentCard))
                    {
                        frmHost.ShowDialog();
                    }
                    break;
                case AppSettings.MenuItem.ScheduleDrivingTest:
                    TestAppointmentCard drivingTestAppointmentCard = new TestAppointmentCard(selectedID, AppSettings.TestType.Driving);
                    using (FrmHost frmHost = new FrmHost(drivingTestAppointmentCard))
                    {
                        frmHost.ShowDialog();
                    }
                    break;
                default:
                    break;
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
            DialogResult deleteDialogResult = MessageBox.Show(string.Format(AppSettings.ConfirmDeleteUser, selectedID), AppSettings.DeleteUserDialogTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (deleteDialogResult == DialogResult.Yes && User.DeleteBy(selectedID))
            {
                MessageBox.Show(string.Format(AppSettings.UserDeleteSuccess, selectedID));
                return true;
            }
            else
            {
                MessageBox.Show(string.Format(AppSettings.UserDeleteFailed, selectedID));
                return false;
            }
        }
        private bool DeletePerson(int selectedID)
        {
            DialogResult deleteDialogResult = MessageBox.Show(string.Format(AppSettings.ConfirmDeletePerson, selectedID), AppSettings.DeletePersonDialogTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (deleteDialogResult == DialogResult.Yes && People.DeleteBy(selectedID))
            {
                MessageBox.Show(string.Format(AppSettings.PersonDeleteSuccess, selectedID));
                return true;
            }
            else
            {
                MessageBox.Show(string.Format(AppSettings.PersonDeleteFailed, selectedID));
                return false;
            }
        }
        private void RefreshMainGridView()
        {
            switch (SelectedMenuItem)
            {
                case AppSettings.MenuItem.Peoples:
                    DataCache.Instance.RefreshPersons();
                    LoadMainGridView(DataCache.Instance.GetPersons());
                    break;
                case AppSettings.MenuItem.Users:
                    DataCache.Instance.RefreshUsers();
                    LoadMainGridView(DataCache.Instance.GetUsers());
                    break;
                case AppSettings.MenuItem.UserSettings:
                    DataCache.Instance.RefreshUsers();
                    break;
                default:
                    return;
            }
        }
        private void LoadMainGridView(DataTable dataTable)
        {
            if (dataTable == null) return;
            mainGridView.DataSource = dataTable;
        }
        private void ReLoadFilterOptions()
        {
            Utils.Utils.LoadFilterOptions(mainGridView, filterOptionsUC.cmbFilterOptions);
        }
        private void ClearGridView()
        {
            mainGridView.DataSource = null;
        }
        private void ApplyFilter()
        {
            Utils.Utils.ApplyFilter(mainGridView.DataSource as DataTable, filterOptionsUC.cmbFilterOptions, filterOptionsUC.txtFilterValue);
        }
        private void AssignContextMainMenuGridView()
        {
            mainGridView.ContextMenuStrip = null;
            switch (SelectedMenuItem)
            {
                case AppSettings.MenuItem.Users:
                case AppSettings.MenuItem.Peoples:
                    mainGridView.ContextMenuStrip = contextMenuStripUsersPeoples;
                    break;
                default:
                    mainGridView.ContextMenuStrip = null;
                    break;
            }
        }
        private void AssignContextApplicationsMenuGridView()
        {
            mainGridView.ContextMenuStrip = null;
            switch (SelectedMenuItem)
            {
                case AppSettings.MenuItem.LocalDLApplication:
                    mainGridView.ContextMenuStrip = contextMenuStripLDLApplication;
                    break;
                case AppSettings.MenuItem.ApplicationType:
                    mainGridView.ContextMenuStrip = contextMenuStripApplicationTypes;
                    break;
                case AppSettings.MenuItem.TestType:
                    mainGridView.ContextMenuStrip = contextMenuStripTestTypes;
                    break;
                default:
                    mainGridView.ContextMenuStrip = null;
                    break;
            }
        }
    }
}
