using DVLD_Logic;
using System.Windows.Forms;

namespace DVLD_UI.UserControls.Cards
{
    public partial class ScheduleTestAppointmentCard : UserControl
    {
        public ScheduleTestAppointmentCard(int lDLAppID, AppSettings.TestType testType, int applicantID, int testAppointmentID = -1)
        {
            InitializeComponent();
            int lastTestAppointmentID = TestAppointment.GetLastTestAppointmentID((int)testType, lDLAppID, true);
            if (lastTestAppointmentID != -1 && !Test.GetTestResultStatus(lastTestAppointmentID))
            {
                _RetakeTest = true;

            }
            _TestAppointment = (testAppointmentID != -1) ? TestAppointment.Find(testAppointmentID) : new TestAppointment();
            _LocalDLApplication = LDLApplication.Find(lDLAppID);
            _TestType = TestType.Find((int)testType);
            _Applicant = People.FindByPersonID(applicantID);
            _LicenseClass = LicenseClass.Find(_LocalDLApplication.LicenseClassID);
            _RetakeTestService = ApplicationType.Find((int)AppSettings.EnApplicationTypes.RetakeTest);
            _RetakeTestApplication = new clsApplication();
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

        private void ButtonClose_Click(object sender, System.EventArgs e)
        {
            this.FindForm().Close();
        }
    }
}
