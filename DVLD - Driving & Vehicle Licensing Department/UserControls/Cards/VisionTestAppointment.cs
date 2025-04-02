using DVLD_UI.Utils;
using System.Windows.Forms;
namespace DVLD_UI.UserControls.Cards
{
    public partial class VisionTestAppointment : UserControl
    {
        public VisionTestAppointment(int ldlAppID)
        {
            InitializeComponent();
            InitializeValues(ldlAppID);
        }
        private void pbCloseCard_Click(object sender, System.EventArgs e)
        {
            this.FindForm().Close();
        }

        private void ButtonShowPersonInfo_Click(object sender, System.EventArgs e)
        {
            PersonProfileCard personProfileCard = new PersonProfileCard(AppSettings.EnMode.Read, _Person.PersonID);
            using (FrmHost frmHost = new FrmHost(personProfileCard))
            {
                frmHost.ShowDialog();
            }
        }
    }
}
