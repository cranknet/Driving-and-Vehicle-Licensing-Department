using DVLD_UI.Utils;
using System;
using System.Windows.Forms;
namespace DVLD_UI.UserControls
{
    public partial class PeoplesControl : UserControl
    {

        public PeoplesControl()
        {
            InitializeComponent();
        }
        private void dataGridViewPeople_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            // ShowAddPerson(GetPersonIDByIndex(e.RowIndex));
        }
        private void toolStripMenuPeopleCardShow_Click(object sender, EventArgs e)
        {
            //ShowAddPerson(GetPersonIDByIndex(dataGridViewPeople.CurrentCell.RowIndex));
        }
        private void toolStripMenuIPeopleEdit_Click(object sender, EventArgs e)
        {
            //ShowAddPerson(GetPersonIDByIndex(dataGridViewPeople.CurrentCell.RowIndex), true);
        }
        private void toolStripMenuPeopleDelete_Click(object sender, EventArgs e)
        {
        }

        private void PeoplesControl_Load(object sender, EventArgs e)
        {
            LoadPeopleGrid();
            clsUtils.LoadFilterOptions(dataGridViewPeople, cmbFilterOptions);
        }

        private void cmbFilterOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilterOptions();
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            ApplyFilterOptions();
        }
    }
}
