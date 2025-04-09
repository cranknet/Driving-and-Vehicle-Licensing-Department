using DVLD_Logic;
using DVLD_UI.Utils;
using System.Windows.Forms;

namespace DVLD_UI.UserControls
{
    public partial class TakeTestCard : UserControl
    {
        public TakeTestCard(int lDlAppID, int appointmentID, AppSettings.TestType testType)
        {
            InitializeComponent();
            _Test = new Test();
            _TestType = TestType.Find((int)testType);
            _Appointment = TestAppointment.Find(appointmentID);
            InitializeValues(lDlAppID, appointmentID, testType);
        }

        private void PictureBoxClose_Click(object sender, System.EventArgs e)
        {
            this.FindForm().Close();
        }

        private void ButtonClose_Click(object sender, System.EventArgs e)
        {
            this.FindForm().Close();
        }

        private void ButtonSave_Click(object sender, System.EventArgs e)
        {
            if (Save() && _Appointment.Lock())
            {
                MessageBox.Show(AppSettings.TakeTestSuccessUpdate);
                ButtonClose_Click(sender, e);
            }
        }
    }
}
