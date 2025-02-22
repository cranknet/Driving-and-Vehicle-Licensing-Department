using System.Windows.Forms;

namespace DVLD_UI
{
    public partial class FrmPersonProfileCardHost : Form
    {
        public FrmPersonProfileCardHost(UserControl personProfileCard)
        {
            InitializeComponent();
            this.Controls.Add(personProfileCard);
            personProfileCard.Dock = DockStyle.Fill;
        }
    }
}
