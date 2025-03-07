using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_Data
{
    public class ApplicationTypesDAL
    {
        public static DataTable GetApplicationTypes()
        {
            DataTable dt = new DataTable();
            string query = @"SELECT * FROM ApplicationTypes;";
            using (SqlConnection connection = new SqlConnection(clsDatabaseHelper.ConnectionString))
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
    }
}
