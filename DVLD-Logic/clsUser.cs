using DVLD_Data;
using System.Data;

namespace DVLD_Logic
{
    public class clsUser
    {
        enum EnMode
        {
            UpdateMode = 0,
            AddNewMode = 1
        }
        EnMode Mode = EnMode.UpdateMode;
        public int UserID { get; set; }
        public int PersonID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
        public clsUser()
        {
            this.UserID = -1;
            this.PersonID = -1;
            this.UserName = string.Empty;
            this.Password = string.Empty;
            this.IsActive = false;
            Mode = EnMode.AddNewMode;
        }
        private clsUser(int userID, int personID, string userName, string password, bool isActive)
        {
            UserID = userID;
            PersonID = personID;
            UserName = userName;
            Password = password;
            IsActive = isActive;
            Mode = EnMode.UpdateMode;
        }
        public static clsUser Find(int userID)
        {
            int personID = -1;
            string userName = string.Empty;
            string password = string.Empty;
            bool isActive = false;
            if (clsUserDAL.Find(userID, ref personID, ref userName, ref password, ref isActive))
            {
                return new clsUser(userID, personID, userName, password, isActive);
            }
            else
            {
                return null;
            }
        }
        public static int IsUserExistsByUserNamePassword(string userName, string password)
        {
            return clsUserDAL.IsUserExistsBy(userName, password);
        }
        public static DataTable GetAllUsers()
        {
            return clsUserDAL.GetAllUsers();
        }
    }
}
