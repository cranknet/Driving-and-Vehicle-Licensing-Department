using DVLD_Data;
using System.Data;
namespace DVLD_Logic
{
    public class LicenseClass
    {
        enum EnMode
        {
            AddNew = 0,
            Update = 1
        }
        EnMode Mode = EnMode.Update;
        public int LicenseClassID { get; set; }
        public string LicenseClassName { get; set; }
        public string ClassDescription { get; set; }
        public int MinimumAllowedAge { get; set; }
        public int DefaultValidityLength { get; set; }
        public decimal ClassFees { get; set; }
        public LicenseClass()
        {
            this.LicenseClassID = -1;
            this.LicenseClassName = string.Empty;
            this.ClassDescription = string.Empty;
            this.MinimumAllowedAge = 0;
            this.DefaultValidityLength = 0;
            this.ClassFees = 0;
            Mode = EnMode.AddNew;
        }
        private LicenseClass(int licenseClassID, string licenseClassName, string classDescription, int minimumAgeAllowed, int defaultValidityLength, decimal classFees)
        {
            this.LicenseClassID = licenseClassID;
            this.LicenseClassName = licenseClassName;
            this.ClassDescription = classDescription;
            this.MinimumAllowedAge = minimumAgeAllowed;
            this.DefaultValidityLength = defaultValidityLength;
            this.ClassFees = classFees;
            Mode = EnMode.Update;
        }
        public static DataTable GetAllLicenseClasses()
        {
            return LicenseClassDAL.GetLicenseClasses();
        }
        public static LicenseClass FindByLicenseClassID(int licenseClassID)
        {
            string licenseClassName = string.Empty;
            string classDescription = string.Empty;
            int minimumAllowedAge = 0;
            int defaultValidityLength = 0;
            decimal classFees = 0;
            if (LicenseClassDAL.Find(licenseClassID, ref licenseClassName, ref classDescription, ref minimumAllowedAge, ref defaultValidityLength, ref classFees))
            {
                return new LicenseClass(licenseClassID, licenseClassName, classDescription, minimumAllowedAge, defaultValidityLength, classFees);
            }
            else
            {
                return null;
            }
        }
    }
}
