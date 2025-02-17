using DVLD_Logic;
using DVLD_UI.Utils;
using System;
using System.Windows.Forms;
namespace DVLD_UI.UserControls.Cards
{
    public partial class PersonProfileCard : UserControl
    {
        public PersonProfileCard(int personID)
        {
            InitializeComponent();
            if (personID == -1)
            {
                Person = new clsPeople();
            }
            else
            {
                Person = clsPeople.FindByPersonID(personID);
            }
            LoadCountryList();
            DisplayPersonDetails(personID);
        }
        private void btnEditPerson_Click(object sender, System.EventArgs e)
        {
            SetEditMode();
        }
        private void btnChangeImage_Click(object sender, System.EventArgs e)
        {
            if (Person != null)
            {
                clsUtils.DeleteImage(Person.ImagePath);
                Person.ImagePath = clsUtils.ImageHandler(pbPersonImage, "Images");
            }
        }
        private void btnReset_Click(object sender, System.EventArgs e)
        {
            if (Person == null)
            {
                DisplayPersonDetails(-1);
            }
            else
            {
                DisplayPersonDetails(Person.PersonID);
            }
        }
        private void btnSavePerson_Click(object sender, System.EventArgs e)
        {
            if (ValidateAllFields())
            {
                Person.FirstName = txtFirstName.Text.Trim();
                Person.LastName = txtLastName.Text.Trim();
                Person.NationalNo = txtNationalNo.Text.Trim();
                Person.Gender = cmbGender.SelectedItem.ToString();
                Person.DateOfBirth = dtpBirthDate.Value;
                Person.Address = txtAddress.Text.Trim();
                Person.Email = txtEmail.Text.Trim();
                Person.Phone = txtPhone.Text.Trim();
                Person.Country = cmbCountryList.SelectedValue.ToString();
                Person.ImagePath = pbPersonImage.ImageLocation;
                if (Person.Save())
                {
                    // Fire PersonChanged Event
                    PersonChanged?.Invoke();
                }
            }
            return;
        }
        private void textBoxNationalNo_Leave(object sender, System.EventArgs e)
        {
            string nationalNoEntered = txtNationalNo.Text.Trim();
            if (clsPeople.IsPersonExistsByNationalNo(nationalNoEntered) && nationalNoEntered != Person.NationalNo)
            {
                errorProvider.SetError(txtNationalNo, "National number already exists!");
                btnSavePerson.Enabled = false;
            }
            else
            {
                errorProvider.SetError(txtNationalNo, "");
                btnSavePerson.Enabled = true;
            }
        }
        private void btnDeletePerson_Click(object sender, EventArgs e)
        {
            if (Person != null)
            {
                if (OnPersonDelete != null)
                {
                    bool deletionResult = OnPersonDelete.Invoke(Person.PersonID);
                    if (deletionResult)
                    {
                        SetEditMode(false);
                        btnEditPerson.Enabled = false;
                        btnDeletePerson.Enabled = false;
                        PersonChanged?.Invoke();
                        Person = null;
                        OnShowDetailsFormClose?.Invoke();
                        return;
                    }
                }
            }
        }
        private void pbCloseCard_Click(object sender, EventArgs e)
        {
            OnShowDetailsFormClose?.Invoke();
        }
        private void btnRemoveImage_Click(object sender, EventArgs e)
        {
            pbPersonImage.Image = (Person.Gender == "Male") ? Properties.Resources.Body : Properties.Resources.Girl;
            Person.ImagePath = null;
        }
    }
}
