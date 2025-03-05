using DVLD_Logic;
using DVLD_UI.Utils;
using System;
using System.Windows.Forms;

namespace DVLD_UI.UserControls.Cards
{
    public partial class PersonSelectCard : UserControl
    {
        public Action<int> OnPersonIDSelected;
        clsPeople SelectedPerson { get; set; }
        private int selectedPersonID { get; set; }
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
            selectedPersonID = Convert.ToInt32(selectPersonCardGridView.CurrentRow.Cells["PersonID"]?.Value ?? -1);
            SelectedPerson = clsPeople.FindByPersonID(selectedPersonID);
            pbPersonImage.ImageLocation = (SelectedPerson != null) ? SelectedPerson.ImagePath : string.Empty;
        }

        private void btnUserEditPerson_Click(object sender, EventArgs e)
        {
            PersonProfileCard personProfileCard = new PersonProfileCard(CardUtils.EnDisplayMode.Update, selectedPersonID);
            using (FrmHost frmHost = new FrmHost(personProfileCard))
            {
                frmHost.ShowDialog();
            }
        }

        private void btnSelectPerson_Click(object sender, EventArgs e)
        {
            lblSelectPerson.Text = $"You Selected: {SelectedPerson.FirstName} {SelectedPerson.LastName}";
            OnPersonIDSelected?.Invoke(selectedPersonID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.FindForm()?.Close();
        }
    }
}
