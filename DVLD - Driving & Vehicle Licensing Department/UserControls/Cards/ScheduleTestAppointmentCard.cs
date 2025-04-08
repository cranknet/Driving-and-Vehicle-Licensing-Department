using DVLD_Logic;
using DVLD_UI.Utils;
using System.Windows.Forms;

namespace DVLD_UI.UserControls.Cards
{
    public partial class ScheduleTestAppointmentCard : UserControl
    {
        public ScheduleTestAppointmentCard(int lDLAppID, AppSettings.TestType testType, int testAppointmentID = -1)
        {
            InitializeComponent();
            _TestAppointment = testAppointmentID == -1 ? new TestAppointment() : TestAppointment.Find(testAppointmentID);
            _LocalDLApplication = LDLApplication.Find(lDLAppID);
            _TestType = TestType.Find((int)testType);
            InitializeValues(lDLAppID, testType);
        }
        private void PictureBoxClose_Click(object sender, System.EventArgs e)
        {
            this.FindForm().Close();
        }

        private void ButtonSave_Click(object sender, System.EventArgs e)
        {
            if (Save()) MessageBox.Show(AppSettings.TestAppointmentScheduledSuccessfully);
        }
    }
}
