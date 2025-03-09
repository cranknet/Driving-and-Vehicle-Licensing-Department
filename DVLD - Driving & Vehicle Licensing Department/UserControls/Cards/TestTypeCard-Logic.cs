using DVLD_Logic;
using System.Windows.Forms;
namespace DVLD_UI.UserControls.Cards
{
    public partial class TestTypeCard : UserControl
    {
        TestType testType = null;
        CardUtils.EnDisplayMode EnMode { get; set; }
        private void Display()
        {
            switch (EnMode)
            {
                case CardUtils.EnDisplayMode.Read:
                    break;
                case CardUtils.EnDisplayMode.Update:
                    ShowTestTypeUpdate();
                    break;
                case CardUtils.EnDisplayMode.Add:
                    break;
            }
        }
        private void LoadTestType()
        {
            if (testType == null) return;
            lblTestTypeID.Text = $"TEST TYPE ID: {testType.TestTypeID}";
            txtTitle.Text = testType.Title;
            txtDescription.Text = testType.Description;
            txtFee.Text = testType.Fees.ToString();
        }
        private void ShowTestTypeUpdate()
        {
            LoadTestType();
        }
        private bool ValidateAllFields()
        {
            bool isValid = true;
            isValid &= Utils.Utils.ValidateField(txtTitle, "Title must not be empty!", errorProvider);
            isValid &= Utils.Utils.ValidateField(txtDescription, "Description must not be empty!", errorProvider);
            isValid &= Utils.Utils.ValidateField(txtFee, "Fees must not be empty!", errorProvider);
            return isValid;
        }
        private bool SaveTestType()
        {
            if (EnMode == CardUtils.EnDisplayMode.Update)
            {
                if (!ValidateAllFields()) return false;
                testType.Title = txtTitle.Text;
                testType.Description = txtDescription.Text;
                testType.Fees = decimal.Parse(txtFee.Text);
            }
            return testType.Save();
        }
    }
}
