using DVLD_Logic;
using System;
using System.Data;
using System.Windows.Forms;
namespace DVLD_UI.UserControls
{
    public partial class PeoplesControl : UserControl
    {

        private void LoadPeopleGrid()
        {
            dataGridViewPeople.DataSource = new DataView(DVLD_Logic.clsPeople.GetAllPeople());
            dataGridViewPeople.Columns["PersonID"].Width = 80;
            dataGridViewPeople.Columns["NationalNo"].Width = 140;
            dataGridViewPeople.Columns["FirstName"].Width = 120;
            dataGridViewPeople.Columns["LastName"].Width = 120;
            dataGridViewPeople.Columns["Age"].Width = 50;
            dataGridViewPeople.Columns["Gender"].Width = 80;
            dataGridViewPeople.Columns["Phone"].Width = 120;
        }
        private void ReloadPeopleGridDate()
        {
            dataGridViewPeople.DataSource = new DataView(DVLD_Logic.clsPeople.GetAllPeople());
        }
        private int GetPersonIDByIndex(int rowIndex)
        {
            if (rowIndex < 0)
            {
                MessageBox.Show("Please select a person first.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return -1;
            }
            return Convert.ToInt32(dataGridViewPeople.Rows[rowIndex].Cells["PersonID"].Value);
        }
        
        //private void ShowAddPerson(int personID, bool enableEditMode = false)
        //{
        //    FrmShowDetails showDetails = new FrmShowDetails();
        //    PersonProfileCard peopleCard = new PersonProfileCard();
        //    showDetails.panelContainer.Controls.Clear();
        //    showDetails.panelContainer.Controls.Add(peopleCard);
        //    if (enableEditMode) peopleCard.ToggleControlStatus();
        //    peopleCard.PersonChanged += ReloadPeopleGridDate;
        //    peopleCard.OnShowDetailsFormClose += () => showDetails.Close();
        //    peopleCard.OnPersonDelete += PromptAndDeletePersonByID;
        //    showDetails.ShowDialog();
        //}
        private void ApplyFilterOptions()
        {
            if (cmbFilterOptions.SelectedItem == null) return;
            string selectedFilterColumn = cmbFilterOptions.SelectedItem.ToString();
            string selectedFilterText = txtFilterValue.Text.Trim().Replace("'", "''");
            if (dataGridViewPeople.DataSource is DataView filteredPeopleView)
            {
                txtFilterValue.Visible = selectedFilterColumn != "None";
                if (selectedFilterColumn == "None")
                {
                    ClearFilter(filteredPeopleView);
                }
                else if (selectedFilterColumn == "Age" || selectedFilterColumn == "PersonID")
                {
                    ApplyNumericFilter(filteredPeopleView, selectedFilterColumn, selectedFilterText);
                }
                else
                {
                    filteredPeopleView.RowFilter = $"{selectedFilterColumn} LIKE '%{selectedFilterText}%'";
                }
                dataGridViewPeople.Refresh();
            }
        }
        private void ClearFilter(DataView filteredPeopleView)
        {
            txtFilterValue.Clear();
            filteredPeopleView.RowFilter = "";
        }
        private void ApplyNumericFilter(DataView filteredPeopleView, string columnName, string filterText)
        {
            if (int.TryParse(filterText, out int filterNumber))
            {
                filteredPeopleView.RowFilter = $"{columnName} = {filterNumber}";
            }
            else
            {
                filteredPeopleView.RowFilter = "";
            }
        }
    }
}
