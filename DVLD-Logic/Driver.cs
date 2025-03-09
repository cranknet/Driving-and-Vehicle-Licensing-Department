using DVLD_Data;
using System;
using System.Data;
namespace DVLD_Logic
{
    public class Driver
    {
        enum EnMode
        {
            Update = 0,
        }
        EnMode Mode = EnMode.Update;
        public int DriverID { get; set; }
        public int PersonID { get; set; }
        public int CreatedByUserID { get; set; }
        public DateTime CreatedDate { get; set; }
        private Driver(int driverID, int personID, int createdByUserID, DateTime createdDate)
        {
            DriverID = driverID;
            PersonID = personID;
            CreatedByUserID = createdByUserID;
            CreatedDate = createdDate;
            Mode = EnMode.Update;
        }
        public static DataTable GetAllDrivers()
        {
            return DriverDAL.GetAllDrivers();
        }
    }
}
