using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_Data
{
    public class clsUserDAL
    {
        public static bool Find(int userID, ref int personID, ref string userName, ref string password, ref bool isActive)
        {
            bool isFound = true;
            string query = @"SELECT UserID, PersonID, UserName, Password, IsActive 
                             FROM Users
                             WHERE UserID = @UserID";
            using (SqlConnection connection = new SqlConnection(clsDatabaseHelper.ConnectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@UserID", userID);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        isFound = true;
                        userID = (int)reader["UserID"];
                        personID = (int)reader["PersonID"];
                        userName = (string)reader["UserName"];
                        password = (string)reader["Password"];
                        isActive = (bool)reader["IsActive"];
                    }
                    else
                    {
                        isFound = false;
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine($"UserDAL FindBy By : SQL Error -> {ex.Message}");
                }
            }
            return isFound;
        }
        public static bool IsUserExistsBy(int userID)
        {
            string query = "SELECT COUNT(*) FROM Users WHERE UserID = @UserID;";
            using (SqlConnection connection = new SqlConnection(clsDatabaseHelper.ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@UserID", userID);
                try
                {
                    connection.Open();
                    int result = (int)cmd.ExecuteScalar();
                    return result > 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"IsUserExistsBy: Error checking user existence by ID: {ex.Message}");
                }
            }
            return false;
        }
        public static int IsUserExistsBy(string userName, string Password)
        {
            int userID = -1;
            string query = "SELECT UserID FROM Users WHERE Username = @UserName AND Password = @Password";
            using (SqlConnection connection = new SqlConnection(clsDatabaseHelper.ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@UserName", userName);
                cmd.Parameters.AddWithValue("@Password", Password);
                try
                {
                    connection.Open();
                    userID = (int)cmd.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"IsUserExistsBy: Error checking user existence by UserName & Password: {ex.Message}");
                }
            }
            return userID;
        }
        public static DataTable GetAllUsers()
        {
            DataTable dt = new DataTable();
            string query = @"SELECT UserID, PersonID, UserName, Password, IsActive FROM Users;";
            using (SqlConnection connection = new SqlConnection(clsDatabaseHelper.ConnectionString))
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
                    Console.WriteLine($"GetAllUsers: SQL Error -> {ex.Message}");
                }
            }
            return dt;
        }
    }
}
