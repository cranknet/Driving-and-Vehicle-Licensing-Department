using DVLD_UI.UserControls.Cards;
using System;
using System.Windows.Forms;
namespace DVLD_UI
{
    public partial class FrmMain : Form
    {
        public FrmMain(int loggedUserID)
        {
            InitializeCurrentUser(loggedUserID);
            InitializeComponent();
            LoggedUserID = loggedUserID;
            HighlightMenuButtons(this);
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
                DeleteViewRow(mainGridView, CurrentRowIndex);
            }
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

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }


    }
}
