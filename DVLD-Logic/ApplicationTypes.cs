using DVLD_Data;
using System;
using System.Data;

namespace DVLD_Logic
{
    public class ApplicationTypes
    {
        enum EnMode
        {
            Update = 0
        }
        EnMode enMode = EnMode.Update;
        private int ApplicationTypeID { get; set; }
        private string ApplicationTypeTitle { get; set; }
        private double ApplicationFees { get; set; }
        private ApplicationTypes(int applicationTypeID, string applicationTypeTitle, double applicationFees)
        {
            this.enMode = EnMode.Update;
            ApplicationTypeID = applicationTypeID;
            ApplicationTypeTitle = applicationTypeTitle;
            ApplicationFees = applicationFees;
        }
        public static DataTable GetAllApplicationTypes()
        {
            return ApplicationTypesDAL.GetApplicationTypes();
        }
        private bool _Update()
        {
            throw new NotImplementedException();
        }
    }
}
