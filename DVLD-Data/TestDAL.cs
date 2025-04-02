using System;
using System.Data.SqlClient;
namespace DVLD_Data
{
    public class TestDAL
    {
        public static bool FindByTestID(int testID, ref int testAppointmentID, ref bool testResult, ref string notes, ref int createdByUserID)
        {
            bool isFound = false;
            string query = @"SELECT TestID, TestAppointmentID ,TestResult , Notes ,CreatedByUserID 
                             FROM Tests 
                             WHERE TestID = @TestID;";
            using (SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@TestID", testID);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        isFound = true;
                        testID = (int)reader["TestID"];
                        testAppointmentID = (int)reader["TestAppointmentID"];
                        testResult = (bool)reader["TestResult"];
                        notes = reader["Notes"] as string ?? "No notes available!";
                        createdByUserID = (int)reader["CreatedByUserID"];
                    }
                    else
                    {
                        isFound = false;
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine($"TestDAL FindBy : SQL Error -> {ex.Message}");
                }
            }
            return isFound;
        }
        public static bool FindByTestAppointmentID(int testAppointmentID, ref int testID, ref bool testResult, ref string notes, ref int createdByUserID)
        {
            bool isFound = false;
            string query = @"SELECT TestID, TestAppointmentID ,TestResult , Notes ,CreatedByUserID 
                             FROM Tests 
                             WHERE TestAppointmentID = @TestAppointmentID;";
            using (SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@TestAppointmentID", testAppointmentID);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        isFound = true;
                        testID = (int)reader["TestID"];
                        testAppointmentID = (int)reader["TestAppointmentID"];
                        testResult = (bool)reader["TestResult"];
                        notes = reader["Notes"] as string ?? "No notes available!";
                        createdByUserID = (int)reader["CreatedByUserID"];
                    }
                    else
                    {
                        isFound = false;
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine($"TestDAL FindBy : SQL Error -> {ex.Message}");
                }
            }
            return isFound;
        }
        public static int AddTest(int testAppointmentID, bool testResult, string notes, int createdByUserID)
        {
            int testID = -1;
            string query = @"INSERT INTO Tests (TestAppointmentID, TestResult, Notes, CreatedByUserID) 
                             VALUES (@TestAppointmentID, @TestResult, @Notes, @CreatedByUserID); 
                             SELECT SCOPE_IDENTITY();";
            using (SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@TestAppointmentID", testAppointmentID);
                command.Parameters.AddWithValue("@TestResult", testResult);
                command.Parameters.AddWithValue("@Notes", notes);
                command.Parameters.AddWithValue("@CreatedByUserID", createdByUserID);
                try
                {
                    connection.Open();
                    testID = Convert.ToInt32(command.ExecuteScalar());
                }
                catch (SqlException ex)
                {
                    Console.WriteLine($"TestDAL AddTest : SQL Error -> {ex.Message}");
                }
            }
            return testID;
        }
        public static bool UpdateTest(int testID, bool testResult, string notes)
        {
            string query = @"UPDATE Tests 
                             SET TestResult = @TestResult, Notes = @Notes
                             WHERE TestID = @TestID;";
            using (SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@TestID", testID);
                command.Parameters.AddWithValue("@TestResult", testResult);
                command.Parameters.AddWithValue("@Notes", notes);
                try
                {
                    connection.Open();
                    int rowAffected = command.ExecuteNonQuery();
                    return rowAffected > 0;
                }
                catch (SqlException ex)
                {
                    Console.WriteLine($"TestDAL UpdateTest : SQL Error -> {ex.Message}");
                }
            }
            return false;
        }
    }
}
