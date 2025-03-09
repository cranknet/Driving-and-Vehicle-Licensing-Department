using System;
using System.Data;
using System.Data.SqlClient;
namespace DVLD_Data
{
    public class DriverDAL
    {
        public static DataTable GetAllDrivers()
        {
            string query = @"SELECT Drivers.DriverID, Drivers.PersonID, People.NationalNo, 
                             CONCAT(People.FirstName, ' ', People.LastName ) AS FullName,
                             Drivers.CreatedDate AS Date FROM Drivers
                             JOIN People ON People.PersonID = Drivers.PersonID;";
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
                    Console.WriteLine($"GetAllDrivers: Error getting drivers: {ex.Message}");
                }
            }
            return null;
        }
        public static bool FindByID(int driverID, ref int personID, ref int createdByUserID, ref DateTime createdDate)
        {
            bool isFound = true;
            string query = @"SELECT * FROM Drivers Where DriverID = @DriverID";
            using (SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@DriverID", driverID);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        isFound = true;
                        personID = (int)reader["PersonID"];
                        createdByUserID = (int)reader["CreatedByUserID"];
                        createdDate = (DateTime)reader["CreatedDate"];
                    }
                    else
                    {
                        isFound = false;
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine($"DriverDAL FindBy By : SQL Error -> {ex.Message}");
                }
            }
            return isFound;
        }
    }
}
