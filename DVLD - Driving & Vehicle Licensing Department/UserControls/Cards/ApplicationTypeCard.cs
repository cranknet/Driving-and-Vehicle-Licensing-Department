using DVLD_Logic;
using System.Windows.Forms;
namespace DVLD_UI.UserControls.Cards
{
    public partial class ApplicationTypeCard : UserControl
    {
        public ApplicationTypeCard(CardUtils.EnDisplayMode enMode, int applicationTypeID)
        {
            InitializeComponent();
            EnMode = enMode;
            applicationType = (EnMode == CardUtils.EnDisplayMode.Update) ? ApplicationType.Find(applicationTypeID) : null;
        }
        private void pbCloseCard_Click(object sender, System.EventArgs e)
        {
            this.FindForm().Close();
        }
        private void ApplicationTypeCard_Load(object sender, System.EventArgs e)
        {
            Display();
        }
        private void btnSave_Click(object sender, System.EventArgs e)
        {
            if (SaveApplicationType())
            {
                btnSave.Enabled = false;
            }
        }
        private void txtTitle_TextChanged(object sender, System.EventArgs e)
        {
            btnSave.Enabled = (txtTitle.Text == applicationType.Title) ? false : true;
        }
        private void txtFee_TextChanged(object sender, System.EventArgs e)
        {
            // I will edit this later to add same value check
            btnSave.Enabled = true;
        }
    }
}
