using DVLD_Logic;
using System.Windows.Forms;
namespace DVLD_UI.UserControls.Cards
{
    public partial class ApplicationTypeCard : UserControl
    {
        ApplicationType applicationType = null;
        CardUtils.EnDisplayMode EnMode { get; set; }
        private void Display()
        {
            switch (EnMode)
            {
                case CardUtils.EnDisplayMode.Read:
                    break;
                case CardUtils.EnDisplayMode.Update:
                    ShowApplicationTypeUpdate();
                    break;
                case CardUtils.EnDisplayMode.Add:
                    break;
            }
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
            if (EnMode == CardUtils.EnDisplayMode.Update)
            {
                if (!ValidateAllFields()) return false;
                applicationType.Title = txtTitle.Text;
                applicationType.Fees = decimal.Parse(txtFee.Text);
            }
            return applicationType.Save();
        }
    }
}
