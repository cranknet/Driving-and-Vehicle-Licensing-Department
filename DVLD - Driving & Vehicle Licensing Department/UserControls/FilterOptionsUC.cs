using System.Data;
using System.Windows.Forms;

namespace DVLD_UI.UserControls
{
    public partial class FilterOptionsUC : UserControl
    {
        public FilterOptionsUC()
        {
            InitializeComponent();
        }
        private void ApplyFilterOptions(DataGridView dataGridViewPeople)
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
