using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_Data
{
    public class CountryDAL
    {
        public static DataTable GetCountries()
        {
            DataTable dt = new DataTable();
            string query = "SELECT CountryID, CountryName FROM Countries";
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
                    Console.WriteLine($"Country List: SQL Error -> {ex.Message}");
                }
            }
            return dt;
        }
    }
}
