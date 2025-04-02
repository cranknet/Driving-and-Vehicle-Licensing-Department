using DVLD_Data;
using System;
namespace DVLD_Logic
{
    public class clsApplication
    {
        enum EnMode
        {
            Update = 0, AddNew = 1
        }
        EnMode Mode = EnMode.Update;
        public int ApplicationID { get; set; }
        public int ApplicantPersonID { get; set; }
        public DateTime ApplicationDate { get; set; }
        public int ApplicationTypeID { get; set; }
        public byte ApplicationStatus { get; set; }
        public DateTime LastStatusDate { get; set; }
        public decimal PaidFees { get; set; }
        public int CreatedByUserID { get; set; }
        public int LicenseClassID { get; set; }
        public clsApplication()
        {
            ApplicationID = -1;
            ApplicantPersonID = -1;
            ApplicationDate = DateTime.Now;
            ApplicationTypeID = -1;
            ApplicationStatus = 1;
            LastStatusDate = DateTime.Now;
            PaidFees = 0;
            CreatedByUserID = -1;
            Mode = EnMode.AddNew;
        }
        private clsApplication(int applicationID, int applicantPersonID, DateTime applicationDate, int applicationTypeID, byte applicationStatus, DateTime lastStatusDate, decimal paidFees, int createdByUserID)
        {
            ApplicationID = applicationID;
            ApplicantPersonID = applicantPersonID;
            ApplicationDate = applicationDate;
            ApplicationTypeID = applicationTypeID;
            ApplicationStatus = applicationStatus;
            LastStatusDate = lastStatusDate;
            PaidFees = paidFees;
            CreatedByUserID = createdByUserID;
            Mode = EnMode.Update;
        }
        public static clsApplication Find(int applicationID)
        {
            int applicantPersonID = -1;
            DateTime applicationDate = DateTime.Now;
            int applicationTypeID = -1;
            byte applicationStatus = 1;
            DateTime lastStatusDate = DateTime.Now;
            decimal paidFees = 0;
            int createdByUserID = -1;
            if (ApplicationDAL.Find(applicationID, ref applicantPersonID, ref applicationDate, ref applicationTypeID, ref applicationStatus, ref lastStatusDate, ref paidFees, ref createdByUserID))
            {
                return new clsApplication(applicationID, applicantPersonID, applicationDate, applicationTypeID, applicationStatus, lastStatusDate, paidFees, createdByUserID);
            }
            else
            {
                return null;
            }
        }
        private bool UpdateStatus()
        {
            return ApplicationDAL.UpdateApplicationStatus(ApplicationID, ApplicationStatus, LastStatusDate);
        }
        private bool Add()
        {
            this.ApplicationID = ApplicationDAL.AddNewApplication(ApplicantPersonID, ApplicationDate, ApplicationTypeID, ApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID);
            if (ApplicationID != -1)
            {
                return LDLApplicationDAL.AddNewLDLApplication(LicenseClassID, ApplicationID) != 1;
            }
            return false;
        }
        public bool Save()
        {
            switch (Mode)
            {
                case EnMode.AddNew:
                    if (Add())
                    {
                        Mode = EnMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case EnMode.Update:
                    // I will use another update function for application not the status
                    return UpdateStatus();
            }
            return false;
        }
        public int CheckLDLApplicationExists()
        {
            return LDLApplicationDAL.GetActiveLDLApplicationIDForLicenseClass(ApplicantPersonID, LicenseClassID, ApplicationStatus);
        }
    }
}
