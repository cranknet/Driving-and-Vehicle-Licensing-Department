using DVLD_Data;
using System.Data;
namespace DVLD_Logic
{
    public class TestType
    {
        enum EnMode
        {
            Update = 0,
        }
        EnMode Mode = EnMode.Update;
        public int TestTypeID { get; set; }
        public string TestTypeTitle { get; set; }
        public string TestTypeDescription { get; set; }
        public decimal TestTypeFees { get; set; }
        private TestType(int testTypeID, string testTypeTitle, string testTypeDescription, decimal testTypeFees)
        {
            TestTypeID = testTypeID;
            TestTypeTitle = testTypeTitle;
            TestTypeDescription = testTypeDescription;
            TestTypeFees = testTypeFees;
            Mode = EnMode.Update;
        }
        public static DataTable GetAllTestTypes()
        {
            return TestTypeDAL.GetTestTypes();
        }
        public static TestType Find(int testTypeID)
        {
            string testTypeTitle = string.Empty;
            string testTypeDescription = string.Empty;
            decimal testTypeFees = 0;
            if (TestTypeDAL.FindByID(testTypeID, ref testTypeTitle, ref testTypeDescription, ref testTypeFees))
            {
                return new TestType(testTypeID, testTypeTitle, testTypeDescription, testTypeFees);
            }
            else
            {
                return null;
            }
        }
        private bool _Update()
        {
            return TestTypeDAL.Update(TestTypeID, TestTypeTitle, TestTypeDescription, TestTypeFees);
        }
        public bool Save()
        {
            switch (Mode)
            {
                case EnMode.Update:
                    return _Update();
                default:
                    return false;
            }
        }
    }
}
