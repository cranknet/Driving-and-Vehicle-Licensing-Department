using DVLD_Data;
using System;
using System.Data;
namespace DVLD_Logic
{
    public class TestAppointment
    {
        enum EnMode
        {
            Update = 0,
            AddNew = 1
        }
        EnMode Mode = EnMode.AddNew;
        public int TestAppointmentID { get; set; }
        public int TestTypeID { get; set; }
        public int LDLAppID { get; set; }
        public DateTime AppointmentDate { get; set; }
        public decimal PaidFees { get; set; }
        public int CreatedByUserID { get; set; }
        public bool IsLocked { get; set; }
        public TestAppointment()
        {
            TestAppointmentID = -1;
            TestTypeID = -1;
            LDLAppID = -1;
            AppointmentDate = DateTime.Now;
            PaidFees = 0;
            CreatedByUserID = -1;
            IsLocked = false;
            Mode = EnMode.AddNew;
        }
        private TestAppointment(int testAppointmentID, int testTypeID, int lDLAppID, DateTime appointmentDate, decimal paidFees, int createdByUserID, bool isLocked)
        {
            TestAppointmentID = testAppointmentID;
            TestTypeID = testTypeID;
            LDLAppID = lDLAppID;
            AppointmentDate = appointmentDate;
            PaidFees = paidFees;
            CreatedByUserID = createdByUserID;
            IsLocked = isLocked;
            Mode = EnMode.Update;
        }
        public static TestAppointment Find(int testAppointmentID)
        {
            int testTypeID = -1;
            int lDLAppID = -1;
            DateTime appointmentDate = DateTime.Now;
            decimal paidFees = 0;
            int createdByUserID = -1;
            bool isLocked = false;
            if (TestAppointmentDAL.FindBy(testAppointmentID, ref testTypeID, ref lDLAppID, ref appointmentDate, ref paidFees, ref createdByUserID, ref isLocked))
            {
                return new TestAppointment(testAppointmentID, testTypeID, lDLAppID, appointmentDate, paidFees, createdByUserID, isLocked);
            }
            else
            {
                return null;
            }
        }
        public bool Lock()
        {
            IsLocked = true;
            return TestAppointmentDAL.LockAppointment(TestAppointmentID);
        }
        public static DataTable GetTestAppointments(int testTypeID, int lDLAppID)
        {
            return TestAppointmentDAL.GetAllTestAppointments(testTypeID, lDLAppID);
        }
        public static bool ActiveTestAppointmentExistsBy(int testTypeID, int lDLAppID)
        {
            return TestAppointmentDAL.DoesActiveTestAppointmentExist(testTypeID, lDLAppID);
        }
        public static bool GetTestAppointmentLockedStatus(int testAppointmentID)
        {
            return TestAppointmentDAL.GetTestAppointmentLockedStatus(testAppointmentID);
        }
        public static bool TestAppointmentExistsBy(int testAppointmentID)
        {
            return TestAppointmentDAL.DoesTestAppointmentExist(testAppointmentID);
        }
        private bool _Add()
        {
            this.TestAppointmentID = TestAppointmentDAL.AddTestAppointment(TestTypeID, LDLAppID, AppointmentDate, PaidFees, CreatedByUserID, IsLocked);
            return this.TestAppointmentID != -1;
        }
        private bool _Update()
        {
            return TestAppointmentDAL.UpdateTestAppointmentDate(TestAppointmentID, AppointmentDate);
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
