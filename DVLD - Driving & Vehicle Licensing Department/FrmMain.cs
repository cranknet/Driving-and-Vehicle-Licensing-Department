using DVLD_Logic;
using DVLD_UI.UserControls.Cards;
using DVLD_UI.Utils;
using System;
using System.Windows.Forms;
namespace DVLD_UI
{
    public partial class FrmMain : Form
    {
        public FrmMain(int loggedUserID)
        {
            InitializeComponent();
            HighlightMenuButtons(panelMainMenu);
            CurrentUser = clsUser.Find(loggedUserID);
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
            clsUtils.LoadFilterOptions(mainGridView, filterOptionsUC.cmbFilterOptions);
        }
        // Users Button Click Event
        private void btnUsers_Click(object sender, EventArgs e)
        {
            LoadMainGridView(EnMainMenuOptions.enUsers, mainGridView);
            clsUtils.LoadFilterOptions(mainGridView, filterOptionsUC.cmbFilterOptions);
        }
        private void mainGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DisplayProfileCard(CardUtils.EnDisplayMode.Read, SelectedID, SelectedMenuOption);
        }
        private void toolStripMenuPeopleCardShow_Click(object sender, EventArgs e)
        {
            DisplayProfileCard(CardUtils.EnDisplayMode.Read, SelectedID, SelectedMenuOption);
        }
        private void toolStripMenuIPeopleEdit_Click(object sender, EventArgs e)
        {
            DisplayProfileCard(CardUtils.EnDisplayMode.Update, SelectedID, SelectedMenuOption);
        }
        private void toolStripMenuPeopleDelete_Click(object sender, EventArgs e)
        {
            if (DeleteDialog(SelectedID))
            {
                LoadMainGridView(EnMainMenuOptions.enPeoples, mainGridView);
            }
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            clsUtils.AdjustGridViewColumns(mainGridView);
        }
        private void pbUserPicture_Click(object sender, EventArgs e)
        {
            SelectedMenuOption = MainMenuOptions.UserSettings;
            contextMenuUserOptions.Show(pbUserPicture, 0, pbUserPicture.Height);
        }
        private void userInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayProfileCard(CardUtils.EnDisplayMode.Read, clsSettings.LoggedUserID, SelectedMenuOption);
        }
        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayProfileCard(CardUtils.EnDisplayMode.Update, clsSettings.LoggedUserID, SelectedMenuOption);
        }
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsSettings.LoggedUserID = clsSettings.DefaultUserID;
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
            if (mainGridView.Columns.Contains(clsSettings.UserIDCellName))
            {
                SelectedID = clsUtils.GetIDFrom(clsSettings.UserIDCellName, mainGridView);
            }
            else
            {
                SelectedID = clsUtils.GetIDFrom(clsSettings.PersonIDCellName, mainGridView);
            }
        }
    }
}
