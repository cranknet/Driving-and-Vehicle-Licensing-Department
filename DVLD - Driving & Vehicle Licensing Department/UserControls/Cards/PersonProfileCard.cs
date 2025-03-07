using DVLD_Logic;
using DVLD_UI.Utils;
using System;
using System.Data;
using System.Windows.Forms;
namespace DVLD_UI.UserControls.Cards
{
    public partial class PersonProfileCard : UserControl
    {
        public PersonProfileCard(CardUtils.EnDisplayMode enMode, int personID)
        {
            InitializeComponent();
            EnMode = enMode;
            InitializePerson(personID);
            Utils.Utils.LoadCountryList(cmbCountryList, new DataTable());
        }
        private void PersonProfileCard_Load(object sender, EventArgs e)
        {
            Display();
        }
        private void btnChangeImage_Click(object sender, System.EventArgs e)
        {
            if (Person != null)
            {
                Utils.Utils.DeleteImage(Person.ImagePath);
            }
            Person.ImagePath = Utils.Utils.ImageHandler(pbPersonImage, "Images");
        }
        private void btnReset_Click(object sender, System.EventArgs e)
        {
            ShowReadMode();
        }
        private void btnSavePerson_Click(object sender, System.EventArgs e)
        {
            if (SavePerson())
            {
                MessageBox.Show("Person saved successfully");
            }
            else
            {
                MessageBox.Show("Can't save Person");
            }
        }
        private void textBoxNationalNo_Leave(object sender, System.EventArgs e)
        {
            string nationalNoEntered = txtNationalNo.Text.Trim();
            if (People.IsPersonExistsByNationalNo(nationalNoEntered) && nationalNoEntered != Person.NationalNo)
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
        private void pbCloseCard_Click(object sender, EventArgs e)
        {
            this.FindForm()?.Close();
        }
        private void btnRemoveImage_Click(object sender, EventArgs e)
        {
            pbPersonImage.Image = (Person.Gender == "Male") ? Properties.Resources.Body : Properties.Resources.Girl;
        }
    }
}
