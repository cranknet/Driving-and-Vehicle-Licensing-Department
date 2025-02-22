using System.Windows.Forms;

namespace DVLD_UI
{
    public partial class FrmHost : Form
    {
        public FrmHost(UserControl personProfileCard)
        {
            InitializeComponent();
            this.Controls.Add(personProfileCard);
            personProfileCard.Dock = DockStyle.Fill;
        }
    }
}
