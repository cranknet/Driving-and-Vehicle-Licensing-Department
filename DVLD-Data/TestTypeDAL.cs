using System;
using System.Data;
using System.Data.SqlClient;
namespace DVLD_Data
{
    public class TestTypeDAL
    {
        public static DataTable GetTestTypes()
        {
            string query = "SELECT * FROM TestTypes";
            using (SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                try
                {
                    connection.Open();
                    DataTable dt = new DataTable();
                    dt.Load(cmd.ExecuteReader());
                    return dt;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"GetTestTypes: Error getting test types: {ex.Message}");
                }
            }
            return null;
        }
        public static bool FindByID(int testTypeID, ref string testTypeTitle, ref string testTypeDescription, ref decimal testTypeFees)
        {
            bool isFound = true;
            string query = @"SELECT TestTypeID, TestTypeTitle, TestTypeDescription, TestTypeFees 
                             FROM TestTypes
                             WHERE TestTypeID = @TestTypeID";
            using (SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@TestTypeID", testTypeID);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        isFound = true;
                        testTypeID = (int)reader["TestTypeTitle"];
                        testTypeTitle = (string)reader["TestTypeName"];
                        testTypeDescription = (string)(reader["TestTypeDescription"]);
                        testTypeFees = (decimal)(reader["TestTypeFees"]);
                    }
                    else
                    {
                        isFound = false;
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine($"TestTypeDAL FindBy By : SQL Error -> {ex.Message}");
                }
            }
            return isFound;
        }
        public static bool Update(int testTypeID, string testTypeTitle, string testTypeDescription, decimal testTypeFees)
        {
            int rowAffected = 0;
            string query = @"UPDATE TestTypes 
                             SET TestTypeTitle = @TestTypeTitle, TestTypeDescription = @TestTypeDescription, TestTypeFees = @TestTypeFees 
                             WHERE TestTypeID = @TestTypeID";
            using (SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@TestTypeID", testTypeID);
                command.Parameters.AddWithValue("@TestTypeTitle", testTypeTitle);
                command.Parameters.AddWithValue("@TestTypeDescription", testTypeDescription);
                command.Parameters.AddWithValue("@TestTypeFees", testTypeFees);
                try
                {
                    connection.Open();
                    rowAffected = command.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    Console.WriteLine($"UpdateTestType: SQL Error -> {ex.Message}");
                }
            }
            return rowAffected > 0;
        }
    }
}
