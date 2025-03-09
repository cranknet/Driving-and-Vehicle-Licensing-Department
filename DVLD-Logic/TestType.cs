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
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Fees { get; set; }
        private TestType(int testTypeID, string title, string description, decimal fees)
        {
            TestTypeID = testTypeID;
            Title = title;
            Description = description;
            Fees = fees;
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
            return TestTypeDAL.Update(TestTypeID, Title, Description, Fees);
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
