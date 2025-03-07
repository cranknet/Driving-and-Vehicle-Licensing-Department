using DVLD_Data;
using System;
using System.Data;
namespace DVLD_Logic
{
    public class People : Person
    {
        enum EnMode
        {
            Update = 0,
            AddNew = 1
        }
        EnMode enMode = EnMode.Update;
        public People()
        {
            enMode = EnMode.AddNew;

        }
        private People(int personID, string nationalNo, string firstName, string lastName,
                          DateTime dateOfBirth, string gender, string address, string phone,
                          string email, int countryID, string imagePath) : base(personID, nationalNo, firstName, lastName, dateOfBirth, gender, address, phone, email, countryID, imagePath)
        {
            enMode = EnMode.Update;
        }
        public static People FindByPersonID(int personID)
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
            if (PeopleDAL.FindBy(personID, ref nationalNo, ref firstName, ref lastName, ref dateOfBirth, ref gender, ref address, ref phone, ref email, ref countryID, ref imagePath))
            {
                return new People(personID, nationalNo, firstName, lastName, dateOfBirth, gender, address, phone, email, countryID, imagePath);
            }
            else
            {
                return null;
            }
        }
        public static DataTable GetAllPeople()
        {
            return DVLD_Data.PeopleDAL.GetAllPeople();
        }
        public static DataTable GetNonUserPeople()
        {
            return DVLD_Data.PeopleDAL.GetNonUserPeople();
        }

        // FindBy People Person by Person ID
        public static bool IsPersonExistsByID(int personID)
        {
            return PeopleDAL.IsPersonExistsBy(personID);
        }
        public static bool IsPersonExistsByNationalNo(string nationalNo)
        {
            return PeopleDAL.IsPersonExistsBy(nationalNo);
        }
        private bool _Update()
        {
            return PeopleDAL.UpdatePerson(this.PersonID, this.NationalNo, this.FirstName, this.LastName, this.DateOfBirth, this.Gender, this.Address, this.Phone, this.Email, this.CountryID, this.ImagePath);
        }
        public static bool DeleteBy(int personID)
        {
            return PeopleDAL.DeletePeopleByID(personID);
        }
        public bool _Add()
        {
            this.PersonID = PeopleDAL.AddNewPerson(NationalNo, FirstName, LastName, DateOfBirth, Gender, Address, Phone, Email, CountryID, ImagePath);
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
