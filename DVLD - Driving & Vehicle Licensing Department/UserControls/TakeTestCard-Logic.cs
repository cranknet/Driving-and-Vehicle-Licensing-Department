using DVLD_Logic;
using DVLD_UI.Utils;
using System.Windows.Forms;

namespace DVLD_UI.UserControls
{
    public partial class TakeTestCard : UserControl
    {
        Test _Test;
        TestType _TestType;
        TestAppointment _Appointment;
        private void InitializeValues(int lDlAppID, int appointmentID, AppSettings.TestType testType)
        {
            GroupBoxTestTypeValue.Text = _TestType.Title;
            LabelApplicationIDValue.Text = lDlAppID.ToString();
            LabelScheduledTestDateValue.Text = _Appointment.AppointmentDate.ToString();
            LabelTestFeesValue.Text = _Appointment.PaidFees.ToString();
        }
        private bool Save()
        {
            _Test.TestAppointmentID = _Appointment.TestAppointmentID;
            _Test.TestResult = RadioButtonPass.Checked;
            _Test.Notes = TextBoxNotesValue.Text;
            _Test.CreatedByUserID = AppSettings.LoggedUserID;
            return _Test.Save();
        }
    }
}
