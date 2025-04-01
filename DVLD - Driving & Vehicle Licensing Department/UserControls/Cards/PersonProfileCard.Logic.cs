using DVLD_Logic;
using DVLD_UI.Utils;
using System.Windows.Forms;
namespace DVLD_UI.UserControls.Cards
{
    public partial class PersonProfileCard : UserControl
    {
        People Person = null;
        private AppSettings.EnMode EnMode { get; set; }
        private void InitializePerson(int personID)
        {
            Person = (EnMode == AppSettings.EnMode.Read || EnMode == AppSettings.EnMode.Update) ? People.FindByPersonID(personID) : new People();
        }
        private void ShowReadMode()
        {
            // Fix Reset Empty Mode
            if (Person == null) return;
            lblPersonID.Text = (Person.PersonID == -1) ? "ADD NEW PERSON" : $"PERSON ID: {Person.PersonID}";
            txtFirstName.Text = Person.FirstName;
            txtLastName.Text = Person.LastName;
            txtNationalNo.Text = Person.NationalNo;
            dtpBirthDate.Value = (Person.PersonID == -1) ? Utils.Utils.AllowedDate(18) : Person.DateOfBirth;
            cmbGender.SelectedItem = Person.Gender;
            txtAddress.Text = Person.Address;
            txtEmail.Text = Person.Email;
            txtPhone.Text = Person.Phone;
            cmbCountryList.SelectedValue = Person.CountryID;
            pbPersonImage.ImageLocation = Person.ImagePath;
            btnSavePerson.Text = (Person.PersonID == -1) ? "ADD NEW" : "SAVE";
        }
        private void ShowUpdateMode()
        {
            ShowReadMode();
            ToggleControlStatus();
        }
        private void ShowAddMode()
        {
            ShowReadMode();
            ToggleControlStatus();
            dtpBirthDate.MaxDate = Utils.Utils.AllowedDate(18);
            pbPersonImage.Image = Properties.Resources.Body;
        }
        private void Display()
        {
            switch (EnMode)
            {
                case AppSettings.EnMode.Read:
                    ShowReadMode();
                    break;
                case AppSettings.EnMode.Update:
                    ShowUpdateMode();
                    break;
                case AppSettings.EnMode.Add:
                    ShowAddMode();
                    break;
            }
        }
        private void ToggleControlStatus(bool enabled = true)
        {
            txtFirstName.Enabled = enabled;
            txtLastName.Enabled = enabled;
            cmbGender.Enabled = enabled;
            cmbCountryList.Enabled = enabled;
            dtpBirthDate.Enabled = enabled;
            btnChangeImage.Visible = enabled;
            btnRemoveImage.Visible = enabled;
            if (enabled)
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
                if (control is TextBox) control.Enabled = enabled;
            }
            btnSavePerson.Visible = enabled;
            btnReset.Visible = enabled;
        }
        private bool ValidateAllFields()
        {
            bool isValid = true;
            if (!Utils.Utils.IsValidText(txtFirstName.Text))
            {
                errorProvider.SetError(txtFirstName, "FirstName must be letters only!");
                isValid = false;
            }
            else errorProvider.SetError(txtFirstName, "");
            if (!Utils.Utils.IsValidText(txtLastName.Text))
            {
                errorProvider.SetError(txtLastName, "LastName must be letters only!");
                isValid = false;
            }
            else errorProvider.SetError(txtLastName, "");
            if (!Utils.Utils.IsValidEmail(txtEmail.Text))
            {
                errorProvider.SetError(txtEmail, "Invalid Email format");
                isValid = false;
            }
            else errorProvider.SetError(txtEmail, "");
            if (!Utils.Utils.IsValidPhone(txtPhone.Text))
            {
                errorProvider.SetError(txtPhone, "Invalid phone number format");
                isValid = false;
            }
            else errorProvider.SetError(txtPhone, "");
            if (!Utils.Utils.IsValidDate(dtpBirthDate.Value))
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
            Person.Address = txtAddress.Text.Trim();
            Person.Email = txtEmail.Text.Trim();
            Person.Phone = txtPhone.Text.Trim();
            Person.CountryName = cmbCountryList.SelectedText;
            Person.CountryID = (int)cmbCountryList.SelectedValue;
            Person.ImagePath = pbPersonImage.ImageLocation;
            return Person.Save();
        }
    }
}
