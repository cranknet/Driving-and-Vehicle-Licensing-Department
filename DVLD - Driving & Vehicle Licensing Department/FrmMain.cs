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
        public FrmMain(int loggedUserID)
        {
            InitializeComponent();
            HighlightMenuButtons(panelMainMenu);
            CurrentUser = User.Find(loggedUserID);
            filterOptionsUC.txtFilterValue.TextChanged += (s, e) => ApplyFilter();
            filterOptionsUC.cmbFilterOptions.SelectedIndexChanged += (s, e) => ApplyFilter();
        }
        private void ApplyFilter()
        {
            Utils.Utils.ApplyFilter(mainGridView.DataSource as DataTable, filterOptionsUC.cmbFilterOptions, filterOptionsUC.txtFilterValue);
        }
        private void btnApplications_Click(object sender, EventArgs e)
        {
            LoadApplicationTypes();
        }
        private void btnDrivers_Click(object sender, EventArgs e)
        {
            iconButtonAdd.Enabled = true;
        }
        private void btnPeoples_Click(object sender, EventArgs e)
        {
            mainGridView.DataSource = DataCache.Instance.GetPersons();
            Utils.Utils.LoadFilterOptions(mainGridView, filterOptionsUC.cmbFilterOptions);
            iconButtonAdd.Enabled = true;
        }
        private void btnUsers_Click(object sender, EventArgs e)
        {
            mainGridView.DataSource = DataCache.Instance.GetUsers();
            Utils.Utils.LoadFilterOptions(mainGridView, filterOptionsUC.cmbFilterOptions);
            iconButtonAdd.Enabled = true;
        }
        private void mainGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // On Application Menu Show Update Mode instead of Read Mode
            if (SelectedMenuOption.Equals(MainMenuOptions.Applications))
            {
                DisplayProfileCard(CardUtils.EnDisplayMode.Update, SelectedID, SelectedMenuOption);
            }
            else
            {
                DisplayProfileCard(CardUtils.EnDisplayMode.Read, SelectedID, SelectedMenuOption);
            }
        }
        private void toolStripMenuPeopleCardShow_Click(object sender, EventArgs e)
        {
            DisplayProfileCard(CardUtils.EnDisplayMode.Read, SelectedID, SelectedMenuOption);
        }
        private void toolStripMenuIPeopleEdit_Click(object sender, EventArgs e)
        {
        }
        private void toolStripMenuPeopleDelete_Click(object sender, EventArgs e)
        {
            if (DeleteDialog(SelectedID))
            {
                RefreshMainGridView();
            }
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            Utils.Utils.AdjustGridViewColumns(mainGridView);
        }
        private void pbUserPicture_Click(object sender, EventArgs e)
        {
            SelectedMenuOption = MainMenuOptions.UserSettings;
            contextMenuUserOptions.Show(pbUserPicture, 0, pbUserPicture.Height);
        }
        private void userInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayProfileCard(CardUtils.EnDisplayMode.Read, Settings.LoggedUserID, SelectedMenuOption);
        }
        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayProfileCard(CardUtils.EnDisplayMode.Update, Settings.LoggedUserID, SelectedMenuOption);
        }
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings.LoggedUserID = Settings.DefaultUserID;
            CurrentUser = null;
            this.Close();
        }
        private void pbCloseCard_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void iconButtonAdd_Click(object sender, EventArgs e)
        {
            DisplayProfileCard(CardUtils.EnDisplayMode.Add, SelectedID, SelectedMenuOption);
        }
        private void mainGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (mainGridView.Columns.Contains(Settings.UserIDCellName))
            {
                SelectedID = Utils.Utils.GetIDFrom(Settings.UserIDCellName, mainGridView);
            }
            else if (mainGridView.Columns.Contains(Settings.PersonIDCellName))
            {
                SelectedID = Utils.Utils.GetIDFrom(Settings.PersonIDCellName, mainGridView);
            }
            else if (mainGridView.Columns.Contains(Settings.ApplicationTypeIDCellName))
            {
                SelectedID = Utils.Utils.GetIDFrom(Settings.ApplicationTypeIDCellName, mainGridView);
            }
            else if (mainGridView.Columns.Contains(Settings.TestITypeDCellName))
            {
                SelectedID = Utils.Utils.GetIDFrom(Settings.TestITypeDCellName, mainGridView);
            }
            else
            {
                SelectedID = -1;
            }
        }
        private void editPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayProfileCard(CardUtils.EnDisplayMode.Update, SelectedID, SelectedMenuOption);
        }
        private void editUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayProfileCard(CardUtils.EnDisplayMode.Update, SelectedID, SelectedMenuOption);
        }
        private void editApplicationTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            enApplicationSubMenuOption = Settings.EnApplicationSubMenuOptions.enApplicationType;
            DisplayProfileCard(CardUtils.EnDisplayMode.Update, SelectedID, SelectedMenuOption);
        }
        private void editTestTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            enApplicationSubMenuOption = Settings.EnApplicationSubMenuOptions.enTestType;
            DisplayProfileCard(CardUtils.EnDisplayMode.Update, SelectedID, SelectedMenuOption);
        }
        private void contextMenuStripMainDataVeiw_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            toolStripMenuDetails.Visible = !SelectedMenuOption.Equals(MainMenuOptions.Applications);
            toolStripMenuDelete.Visible = !SelectedMenuOption.Equals(MainMenuOptions.Applications);
            toolStripSeparator.Visible = !SelectedMenuOption.Equals(MainMenuOptions.Applications);
            editUserToolStripMenuItem.Visible = SelectedMenuOption.Equals(MainMenuOptions.Users);
            editPersonToolStripMenuItem.Visible = SelectedMenuOption.Equals(MainMenuOptions.Peoples);
            editApplicationTypeToolStripMenuItem.Visible = SelectedMenuOption.Equals(MainMenuOptions.Applications);
            //editApplicationTypeToolStripMenuItem.Visible = (enApplicationSubMenuOption == Settings.EnApplicationSubMenuOptions.enApplicationType);
            //editTestTypeToolStripMenuItem.Visible = (enApplicationSubMenuOption == Settings.EnApplicationSubMenuOptions.enTestType);
        }

        private void btnApplications_MouseHover(object sender, EventArgs e)
        {

            contextMenuStripApplicationMenu.Show(btnApplications, 0, btnApplications.Height);
        }

        private void applicationTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HighlightButton(btnApplications);
            LoadApplicationTypes();
        }

        private void testTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HighlightButton(btnApplications);
            LoadTestTypes();
        }
    }
}
