using System;
namespace DVLD_Logic
{
    public class Person
    {
        public int PersonID { get; set; }
        public string NationalNo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string CountryName { get; set; }
        public int CountryID { get; set; }
        public string ImagePath { get; set; }
        public Person()
        {
            this.PersonID = -1;
            this.NationalNo = string.Empty;
            this.FirstName = string.Empty;
            this.LastName = string.Empty;
            this.DateOfBirth = DateTime.Now;
            this.Gender = string.Empty;
            this.Address = string.Empty;
            this.Email = string.Empty;
            this.Phone = string.Empty;
            this.CountryID = 0;
            this.CountryName = string.Empty;
            this.ImagePath = string.Empty;
        }
        protected Person(int personID, string nationalNo, string firstName, string lastName, DateTime birthDate, string gender, string address, string phone, string email, int countryID, string imagePath)
        {
            this.PersonID = personID;
            this.NationalNo = nationalNo;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.DateOfBirth = birthDate;
            this.Gender = gender;
            this.Address = address;
            this.Email = email;
            this.Phone = phone;
            this.CountryID = countryID;
            this.CountryName = "";
            this.ImagePath = imagePath;
        }
    }
}
