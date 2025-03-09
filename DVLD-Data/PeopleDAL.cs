using System;
using System.Data;
using System.Data.SqlClient;
namespace DVLD_Data
{
    public class PeopleDAL
    {
        // FindBy Person Object
        public static bool FindBy(int personID, ref string nationalNo, ref string firstName, ref string lastName,
                                 ref DateTime dateOfBirth, ref string gender, ref string address, ref string phone,
                                 ref string email, ref int countryID, ref string imagePath)
        {
            bool isFound = false;
            string query = @"SELECT PersonID, NationalNo, FirstName, LastName, DateOfBirth, 
                            CASE 
                            WHEN Gendor = 0 THEN 'Male'
                            WHEN Gendor = 1 THEN 'Female'
                            END AS Gender, Address, Phone, Email, NationalityCountryID, ImagePath
                            FROM People 
							WHERE People.PersonID = @PersonID";
            using (SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@PersonID", personID);
                try
                {
                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        isFound = true;
                        nationalNo = reader["NationalNo"].ToString();
                        firstName = reader["FirstName"].ToString();
                        lastName = reader["LastName"].ToString();
                        dateOfBirth = (DateTime)reader["DateOfBirth"];
                        gender = reader["Gender"].ToString();  // 'Male' or 'Female'
                        address = reader["Address"].ToString();
                        phone = reader["Phone"].ToString();
                        email = reader["Email"].ToString();
                        countryID = (int)reader["NationalityCountryID"];
                        imagePath = (reader["ImagePath"] != DBNull.Value) ? reader["ImagePath"].ToString() : string.Empty;
                    }
                    else isFound = false;
                }
                catch (SqlException ex)
                {
                    Console.WriteLine($"Country FindBy By Name: SQL Error -> {ex.Message}");
                }
                return isFound;
            }
        }
        // Get All Peoples
        public static DataTable GetPeople()
        {
            DataTable dt = new DataTable();
            string query = @"SELECT PersonID, NationalNo, FirstName, LastName, DATEDIFF(YEAR, DateOfBirth, GETDATE()) AS Age,
                            CASE 
                            WHEN Gendor = 0 THEN 'Male'
                            WHEN Gendor = 1 THEN 'Female'
                            END AS Gender, Phone, Email 
                            FROM People;";
            using (SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                try
                {
                    connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        dt.Load(reader);
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine($"GetPeople: SQL Error -> {ex.Message}");
                }
            }
            return dt;
        }
        // Get People with no user account
        public static DataTable GetNonUserPeople()
        {
            DataTable dt = new DataTable();
            string query = @"SELECT PersonID, NationalNo, FirstName, LastName FROM People
                             WHERE PersonID NOT IN (SELECT PersonID FROM Users);";
            using (SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                try
                {
                    connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        dt.Load(reader);
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine($"GetNonUserPeople: SQL Error -> {ex.Message}");
                }
            }
            return dt;
        }
        // Check Person Existence
        public static bool IsPersonExistsBy(int personID)
        {
            string query = "SELECT COUNT(*) FROM People WHERE PersonID = @PersonID;";
            using (SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("PersonID", personID);
                try
                {
                    connection.Open();
                    int result = (int)cmd.ExecuteScalar();
                    return result > 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"IsPersonExistsBy: Error checking person existence by ID: {ex.Message}");
                }
            }
            return false;
        }
        public static bool IsPersonExistsBy(string nationalNo)
        {
            string query = "SELECT COUNT(*) FROM People WHERE NationalNo = @NationalNo;";
            using (SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("NationalNo", nationalNo);
                try
                {
                    connection.Open();
                    int result = (int)cmd.ExecuteScalar();
                    return result > 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"IsPersonExistsBy: Error checking person existence by NationalNo: {ex.Message}");
                }
            }
            return false;
        }
        // Update Person
        public static bool UpdatePerson(int personID, string nationalNo, string firstName, string lastName,
                                  DateTime dateOfBirth, string gender, string address, string phone,
                                  string email, int countryID, string imagePath)
        {
            // Handle Gender 
            int Gender = (gender == "Male") ? 0 : 1;
            int rowAffected = 0;
            string query = @"UPDATE People
                             SET NationalNo = @NationalNo, 
                                FirstName = @FirstName, 
                                LastName = @LastName, 
                                DateOfBirth = @DateOfBirth, 
                                Gendor = @Gendor, 
                                Address = @Address, 
                                Phone = @Phone, 
                                Email = @Email, 
                                NationalityCountryID = @CountryID, 
                                ImagePath = @ImagePath
                             FROM People
                             WHERE People.PersonID = @PersonID";
            using (SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@NationalNo", nationalNo);
                cmd.Parameters.AddWithValue("@FirstName", firstName);
                cmd.Parameters.AddWithValue("@LastName", lastName);
                cmd.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);
                cmd.Parameters.AddWithValue("@Gendor", Gender);
                cmd.Parameters.AddWithValue("@Address", address);
                cmd.Parameters.AddWithValue("@Phone", phone);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@CountryID", countryID);
                cmd.Parameters.AddWithValue("@ImagePath", imagePath);
                cmd.Parameters.AddWithValue("@PersonID", personID);
                try
                {
                    connection.Open();
                    rowAffected = cmd.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    Console.WriteLine($"Update: Person SQL Error -> {ex.Message}");
                }
            }
            return rowAffected > 0;
        }
        public static bool DeletePeopleByID(int personID)
        {
            int rowAffected = 0;
            string query = "DELETE People WHERE PersonID = @PersonID";
            using (SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@PersonID", personID);
                try
                {
                    connection.Open();
                    rowAffected = cmd.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    Console.WriteLine($"DeletePeopleByID: SQL Error -> {ex.Message}");
                }
            }
            return rowAffected > 0;
        }
        // Add new Person
        public static int AddNewPerson(string nationalNo, string firstName, string lastName,
                                  DateTime dateOfBirth, string gender, string address, string phone,
                                  string email, int countryID, string imagePath)
        {
            int personID = -1;
            int intGender = (gender == "Male") ? 0 : 1;
            string query = @"INSERT INTO People (NationalNo, FirstName, LastName, DateOfBirth, Gendor, Address, Phone, Email, NationalityCountryID, ImagePath)
                                         VALUES (@NationalNo, @FirstName, @LastName, @DateOfBirth, @Gender, @Address, @Phone, @Email, @CountryID, @ImagePath);
                                         SELECT SCOPE_IDENTITY()";
            using (SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@NationalNo", nationalNo);
                cmd.Parameters.AddWithValue("@FirstName", firstName);
                cmd.Parameters.AddWithValue("@LastName", lastName);
                cmd.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);
                cmd.Parameters.AddWithValue("@Gender", intGender);
                cmd.Parameters.AddWithValue("@Address", address);
                cmd.Parameters.AddWithValue("@Phone", phone);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@CountryID", countryID);
                cmd.Parameters.AddWithValue("@ImagePath", imagePath);
                try
                {
                    connection.Open();
                    object queryResult = cmd.ExecuteScalar();
                    if (queryResult != null && int.TryParse(queryResult.ToString(), out int newPersonID)) personID = newPersonID;
                }
                catch (SqlException ex)
                {
                    Console.WriteLine($"Add New Person: SQL Error -> {ex.Message}");
                }
            }
            return personID;
        }
    }
}
