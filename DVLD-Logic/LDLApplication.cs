using DVLD_Data;
using System.Data;
namespace DVLD_Logic
{
    public class LDLApplication
    {
        enum EnMode
        {
            Update = 0, AddNew = 1
        }
        EnMode Mode = EnMode.Update;
        public int LDLApplicationID { get; set; }
        public int LicenseClassID { get; set; }
        public int ApplicationID { get; set; }
        public LDLApplication()
        {
            LDLApplicationID = -1;
            LicenseClassID = -1;
            ApplicationID = -1;
            Mode = EnMode.AddNew;
        }
        private LDLApplication(int ldlApplicationID, int licenseClassID, int applicationID)
        {
            LDLApplicationID = ldlApplicationID;
            LicenseClassID = licenseClassID;
            ApplicationID = applicationID;
            Mode = EnMode.Update;
        }
        public static LDLApplication Find(int ldlApplicationID)
        {
            int licenseClassID = -1;
            int applicationID = -1;
            if (LDLApplicationDAL.FindBy(ldlApplicationID, ref licenseClassID, ref applicationID))
            {
                return new LDLApplication(ldlApplicationID, licenseClassID, applicationID);
            }
            else
            {
                return null;
            }
        }
        public static DataTable GetAllLDLApplications()
        {
            return LDLApplicationDAL.GetLDLApplications();
        }
        private bool _Add()
        {
            this.LDLApplicationID = LDLApplicationDAL.AddNewLDLApplication(LicenseClassID, ApplicationID);
            return LDLApplicationID != -1;
        }
        private bool _Update()
        {
            return LDLApplicationDAL.UpdateLDLApplication(LDLApplicationID, LicenseClassID, ApplicationID);
        }
        public bool Save()
        {
            switch (Mode)
            {
                case EnMode.AddNew:
                    if (_Add())
                    {
                        Mode = EnMode.Update;
                        return true;
                    }
                    else return false;
                case EnMode.Update:
                    return _Update();
            }
            return false;
        }
    }
}
