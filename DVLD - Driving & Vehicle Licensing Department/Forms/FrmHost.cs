using System.Windows.Forms;
namespace DVLD_UI
{
    public partial class FrmHost : Form
    {
        public FrmHost(UserControl userControlCard)
        {
            InitializeComponent();
            this.Controls.Add(userControlCard);
            userControlCard.Dock = DockStyle.Fill;
        }
    }
}
