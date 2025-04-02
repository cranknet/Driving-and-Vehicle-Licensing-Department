using System;
using System.Data;
using System.Data.SqlClient;
namespace DVLD_Data
{
    public class LicenseClassDAL
    {
        public static DataTable GetLicenseClasses()
        {
            string query = @"SELECT * FROM LicenseClasses";
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
                    Console.WriteLine($"GetLicenseClasses: Error getting license classes: {ex.Message}");
                }
            }
            return null;
        }
        public static bool Find(int licenseClassID, ref string ClassName, ref string classDescription, ref byte minimumAllowedAge, ref byte defaultValidityLength, ref decimal classFees)
        {
            bool isFound = false;
            string query = @"SELECT LicenseClassID, ClassName, ClassDescription, MinimumAllowedAge, DefaultValidityLength, ClassFees
                                  FROM LicenseClasses
                                  WHERE LicenseClassID = @LicenseClassID";
            using (SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@LicenseClassID", licenseClassID);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        isFound = true;
                        licenseClassID = (int)reader["LicenseClassID"];
                        ClassName = (string)reader["ClassName"];
                        classDescription = (string)reader["ClassDescription"];
                        minimumAllowedAge = (byte)reader["MinimumAllowedAge"];
                        defaultValidityLength = (byte)reader["DefaultValidityLength"];
                        classFees = (decimal)reader["ClassFees"];
                    }
                    else
                    {
                        isFound = false;
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine($"LicenseClassDAL FindBy By : SQL Error -> {ex.Message}");
                }
            }
            return isFound;
        }
    }
}
