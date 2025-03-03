using DVLD_UI.Utils;
using System.Windows.Forms;
namespace DVLD_UI.UserControls
{
    public partial class FilterOptionsUC : UserControl
    {
        DataGridView _GridView;
        DataFilter _DataFilter;
        public FilterOptionsUC()
        {
            InitializeComponent();
        }
        public FilterOptionsUC(DataGridView dataGridView)
        {
            InitializeComponent();
            _GridView = dataGridView;
            _DataFilter = new DataFilter(_GridView, cmbFilterOptions, txtFilterValue);
            _DataFilter.LoadFilterOptions();
        }
        private void cmbFilterOptions_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (_DataFilter != null)
            {
                _DataFilter.Apply();
            }
        }
        private void txtFilterValue_TextChanged(object sender, System.EventArgs e)
        {
            if (_DataFilter != null)
            {
                _DataFilter.Apply();
            }
        }
    }
}
