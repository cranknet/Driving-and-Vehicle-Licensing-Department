using System.Windows.Forms;

namespace DVLD_UI.UserControls.Cards
{
    public partial class UserProfileCard : UserControl
    {
        public UserProfileCard(CardUtils.EnDisplayMode enMode, int userID)
        {
            InitializeComponent();
            EnMode = enMode;
            InitializeUser(userID);
        }

        private void UserProfileCard_Load(object sender, System.EventArgs e)
        {
            Display();
        }

        private void pbCloseCard_Click(object sender, System.EventArgs e)
        {
            this.FindForm()?.Close();
        }

        private void btnReset_Click(object sender, System.EventArgs e)
        {
            ShowReadMode();
            ToggleControlStatus(true);
        }

        private void btnUserEditPerson_Click(object sender, System.EventArgs e)
        {

        }
    }
}
