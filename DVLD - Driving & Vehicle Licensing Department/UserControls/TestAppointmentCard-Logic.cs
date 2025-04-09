using DVLD_Logic;
using DVLD_UI.Utils;
using System.Windows.Forms;
namespace DVLD_UI.UserControls.Cards
{
    public partial class TestAppointmentCard : UserControl
    {
        private LDLApplication _LocalDLApplication;
        private clsApplication _Application;
        private LicenseClass _LicenseClass;
        private People _Person;
        private User _User;
        private ApplicationType _ApplicationType;
        private TestType _TestType;
        private TestAppointment _TestAppointment;
        public int SelectedTestAppointmentID { get; private set; }
        public int TestTypeID { get; private set; }
        public int LDLAppID { get; private set; }

        private void InitializeValues(int ldlAppID, AppSettings.TestType testType)
        {

            // Change UserControl Title based on Test Type
            LabelTestType.Text = string.Format(AppSettings.TestAppointmentTypeTitle, _TestType.Title);

            // GroupBoxLDLApplicationInfo Values
            LabelLDLAppIDValue.Text = LDLAppID.ToString();
            LabelAppliedLicenseValue.Text = _LicenseClass.LicenseClassName.ToString();
            // GroupBoxApplicationInfo Values
            LabelApplicationIDValue.Text = _Application.ApplicationID.ToString();
            LabelStatusValue.Text = _Application.ApplicationStatus.ToString();
            LabelFeesValue.Text = _Application.PaidFees.ToString();
            LabelTypeValue.Text = _ApplicationType.Title;
            LabelApplicantValue.Text = _Person.FirstName + " " + _Person.LastName;
            LabelDateValue.Text = _Application.ApplicationDate.ToShortDateString();
            LabelStatusDateValue.Text = _Application.LastStatusDate.ToShortDateString();
            LabelCreatedByValue.Text = _User.UserName;
            // Load Test Appointments
            LoadTestAppointments(testType, ldlAppID);
        }
        // LoadTestAppointments Loads TestAppointments DataTable to AppointmentsGridView.
        private void LoadTestAppointments(AppSettings.TestType testType, int lDLAppID)
        {
            AppointmentsGridView.DataSource = TestAppointment.GetTestAppointments((int)testType, lDLAppID);
        }
    }
}
