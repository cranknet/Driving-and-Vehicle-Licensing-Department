using System;
using System.Windows.Forms;
namespace DVLD_UI
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        private void LoadUserControl(Panel panel, UserControl userControl)
        {
            panel.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            panel.Controls.Add(userControl);
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
        }
        private void pbExitApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnApplications_Click(object sender, EventArgs e)
        {
            LoadUserControl(panelMain, new UserControls.ApplicationsControl());
        }

        private void btnDrivers_Click(object sender, EventArgs e)
        {
            LoadUserControl(panelMain, new UserControls.DriversControl());
        }

        private void btnPeoples_Click(object sender, EventArgs e)
        {
            LoadUserControl(panelMain, new UserControls.PeoplesControl());
            LoadUserControl(panelSubItems, new UserControls.SubItems.PeoplesSubItemsControl());
        }


    }
}
