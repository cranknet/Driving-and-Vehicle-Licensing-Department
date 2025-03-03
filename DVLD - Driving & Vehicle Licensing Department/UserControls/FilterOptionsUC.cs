using System.Windows.Forms;
namespace DVLD_UI.UserControls
{
    public partial class FilterOptionsUC : UserControl
    {
        public FilterOptionsUC()
        {
            InitializeComponent();
        }
        private void cmbFilterOptions_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            // clsUtils.ApplyFilterOptions(_GridView, txtFilterValue, cmbFilterOptions);
        }
        private void txtFilterValue_TextChanged(object sender, System.EventArgs e)
        {
            // clsUtils.ApplyFilterOptions(_GridView, txtFilterValue, cmbFilterOptions);
        }
    }
}
