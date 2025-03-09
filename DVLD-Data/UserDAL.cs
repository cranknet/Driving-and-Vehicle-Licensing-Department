using System;
using System.Data;
using System.Data.SqlClient;
namespace DVLD_Data
{
    public class UserDAL
    {
        public static bool Find(int userID, ref int personID, ref string userName, ref string password, ref bool isActive)
        {
            bool isFound = true;
            string query = @"SELECT UserID, PersonID, UserName, Password, IsActive 
                                 FROM Users
                                 WHERE UserID = @UserID";
            using (SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString))
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
            using (SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString))
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
            using (SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@UserName", userName);
                cmd.Parameters.AddWithValue("@Password", Password);
                try
                {
                    connection.Open();
                    var result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        userID = (int)result;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"IsUserExistsBy: Error checking user existence by UserName & Password: {ex.Message}");
                }
            }
            return userID;
        }
        public static DataTable GetUsers()
        {
            DataTable dt = new DataTable();
            string query = @"SELECT UserID, PersonID, UserName, Password, IsActive FROM Users;";
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
                    Console.WriteLine($"GetUsers: SQL Error -> {ex.Message}");
                }
            }
            return dt;
        }
        public static bool UpdatePassword(int userID, string oldPassword, string newPassword)
        {
            string queryCheckPassword = "SELECT COUNT(*) FROM Users WHERE UserID = @UserID AND Password = @OldPassword";
            string queryUpdatePassword = "UPDATE Users SET Password = @NewPassword WHERE UserID = @UserID";
            using (SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString))
            using (SqlCommand cmdCheckPassword = new SqlCommand(queryCheckPassword, connection))
            using (SqlCommand cmdUpdatePassword = new SqlCommand(queryUpdatePassword, connection))
            {
                cmdCheckPassword.Parameters.AddWithValue("@UserID", userID);
                cmdCheckPassword.Parameters.AddWithValue("@OldPassword", oldPassword);
                cmdUpdatePassword.Parameters.AddWithValue("@UserID", userID);
                cmdUpdatePassword.Parameters.AddWithValue("@NewPassword", newPassword);
                try
                {
                    connection.Open();
                    // Check if the old password is correct
                    int passwordMatchCount = (int)cmdCheckPassword.ExecuteScalar();
                    if (passwordMatchCount == 0)
                    {
                        // Old password is incorrect
                        return false;
                    }
                    // Update to the new password
                    int rowsAffected = cmdUpdatePassword.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
                catch (SqlException ex)
                {
                    Console.WriteLine($"UpdatePassword: SQL Error -> {ex.Message}");
                    return false;
                }
            }
        }
        public static int AddNewUser(int personID, string userName, string password, bool isActive)
        {
            int userID = -1;
            string query = @"INSERT INTO Users (PersonID, UserName, Password, IsActive) 
                             OUTPUT INSERTED.UserID
                             VALUES (@PersonID, @UserName, @Password, @IsActive);";
            using (SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@PersonID", personID);
                cmd.Parameters.AddWithValue("@UserName", userName);
                cmd.Parameters.AddWithValue("@Password", password);
                cmd.Parameters.AddWithValue("@IsActive", isActive);
                try
                {
                    connection.Open();
                    object queryResult = cmd.ExecuteScalar();
                    if (queryResult != null && int.TryParse(queryResult.ToString(), out int newPersonID)) userID = newPersonID;
                }
                catch (SqlException ex)
                {
                    Console.WriteLine($"Add New User: SQL Error -> {ex.Message}");
                    throw ex;
                }
            }
            return userID;
        }
        public static bool DeleteUserByID(int userID)
        {
            int rowAffected = 0;
            string query = "DELETE Users WHERE UserID = @UserID";
            using (SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@UserID", userID);
                try
                {
                    connection.Open();
                    rowAffected = cmd.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    Console.WriteLine($"DeleteUserByID: SQL Error -> {ex.Message}");
                }
            }
            return rowAffected > 0;
        }
    }
}
