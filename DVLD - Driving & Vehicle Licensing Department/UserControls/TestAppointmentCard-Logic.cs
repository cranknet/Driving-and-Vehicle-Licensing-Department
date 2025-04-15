using DVLD_Logic;
using System.Windows.Forms;
namespace DVLD_UI.UserControls.Cards
{
    public partial class TestAppointmentCard : UserControl
    {
        private LDLApplication _LocalDLApplication;
        private clsApplication _Application;
        private LicenseClass _LicenseClass;
        private People _Applicant;
        private User _User;
        private ApplicationType _ApplicationType;
        private TestType _TestType;
        public int SelectedTestAppointmentID { get; private set; }
        public int TestTypeID { get; private set; }
        public int LDLAppID { get; private set; }
        public int TestAppointmentID { get; private set; }
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
            LabelApplicantValue.Text = _Applicant.FirstName + " " + _Applicant.LastName;
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
        //private void HandleTestCompletion()
        //{
        //    // Change Application Status to Completed
        //    _Application.LastStatusDate = System.DateTime.Now;
        //    _Application.ApplicationStatus = (int)AppSettings.EnApplicationStatus.Completed;
        //    if (!_Application.Save())
        //    {
        //        MessageBox.Show("Couldn't update Application Status to Compeleted!");
        //    }
        //}
    }
}
