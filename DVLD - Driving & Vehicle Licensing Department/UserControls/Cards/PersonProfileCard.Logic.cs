using DVLD_Logic;
using DVLD_UI.Utils;
using System.Windows.Forms;
namespace DVLD_UI.UserControls.Cards
{
    public partial class PersonProfileCard : UserControl
    {
        clsPeople Person = null;
        private CardUtils.EnDisplayMode EnMode { get; set; }
        private void InitializePerson(int personID)
        {
            if (personID < 0) return;
            Person = (EnMode == CardUtils.EnDisplayMode.Read || EnMode == CardUtils.EnDisplayMode.Update) ? clsPeople.FindByPersonID(personID) : new clsPeople();
        }
        private void ShowReadMode()
        {
            if (Person == null) return;
            lblPersonID.Text = $"PERSON ID: {Person.PersonID}";
            txtFirstName.Text = Person.FirstName;
            txtLastName.Text = Person.LastName;
            txtNationalNo.Text = Person.NationalNo;
            dtpBirthDate.Value = Person.DateOfBirth;
            cmbGender.SelectedItem = Person.Gender;
            txtAddress.Text = Person.Address;
            txtEmail.Text = Person.Email;
            txtPhone.Text = Person.Phone;
            cmbCountryList.SelectedValue = Person.CountryID;
            pbPersonImage.ImageLocation = Person.ImagePath;
            btnSavePerson.Text = "SAVE";
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
            dtpBirthDate.MaxDate = clsUtils.AllowedDate(18);
            btnSavePerson.Text = "ADD";
            pbPersonImage.Image = Properties.Resources.Body;
        }
        private void Display()
        {
            switch (EnMode)
            {
                case CardUtils.EnDisplayMode.Read:
                    ShowReadMode();
                    break;
                case CardUtils.EnDisplayMode.Update:
                    ShowUpdateMode();
                    break;
                case CardUtils.EnDisplayMode.Add:
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
