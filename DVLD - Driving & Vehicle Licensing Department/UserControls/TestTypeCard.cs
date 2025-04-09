using DVLD_Logic;
using System.Windows.Forms;
namespace DVLD_UI.UserControls.Cards
{
    public partial class TestTypeCard : UserControl
    {
        public TestTypeCard(int testTypeID)
        {
            InitializeComponent();
            testType = TestType.Find(testTypeID);
        }
        private void pbCloseCard_Click(object sender, System.EventArgs e)
        {
            this.FindForm().Close();
        }
        private void TestTypeCard_Load(object sender, System.EventArgs e)
        {
            Display();
        }
        private void btnSave_Click(object sender, System.EventArgs e)
        {
            if (SaveTestType())
            {
                btnSave.Enabled = false;
            }
        }
        private void txtTitle_TextChanged(object sender, System.EventArgs e)
        {
            btnSave.Enabled = (txtTitle.Text == testType.Title) ? false : true;
        }
        private void txtFee_TextChanged(object sender, System.EventArgs e)
        {
            btnSave.Enabled = true;
        }
        private void txtDescription_TextChanged(object sender, System.EventArgs e)
        {
            btnSave.Enabled = (txtDescription.Text == testType.Description) ? false : true;
        }
    }
}
