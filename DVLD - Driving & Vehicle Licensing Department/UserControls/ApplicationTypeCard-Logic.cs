using DVLD_Logic;
using System.Windows.Forms;
namespace DVLD_UI.UserControls.Cards
{
    public partial class ApplicationTypeCard : UserControl
    {
        ApplicationType applicationType = null;
        private void Display()
        {
            ShowApplicationTypeUpdate();
        }
        private void LoadApplicationType()
        {
            if (applicationType == null) return;
            lblApplicationTypeID.Text = $"APPLICATION TYPE ID: {applicationType.ID}";
            txtTitle.Text = applicationType.Title;
            txtFee.Text = applicationType.Fees.ToString();
        }
        private void ShowApplicationTypeUpdate()
        {
            LoadApplicationType();
        }
        private bool ValidateAllFields()
        {
            bool isValid = true;
            isValid &= Utils.Utils.ValidateField(txtTitle, "Title must not be empty!", errorProvider);
            isValid &= Utils.Utils.ValidateField(txtFee, "Fees must not be empty!", errorProvider);
            return isValid;
        }
        private bool SaveApplicationType()
        {
            if (!ValidateAllFields()) return false;
            applicationType.Title = txtTitle.Text;
            applicationType.Fees = decimal.Parse(txtFee.Text);
            return applicationType.Save();
        }
    }
}
