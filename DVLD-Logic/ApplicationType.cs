using DVLD_Data;
using System.Data;
namespace DVLD_Logic
{
    public class ApplicationType
    {
        enum EnMode
        {
            Update = 0
        }
        EnMode enMode = EnMode.Update;
        public int ID { get; set; }
        public string Title { get; set; }
        public decimal Fees { get; set; }
        private ApplicationType(int iD, string title, decimal fees)
        {
            this.enMode = EnMode.Update;
            ID = iD;
            Title = title;
            Fees = fees;
        }
        public static DataTable GetAllApplicationTypes()
        {
            return ApplicationTypeDAL.GetApplicationTypes();
        }
        public static ApplicationType Find(int iD)
        {
            string title = string.Empty;
            decimal fees = 0;
            if (ApplicationTypeDAL.FindByID(iD, ref title, ref fees))
            {
                return new ApplicationType(iD, title, fees);
            }
            else
            {
                return null;
            }
        }
        private bool _Update()
        {
            return ApplicationTypeDAL.Update(ID, Title, Fees);
        }
        public bool Save()
        {
            switch (enMode)
            {
                case EnMode.Update:
                    return _Update();
                default:
                    return false;
            }
        }
    }
}
