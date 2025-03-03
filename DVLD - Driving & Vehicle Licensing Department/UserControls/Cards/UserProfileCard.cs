using DVLD_Logic;
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

        }
        private void btnUserEditPerson_Click(object sender, System.EventArgs e)
        {
            PersonProfileCard personProfileCard = new PersonProfileCard(EnMode, User.PersonID);
            using (FrmHost frmHost = new FrmHost(personProfileCard))
            {
                frmHost.FormClosing += FrmHost_FormClosing;
                frmHost.ShowDialog();
            }
        }

        private void FrmHost_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Reset The User Card Info When The Person Card about to close.
            Person = clsPeople.FindByPersonID(User.PersonID);
            LoadUserInfo();
            btnReset_Click(sender, e);
        }
        private void btnSave_Click(object sender, System.EventArgs e)
        {
            if (SaveUser())
            {
                DialogResult result = MessageBox.Show("User Password updated successfully\nDo you want to close the card?", "User Password Update", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    this.FindForm()?.Close();
                }

            }
            else
            {
                MessageBox.Show("Can't update User password!");
            }
        }
    }
}
