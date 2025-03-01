using DVLD_UI.Utils;
using System.Windows.Forms;

namespace DVLD_UI.UserControls
{
    public partial class FilterOptionsUC : UserControl
    {
        private DataGridView _GridView = null;
        public FilterOptionsUC()
        {
            InitializeComponent();

        }
        public FilterOptionsUC(DataGridView mainGridView)
        {
            InitializeComponent();
            _GridView = mainGridView;

        }
        private void FilterOptionsUC_Load(object sender, System.EventArgs e)
        {

        }

        private void cmbFilterOptions_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            clsUtils.ApplyFilterOptions(_GridView, txtFilterValue, cmbFilterOptions);

        }

        private void txtFilterValue_TextChanged(object sender, System.EventArgs e)
        {
            clsUtils.ApplyFilterOptions(_GridView, txtFilterValue, cmbFilterOptions);
        }
    }
}
