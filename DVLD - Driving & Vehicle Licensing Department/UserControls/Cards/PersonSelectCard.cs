using DVLD_Logic;
using DVLD_UI.Utils;
using System;
using System.Windows.Forms;

namespace DVLD_UI.UserControls.Cards
{
    public partial class PersonSelectCard : UserControl
    {
        private int _selectedPersonID { get; set; }
        public PersonSelectCard()
        {
            InitializeComponent();
            LoadGridView();
            clsUtils.LoadFilterOptions(selectPersonCardGridView, filterOptionsUC.cmbFilterOptions);
        }
        private void LoadGridView()
        {
            selectPersonCardGridView.DataSource = clsPeople.GetNonUserPeople();
        }

        private void pbCloseCard_Click(object sender, System.EventArgs e)
        {
            this.FindForm()?.Close();

        }

        private void selectPersonCardGridView_SelectionChanged(object sender, System.EventArgs e)
        {
            _selectedPersonID = Convert.ToInt32(selectPersonCardGridView.CurrentRow.Cells["PersonID"]?.Value ?? -1);
            clsPeople person = clsPeople.FindByPersonID(_selectedPersonID);
            pbPersonImage.ImageLocation = (person != null) ? person.ImagePath : string.Empty;
        }

        private void btnUserEditPerson_Click(object sender, EventArgs e)
        {
            PersonProfileCard personProfileCard = new PersonProfileCard(CardUtils.EnDisplayMode.Update, _selectedPersonID);
            using (FrmHost frmHost = new FrmHost(personProfileCard))
            {
                //frmHost.FormClosing += FrmHost_FormClosing;
                frmHost.ShowDialog();
            }
        }
    }
}
