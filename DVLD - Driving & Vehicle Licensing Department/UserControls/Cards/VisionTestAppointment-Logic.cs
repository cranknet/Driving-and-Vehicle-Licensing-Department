using DVLD_Logic;
using System.Windows.Forms;

namespace DVLD_UI.UserControls.Cards
{
    public partial class VisionTestAppointment : UserControl
    {
        private LDLApplication _LocalDLApplication;
        private clsApplication _Application;
        private LicenseClass _LicenseClass;
        private People _Person;
        private User _User;
        private ApplicationType _ApplicationType;
        //private TestAppointment _TestAppointment;
        private readonly TestType _VisionTest = TestType.Find(1);
        private void InitializeValues(int ldlAppID)
        {
            _LocalDLApplication = LDLApplication.Find(ldlAppID);
            if (_LocalDLApplication != null)
            {
                _Application = clsApplication.Find(_LocalDLApplication.ApplicationID);
                _ApplicationType = ApplicationType.Find(_Application.ApplicationTypeID);
                _LicenseClass = LicenseClass.Find(_LocalDLApplication.LicenseClassID);
                _Person = People.FindByPersonID(_Application.ApplicantPersonID);
                _User = User.Find(_Application.CreatedByUserID);
            }
            // GroupBoxLDLApplicationInfo Values
            LabelLDLAppIDValue.Text = _LocalDLApplication.LDLApplicationID.ToString();
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
            AppointmentsGridView.DataSource = TestAppointment.GetTestAppointments(1, _LocalDLApplication.LDLApplicationID);
        }
    }
}
