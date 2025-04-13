using DVLD_Logic;
namespace DVLD_UI.UserControls.Cards
{
    public partial class ScheduleTestAppointmentCard
    {
        TestAppointment _TestAppointment;
        LDLApplication _LocalDLApplication;
        People _Applicant;
        LicenseClass _LicenseClass;
        TestType _TestType;
        ApplicationType _RetakeTestService;
        clsApplication _RetakeTestApplication;
        bool _RetakeTest = false;
        private void InitializeValues(int lDlAppID, AppSettings.TestType testType)
        {
            // Disable RetakeTest Group Box
            GroupBoxRetakeTest.Enabled = _RetakeTest;
            // Label Values
            LabelScheduleTestTitle.Text = string.Format(AppSettings.ScheduleTestTitle, _TestType.Title);
            GroupBoxTestTypeValue.Text = _TestType.Title;
            LabelApplicationIDValue.Text = _LocalDLApplication.ApplicationID.ToString();
            LabelApplicantNameValue.Text = _Applicant.FirstName + " " + _Applicant.LastName;
            LabelLicenseClassValue.Text = _LicenseClass.LicenseClassName;
            LabelTestFeesValue.Text = _TestType.Fees.ToString();
            dateTimePickerScheduleTestDateValue.Value = _TestAppointment?.AppointmentDate ?? System.DateTime.Now;
            // Fix showed fees issue
            if (_RetakeTest)
            {
                LabelRetakeTestApplicationIDValue.Text = _TestAppointment?.RetakeTestApplicationID.ToString() ?? "No ID";
                LabelRetakeTestFeeValue.Text = _RetakeTestService.Fees.ToString();
                LabelTotalFeesValue.Text = (_TestType.Fees + _RetakeTestService.Fees).ToString();
            }
        }
        private bool Save()
        {
            if (_RetakeTest)
            {

                _RetakeTestApplication.ApplicantPersonID = _Applicant.PersonID;
                _RetakeTestApplication.ApplicationDate = dateTimePickerScheduleTestDateValue.Value;
                _RetakeTestApplication.ApplicationTypeID = _RetakeTestService.ID;
                _RetakeTestApplication.ApplicationStatus = (byte)AppSettings.EnApplicationStatus.New;
                _RetakeTestApplication.LastStatusDate = dateTimePickerScheduleTestDateValue.Value;
                _RetakeTestApplication.PaidFees = _TestType.Fees + _RetakeTestService.Fees;
                _RetakeTestApplication.CreatedByUserID = AppSettings.LoggedUserID;
                if (_RetakeTestApplication.Save())
                {
                    _TestAppointment.RetakeTestApplicationID = _RetakeTestApplication.ApplicationID;
                }
                else
                {
                    return false;
                }
            }
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
