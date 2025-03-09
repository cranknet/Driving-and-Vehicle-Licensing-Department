using DVLD_Data;
using System.Data;
namespace DVLD_Logic
{
    public class User
    {
        enum EnMode
        {
            Update = 0,
            AddNew = 1
        }
        EnMode Mode = EnMode.Update;
        public int UserID { get; set; }
        public int PersonID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string NewPassword { get; set; }
        public bool IsActive { get; set; }
        public User()
        {
            this.UserID = -1;
            this.PersonID = -1;
            this.UserName = string.Empty;
            this.Password = string.Empty;
            this.IsActive = false;
            Mode = EnMode.AddNew;
        }
        private User(int userID, int personID, string userName, string password, bool isActive)
        {
            UserID = userID;
            PersonID = personID;
            UserName = userName;
            Password = password;
            IsActive = isActive;
            Mode = EnMode.Update;
        }
        public static User Find(int userID)
        {
            int personID = -1;
            string userName = string.Empty;
            string password = string.Empty;
            bool isActive = false;
            if (UserDAL.Find(userID, ref personID, ref userName, ref password, ref isActive))
            {
                return new User(userID, personID, userName, password, isActive);
            }
            else
            {
                return null;
            }
        }
        public static int IsUserExistsByUserNamePassword(string userName, string password)
        {
            return UserDAL.IsUserExistsBy(userName, password);
        }
        public static DataTable GetAllUsers()
        {
            return UserDAL.GetUsers();
        }
        public static bool DeleteBy(int userID)
        {
            return UserDAL.DeleteUserByID(userID);
        }
        private bool _Update()
        {
            return UserDAL.UpdatePassword(this.UserID, this.Password, this.NewPassword);
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
        private bool _Add()
        {
            this.UserID = UserDAL.AddNewUser(this.PersonID, this.UserName, this.Password, this.IsActive);
            return this.UserID != -1;
        }
    }
}
