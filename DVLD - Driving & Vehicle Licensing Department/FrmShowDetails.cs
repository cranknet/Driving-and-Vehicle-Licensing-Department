using System.Windows.Forms;

namespace DVLD_UI
{
    public partial class FrmShowDetails : Form
    {
        public FrmShowDetails()
        {
            InitializeComponent();
        }

        private void FrmShowDetails_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
