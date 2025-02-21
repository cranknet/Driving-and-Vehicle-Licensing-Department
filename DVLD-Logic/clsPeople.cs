using DVLD_Data;
using System;
using System.Data;
namespace DVLD_Logic
{
    public class clsPeople : clsPerson
    {
        enum EnMode
        {
            Update = 0,
            AddNew = 1
        }
        EnMode enMode = EnMode.Update;
        public clsPeople()
        {
            enMode = EnMode.AddNew;

        }
        private clsPeople(int personID, string nationalNo, string firstName, string lastName,
                          DateTime dateOfBirth, string gender, string address, string phone,
                          string email, int countryID, string imagePath) : base(personID, nationalNo, firstName, lastName, dateOfBirth, gender, address, phone, email, countryID, imagePath)
        {
            enMode = EnMode.Update;
        }
        public static clsPeople FindByPersonID(int personID)
        {
            string nationalNo = string.Empty;
            string firstName = string.Empty;
            string lastName = string.Empty;
            DateTime dateOfBirth = DateTime.MinValue;
            string gender = string.Empty;
            string address = string.Empty;
            string email = string.Empty;
            string phone = string.Empty;
            int countryID = 0;
            string imagePath = string.Empty;
            if (clsPeopleDAL.FindBy(personID, ref nationalNo, ref firstName, ref lastName, ref dateOfBirth, ref gender, ref address, ref phone, ref email, ref countryID, ref imagePath))
            {
                return new clsPeople(personID, nationalNo, firstName, lastName, dateOfBirth, gender, address, phone, email, countryID, imagePath);
            }
            else
            {
                return null;
            }
        }
        public static DataTable GetAllPeople()
        {
            return DVLD_Data.clsPeopleDAL.GetAllPeople();
        }
        // FindBy People Person by Person ID
        public static bool IsPersonExistsByID(int personID)
        {
            return clsPeopleDAL.IsPersonExistsBy(personID);
        }
        public static bool IsPersonExistsByNationalNo(string nationalNo)
        {
            return clsPeopleDAL.IsPersonExistsBy(nationalNo);
        }
        private bool _Update()
        {
            return clsPeopleDAL.UpdatePerson(this.PersonID, this.NationalNo, this.FirstName, this.LastName, this.DateOfBirth, this.Gender, this.Address, this.Phone, this.Email, this.CountryID, this.ImagePath);
        }
        public static bool DeleteBy(int personID)
        {
            return clsPeopleDAL.DeletePeopleByID(personID);
        }
        public bool _Add()
        {
            this.PersonID = clsPeopleDAL.AddNewPerson(NationalNo, FirstName, LastName, DateOfBirth, Gender, Address, Phone, Email, CountryID, ImagePath);
            return this.PersonID != -1;
        }
        public bool Save()
        {
            switch (enMode)
            {
                case EnMode.AddNew:
                    if (_Add())
                    {
                        enMode = EnMode.Update;
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
