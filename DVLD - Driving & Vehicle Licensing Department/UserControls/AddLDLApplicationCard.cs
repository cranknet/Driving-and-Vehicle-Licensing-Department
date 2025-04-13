using DVLD_Logic;
using DVLD_Logic.Config;
using DVLD_UI.Config;
using System;
using System.Data;
using System.Windows.Forms;
using AppSettings = DVLD_Logic.AppSettings;
namespace DVLD_UI.UserControls.Cards
{
    public partial class AddLDLApplicationCard : UserControl
    {
        clsApplication _LocalDrivingLicenseApplication;
        People Person { get; set; }
        User CreatedByUser { get; set; }
        ApplicationType LocalLicenseType { get; set; }
        LDLApplication _LDLApplication;
        public AddLDLApplicationCard()
        {
            InitializeComponent();
            Utils.LoadLicenseClasses(cmbApplicationLicenseClass, new DataTable());
            _LocalDrivingLicenseApplication = new clsApplication();
            LocalLicenseType = ApplicationType.Find((int)AppSettings.EnApplicationTypes.LocalDrivingLicense);
            CreatedByUser = User.Find(AppSettings.LoggedUserID);
            LoadFieldsValues();
        }
        private void pbCloseCard_Click(object sender, System.EventArgs e)
        {
            this.FindForm()?.Close();
        }
        private void btnClose_Click(object sender, System.EventArgs e)
        {
            this.FindForm()?.Close();
        }
        private void btnSelectPerson_Click(object sender, System.EventArgs e)
        {
            PersonSelectCard personSelectCard = new PersonSelectCard(DataCache.Instance.GetPersons());
            using (FrmHost frmHost = new FrmHost(personSelectCard))
            {
                //frmHost.FormClosing += FrmHost_FormClosing;
                personSelectCard.OnPersonIDSelected += (personID) =>
                {
                    Person = People.FindByPersonID(personID);
                    if (Person == null) return;
                    pbPersonImage.ImageLocation = Person.ImagePath;
                    lblFullName.Text = $"Full Name: {Person.FirstName} {Person.LastName}";
                    grbNewApplicationDetails.Enabled = true;
                };
                frmHost.ShowDialog();
            }
        }
        private void LoadFieldsValues()
        {
            lblApplicationID.Text = $"{_LocalDrivingLicenseApplication.ApplicationID}";
            lblApplicationDate.Text = $"{DateTime.Now.ToShortDateString()}";
            lblApplicationFees.Text = $"{LocalLicenseType?.Fees ?? 0}";
            lblApplicationCreatedByUserID.Text = $"{CreatedByUser?.UserID ?? -1}";
        }
        private bool ValidateFields()
        {
            if (Person == null)
            {
                MessageBox.Show(AppSettings.SelectPersonFirst, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (cmbApplicationLicenseClass.SelectedIndex == -1)
            {
                MessageBox.Show(AppSettings.SelectLicenseClass, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private bool SaveApplication()
        {
            if (!ValidateFields()) return false;
            _LocalDrivingLicenseApplication.ApplicantPersonID = Person.PersonID;
            _LocalDrivingLicenseApplication.ApplicationDate = DateTime.Now;
            _LocalDrivingLicenseApplication.ApplicationTypeID = LocalLicenseType.ID;
            _LocalDrivingLicenseApplication.ApplicationStatus = 1;
            _LocalDrivingLicenseApplication.LastStatusDate = DateTime.Now;
            _LocalDrivingLicenseApplication.PaidFees = LocalLicenseType.Fees;
            _LocalDrivingLicenseApplication.CreatedByUserID = CreatedByUser.UserID;
            int licenseClassID = Convert.ToInt32(cmbApplicationLicenseClass.SelectedValue);
            int existingApplicationID = LDLApplication.CheckLDLApplicationExists(Person.PersonID, licenseClassID, (int)AppSettings.EnApplicationStatus.New);
            if (existingApplicationID != -1)
            {
                MessageBox.Show(string.Format(AppSettings.ApplicationAlreadyExists, existingApplicationID), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (_LocalDrivingLicenseApplication.Mode == AppSettings.EnMode.AddNew)
            {
                if (!_LocalDrivingLicenseApplication.Save())
                    return false;
                _LDLApplication = new LDLApplication
                {
                    ApplicationID = _LocalDrivingLicenseApplication.ApplicationID,
                    LicenseClassID = licenseClassID
                };
                return _LDLApplication.Save();
            }
            return _LocalDrivingLicenseApplication.Save();
        }
        private void btnSaveApplication_Click(object sender, EventArgs e)
        {
            if (SaveApplication())
            {
                MessageBox.Show(AppSettings.LocalDLDAddedSuccess, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.FindForm()?.Close();
            }
            else
            {
                MessageBox.Show(AppSettings.LocalDLDAddedFailed, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
