using DVLD_Logic;
using DVLD_UI.UserControls.Cards;
using System;
using System.Data;
using System.Windows.Forms;
namespace DVLD_UI.UserControls
{
    public partial class PeoplesControl : UserControl
    {
        public PeoplesControl()
        {
            InitializeComponent();
        }
        private void PopulatePeopleDataGridView()
        {
            dataGridViewPeople.DataSource = new DataView(DVLD_Logic.clsPeople.GetAllPeople());
            dataGridViewPeople.Columns["PersonID"].Width = 80;
            dataGridViewPeople.Columns["NationalNo"].Width = 120;
            dataGridViewPeople.Columns["FirstName"].Width = 120;
            dataGridViewPeople.Columns["LastName"].Width = 120;
            dataGridViewPeople.Columns["Age"].Width = 50;
            dataGridViewPeople.Columns["Gender"].Width = 80;
            dataGridViewPeople.Columns["Phone"].Width = 120;

        }

        // Get selected Person ID from the DataGridView List
        private int GetPersonID(int currentIndex)
        {
            int personID = 0;
            try
            {
                if (currentIndex >= 0)
                {
                    personID = Convert.ToInt32(dataGridViewPeople.Rows[currentIndex].Cells["PersonID"].Value);
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Index out Of range: Try to Select Person first.");
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Index out Of range: Try to Select Person first");
            }
            return personID;
        }
        private void ShowPeopleCardUserControl(int personID, bool EnableEditMode = false)
        {
            if (personID == 0) return;
            FrmShowDetails showDetails = new FrmShowDetails();
            PersonProfileCard peopleCard = new PersonProfileCard(-1);
            showDetails.panelContainer.Controls.Clear();
            showDetails.panelContainer.Controls.Add(peopleCard);
            if (EnableEditMode) peopleCard.SetEditMode();
            peopleCard.PersonChanged += PeopleCard_PersonSaved;
            peopleCard.OnShowDetailsFormClose += () => showDetails.Close();
            peopleCard.OnPersonDelete += DeletePersonByID;
            showDetails.ShowDialog();
        }
        private bool DeletePersonByID(int personID)
        {
            string deletionMessage = $"Are you sure you want to delete!\nPerson with ID {personID}";
            DialogResult deleteDialogResult = MessageBox.Show(deletionMessage, "Confirm Person Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (deleteDialogResult == DialogResult.Yes)
            {
                if (clsPeople.DeleteByID(personID))
                {
                    MessageBox.Show($"Person with ID: {personID} deleted successfully");
                    return true;
                }
                else
                {
                    MessageBox.Show($"Couldn't delete Person with ID: {personID}!");
                    return false;
                }
            }
            return false;
        }
        private void PeopleCard_PersonSaved()
        {
            PopulatePeopleDataGridView();
        }
        private void PeoplesControl_Load(object sender, System.EventArgs e)
        {
            PopulatePeopleDataGridView();
        }
        private void dataGridViewPeople_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowPeopleCardUserControl(GetPersonID(e.RowIndex));
        }
        private void toolStripMenuPeopleCardShow_Click(object sender, EventArgs e)
        {
            ShowPeopleCardUserControl(GetPersonID(dataGridViewPeople.CurrentCell.RowIndex));
        }
        private void toolStripMenuIPeopleEdit_Click(object sender, EventArgs e)
        {
            ShowPeopleCardUserControl(GetPersonID(dataGridViewPeople.CurrentCell.RowIndex), true);
        }
        private void toolStripMenuPeopleDelete_Click(object sender, EventArgs e)
        {
            DeletePersonByID(GetPersonID(dataGridViewPeople.CurrentCell.RowIndex));
        }
    }
}
