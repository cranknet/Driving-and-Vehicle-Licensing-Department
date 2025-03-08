using System;
using System.Data;
using System.Data.SqlClient;
namespace DVLD_Data
{
    public class ApplicationTypeDAL
    {
        public static DataTable GetApplicationTypes()
        {
            DataTable dt = new DataTable();
            string query = @"SELECT * FROM ApplicationTypes;";
            using (SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        dt.Load(reader);
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine($"GetAppplicationTypes: SQL Error -> {ex.Message}");
                }
            }
            return dt;
        }
        public static bool Update(int applicationID, string applicationTypeTitle, decimal applicationFees)
        {
            int rowAffected = 0;
            string query = @"UPDATE ApplicationTypes SET ApplicationTypeTitle = @ApplicationTypeTitle, ApplicationFees = @ApplicationFees WHERE ApplicationTypeID = @ApplicationTypeID;";
            using (SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@ApplicationTypeID", applicationID);
                command.Parameters.AddWithValue("@ApplicationTypeTitle", applicationTypeTitle);
                command.Parameters.AddWithValue("@ApplicationFees", applicationFees);
                try
                {
                    connection.Open();
                    rowAffected = command.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    Console.WriteLine($"UpdateApplicationType: SQL Error -> {ex.Message}");
                }
            }
            return rowAffected > 0;
        }
        public static bool FindByID(int applicationTypeID, ref string applicationTypeTitle, ref decimal applicationFees)
        {
            bool isFound = false;
            string query = @"SELECT ApplicationTypeTitle, ApplicationFees FROM ApplicationTypes WHERE ApplicationTypeID = @ApplicationTypeID;";
            using (SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@ApplicationTypeID", applicationTypeID);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        isFound = true;
                        applicationTypeTitle = (string)reader["ApplicationTypeTitle"];
                        applicationFees = (decimal)reader["ApplicationFees"];
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine($"FindApplicationTypeByID: SQL Error -> {ex.Message}");
                }
            }
            return isFound;
        }
    }
}
