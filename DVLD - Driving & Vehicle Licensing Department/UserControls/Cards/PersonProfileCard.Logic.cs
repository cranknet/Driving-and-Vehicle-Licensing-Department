using DVLD_Logic;
using DVLD_UI.Utils;
using System;
using System.Data;
using System.Windows.Forms;
namespace DVLD_UI.UserControls.Cards
{
    public partial class PersonProfileCard : UserControl
    {
        // Create Action Events
        public event Action PersonChanged;
        public event Func<int, bool> OnPersonDelete;
        public event Action OnShowDetailsFormClose;
        // Create Person
        clsPeople Person = null;
        private void DisplayPersonDetails(int personID)
        {
            bool isAddMode = personID == -1;
            lblPersonID.Text = isAddMode ? string.Empty : $"PERSON ID: {Person.PersonID}";
            txtFirstName.Text = isAddMode ? string.Empty : Person.FirstName;
            txtLastName.Text = isAddMode ? string.Empty : Person.LastName;
            txtNationalNo.Text = isAddMode ? string.Empty : Person.NationalNo;
            dtpBirthDate.Value = isAddMode ? clsUtils.AllowedDate(18) : Person.DateOfBirth;
            cmbGender.SelectedItem = isAddMode ? string.Empty : Person.Gender;
            txtAddress.Text = isAddMode ? string.Empty : Person.Address;
            txtEmail.Text = isAddMode ? string.Empty : Person.Email;
            txtPhone.Text = isAddMode ? string.Empty : Person.Phone;
            cmbCountryList.SelectedValue = isAddMode ? string.Empty : Person.Country;
            pbPersonImage.ImageLocation = isAddMode ? string.Empty : Person.ImagePath;
            if (isAddMode) SetEditMode();
        }
        public void SetEditMode(bool Enabled = true)
        {
            txtFirstName.Enabled = Enabled;
            txtLastName.Enabled = Enabled;
            cmbGender.Enabled = Enabled;
            cmbCountryList.Enabled = Enabled;
            dtpBirthDate.Enabled = Enabled;
            btnChangeImage.Visible = Enabled;
            btnRemoveImage.Visible = Enabled;
            if (Enabled)
            {
                txtFirstName.BorderStyle = BorderStyle.Fixed3D;
                txtLastName.BorderStyle = BorderStyle.Fixed3D;
            }
            else
            {
                txtFirstName.BorderStyle = BorderStyle.None;
                txtLastName.BorderStyle = BorderStyle.None;
            }
            foreach (Control control in grbPersonDetails.Controls)
            {
                if (control is TextBox) control.Enabled = Enabled;
            }
            btnSavePerson.Visible = Enabled;
            btnReset.Visible = Enabled;
        }
        private void LoadCountryList()
        {
            DataTable CountryNames = clsCountry.GetListCountries().DefaultView.ToTable("CountryNames", false, "CountryName");
            string displayValue = "CountryName";
            cmbCountryList.DataSource = CountryNames;
            cmbCountryList.DisplayMember = displayValue;
            cmbCountryList.ValueMember = displayValue;
        }
        private bool ValidateAllFields()
        {
            bool isValid = true;
            if (!clsUtils.IsValidText(txtFirstName.Text))
            {
                errorProvider.SetError(txtFirstName, "FirstName must be letters only!");
                isValid = false;
            }
            else errorProvider.SetError(txtFirstName, "");
            if (!clsUtils.IsValidText(txtLastName.Text))
            {
                errorProvider.SetError(txtLastName, "LastName must be letters only!");
                isValid = false;
            }
            else errorProvider.SetError(txtLastName, "");
            if (!clsUtils.IsValidEmail(txtEmail.Text))
            {
                errorProvider.SetError(txtEmail, "Invalid Email format");
                isValid = false;
            }
            else errorProvider.SetError(txtEmail, "");
            if (!clsUtils.IsValidPhone(txtPhone.Text))
            {
                errorProvider.SetError(txtPhone, "Invalid phone number format");
                isValid = false;
            }
            else errorProvider.SetError(txtPhone, "");
            if (!clsUtils.IsValidDate(dtpBirthDate.Value))
            {
                errorProvider.SetError(dtpBirthDate, "You must be at least 18 years old");
                isValid = false;
            }
            else errorProvider.SetError(dtpBirthDate, "");
            return isValid;
        }
        private bool SavePerson()
        {
            if (!ValidateAllFields()) return false;

            Person.FirstName = txtFirstName.Text.Trim();
            Person.LastName = txtLastName.Text.Trim();
            Person.NationalNo = txtNationalNo.Text.Trim();
            Person.Gender = cmbGender.SelectedItem.ToString();
            Person.DateOfBirth = dtpBirthDate.Value;
            Person.Address = textBoxAddress.Text.Trim();
            Person.Email = textBoxEmail.Text.Trim();
            Person.Phone = textBoxPhone.Text.Trim();
            Person.Country = comboBoxCountryList.SelectedValue.ToString();
            Person.ImagePath = pbPeoplePicture.ImageLocation;

            return Person.Save();
        }
    }
}
