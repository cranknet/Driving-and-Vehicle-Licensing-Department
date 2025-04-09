using DVLD_Logic;
using DVLD_UI.Utils;
namespace DVLD_UI.UserControls.Cards
{
    public partial class ScheduleTestAppointmentCard
    {
        TestAppointment _TestAppointment;
        LDLApplication _LocalDLApplication;
        TestType _TestType;
        private void InitializeValues(int lDlAppID, AppSettings.TestType testType)
        {
            // Disable RetakeTest Group Box
            GroupBoxRetakeTest.Enabled = false;
            // Label Values
            LabelScheduleTestTitle.Text = string.Format(AppSettings.ScheduleTestTitle, _TestType.Title);
            GroupBoxTestTypeValue.Text = _TestType.Title;
            LabelApplicationIDValue.Text = _LocalDLApplication.ApplicationID.ToString();
            LabelTestFeesValue.Text = _TestType.Fees.ToString();
            dateTimePickerScheduleTestDateValue.Value = _TestAppointment?.AppointmentDate ?? System.DateTime.Now;
        }
        private bool Save()
        {
            if ((_TestAppointment.TestTypeID != -1))
            {
                _TestAppointment.AppointmentDate = dateTimePickerScheduleTestDateValue.Value;
            }
            else
            {
                _TestAppointment.TestTypeID = _TestType.TestTypeID;
                _TestAppointment.LDLAppID = _LocalDLApplication.LDLApplicationID;
                _TestAppointment.AppointmentDate = dateTimePickerScheduleTestDateValue.Value;
                _TestAppointment.PaidFees = _TestType.Fees;
                _TestAppointment.CreatedByUserID = AppSettings.LoggedUserID;
                _TestAppointment.IsLocked = false;
            }
            return _TestAppointment.Save();
        }
    }
}
