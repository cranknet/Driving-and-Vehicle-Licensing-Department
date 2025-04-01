using DVLD_Data;
using DVLD_Logic;
using DVLD_UI.Utils;
using System;
using System.Data;
using System.Windows.Forms;
namespace DVLD_UI.UserControls.Cards
{
    public partial class AddLDLApplicationCard : UserControl
    {
        clsApplication LocalLicenseApplication;
        People Person { get; set; }
        User CreatedByUser { get; set; }
        ApplicationType LocalLicenseType { get; set; }
        public AddLDLApplicationCard()
        {
            InitializeComponent();
            Utils.Utils.LoadLicenseClasses(cmbApplicationLicenseClass, new DataTable());
            LocalLicenseApplication = new clsApplication();
            LocalLicenseType = ApplicationType.Find(1);
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
            lblApplicationID.Text = $"{LocalLicenseApplication.ApplicationID}";
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
            LocalLicenseApplication.ApplicantPersonID = Person.PersonID;
            LocalLicenseApplication.ApplicationDate = DateTime.Now;
            LocalLicenseApplication.ApplicationTypeID = LocalLicenseType.ID;
            LocalLicenseApplication.ApplicationStatus = 1;
            LocalLicenseApplication.LastStatusDate = DateTime.Now;
            LocalLicenseApplication.PaidFees = LocalLicenseType.Fees;
            LocalLicenseApplication.CreatedByUserID = CreatedByUser.UserID;
            LocalLicenseApplication.LicenseClassID = Convert.ToInt32(cmbApplicationLicenseClass.SelectedValue);
            int existingApplicationID = LocalLicenseApplication.CheckLDLApplicationExists();
            if (existingApplicationID != -1)
            {
                MessageBox.Show(string.Format(AppSettings.ApplicationAlreadyExists, existingApplicationID), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return LocalLicenseApplication.Save();
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
