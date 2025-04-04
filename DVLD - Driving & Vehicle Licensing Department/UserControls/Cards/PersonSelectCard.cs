﻿using DVLD_Logic;
using DVLD_UI.Utils;
using System;
using System.Data;
using System.Windows.Forms;
namespace DVLD_UI.UserControls.Cards
{
    public partial class PersonSelectCard : UserControl
    {
        public Action<int> OnPersonIDSelected;
        People SelectedPerson { get; set; }
        private int selectedPersonID { get; set; }
        public PersonSelectCard(object personDataSource)
        {
            InitializeComponent();
            selectPersonCardGridView.DataSource = personDataSource;
            filterOptionsUC.txtFilterValue.TextChanged += (s, e) => ApplyFilter();
            filterOptionsUC.cmbFilterOptions.SelectedIndexChanged += (s, e) => ApplyFilter();
            Utils.Utils.LoadFilterOptions(selectPersonCardGridView, filterOptionsUC.cmbFilterOptions);
        }
        private void ApplyFilter()
        {
            Utils.Utils.ApplyFilter(selectPersonCardGridView.DataSource as DataTable, filterOptionsUC.cmbFilterOptions, filterOptionsUC.txtFilterValue);
        }
        private void pbCloseCard_Click(object sender, System.EventArgs e)
        {
            this.FindForm()?.Close();
        }
        private void selectPersonCardGridView_SelectionChanged(object sender, System.EventArgs e)
        {
            selectedPersonID = Convert.ToInt32(selectPersonCardGridView.CurrentRow?.Cells["PersonID"]?.Value ?? -1);
            SelectedPerson = People.FindByPersonID(selectedPersonID);
            pbPersonImage.ImageLocation = (SelectedPerson != null) ? SelectedPerson.ImagePath : string.Empty;
        }
        private void btnUserEditPerson_Click(object sender, EventArgs e)
        {
            PersonProfileCard personProfileCard = new PersonProfileCard(AppSettings.EnMode.Update, selectedPersonID);
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
