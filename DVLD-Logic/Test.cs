using DVLD_Data;
namespace DVLD_Logic
{
    public class Test
    {
        enum EnMode
        {
            Update = 0,
            AddNew = 1
        }
        EnMode Mode = EnMode.Update;
        public int TestID { get; set; }
        public int TestAppointmentID { get; set; }
        public bool TestResult { get; set; }
        public string Notes { get; set; }
        public int CreatedByUserID { get; set; }
        private Test(int testID, int testAppointmentID, bool testResult, string notes, int createdByUserID)
        {
            TestID = testID;
            TestAppointmentID = testAppointmentID;
            TestResult = testResult;
            Notes = notes;
            CreatedByUserID = createdByUserID;
            Mode = EnMode.Update;
        }
        public Test()
        {
            TestID = -1;
            TestAppointmentID = -1;
            TestResult = false;
            Notes = string.Empty;
            CreatedByUserID = -1;
            Mode = EnMode.AddNew;
        }
        public static Test Find(int testID)
        {
            int testAppointmentID = -1;
            bool testResult = false;
            string notes = string.Empty;
            int createdByUserID = -1;
            if (TestDAL.FindByTestID(testID, ref testAppointmentID, ref testResult, ref notes, ref createdByUserID))
            {
                return new Test(testID, testAppointmentID, testResult, notes, createdByUserID);
            }
            else
            {
                return null;
            }
        }
        public static Test FindByTestAppointmentID(int testAppointmentID)
        {
            int testID = -1;
            bool testResult = false;
            string notes = string.Empty;
            int createdByUserID = -1;
            if (TestDAL.FindByTestAppointmentID(testAppointmentID, ref testID, ref testResult, ref notes, ref createdByUserID))
            {
                return new Test(testID, testAppointmentID, testResult, notes, createdByUserID);
            }
            else
            {
                return null;
            }
        }
        private bool _Add()
        {
            this.TestID = TestDAL.AddTest(TestAppointmentID, TestResult, Notes, CreatedByUserID);
            return TestID != -1;
        }
        private bool _Update()
        {
            return TestDAL.UpdateTest(this.TestID, this.TestResult, this.Notes);
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
                    else
                    {
                        return false;
                    }
                case EnMode.Update:
                    return _Update();
                default:
                    return false;
            }
        }
    }
}
