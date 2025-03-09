using DVLD_Logic;
using System.Data;
using System.Windows.Forms;

namespace DVLD_UI.UserControls.Cards
{
    public partial class AddLocalDLApplicationCard : UserControl
    {
        People Person { get; set; }
        public AddLocalDLApplicationCard()
        {
            InitializeComponent();
            Utils.Utils.LoadLicenseClasses(cmbApplicationLicenseClass, new DataTable());
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
            PersonSelectCard personSelectCard = new PersonSelectCard();
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
    }
}
