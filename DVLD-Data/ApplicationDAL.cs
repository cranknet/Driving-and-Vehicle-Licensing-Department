using System;
using System.Data;
using System.Data.SqlClient;
namespace DVLD_Data
{
    public class ApplicationDAL
    {
        public static DataTable GetApplications()
        {
            DataTable dt = new DataTable();
            string query = @"SELECT ApplicationID, ApplicantPersonID, ApplicationDate, ApplicationTypeID, ApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID
                                 FROM Applications";
            using (SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                try
                {
                    connection.Open();
                    dt.Load(cmd.ExecuteReader());
                    return dt;
                }
                catch (SqlException ex)
                {
                    Console.WriteLine($"GetApplications: Error getting applications: {ex.Message}");
                }
            }
            return null;
        }
        public static bool Find(int applicationID, ref int applicantPersonID, ref DateTime applicationDate, ref int applicationTypeID, ref int applicationStatus, ref DateTime lastStatusDate, ref decimal paidFees, ref int createdByUserID)
        {
            bool isFound = false;
            string query = @"SELECT ApplicationID, ApplicantPersonID, ApplicationDate, ApplicationTypeID, ApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID 
                                 FROM Applications
                                 WHERE ApplicationID = @ApplicationID";
            using (SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@ApplicationID", applicationID);
                try
                {
                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        isFound = true;
                        applicationID = (int)reader["ApplicationID"];
                        applicantPersonID = (int)reader["ApplicantPersonID"];
                        applicationDate = (DateTime)reader["ApplicationDate"];
                        applicationTypeID = (int)reader["ApplicationTypeID"];
                        applicationStatus = (int)reader["ApplicationStatus"];
                        lastStatusDate = (DateTime)reader["LastStatusDate"];
                        paidFees = (decimal)reader["PaidFees"];
                        createdByUserID = (int)reader["CreatedByUserID"];
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine($"Find: Error finding application: {ex.Message}");
                }
            }
            return isFound;
        }
        public static int AddNewApplication(int applicantPersonID, DateTime applicationDate, int applicationTypeID, int applicationStatus, DateTime lastStatusDate, decimal paidFees, int createdByUserID)
        {
            string query = @"INSERT INTO Applications (ApplicantPersonID, ApplicationDate, ApplicationTypeID, ApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID)
                                 VALUES (@ApplicantPersonID, @ApplicationDate, @ApplicationTypeID, @ApplicationStatus, @LastStatusDate, @PaidFees, @CreatedByUserID);
                                 SELECT SCOPE_IDENTITY();";
            using (SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@ApplicantPersonID", applicantPersonID);
                cmd.Parameters.AddWithValue("@ApplicationDate", applicationDate);
                cmd.Parameters.AddWithValue("@ApplicationTypeID", applicationTypeID);
                cmd.Parameters.AddWithValue("@ApplicationStatus", applicationStatus);
                cmd.Parameters.AddWithValue("@LastStatusDate", lastStatusDate);
                cmd.Parameters.AddWithValue("@PaidFees", paidFees);
                cmd.Parameters.AddWithValue("@CreatedByUserID", createdByUserID);
                try
                {
                    connection.Open();
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
                catch (SqlException ex)
                {
                    Console.WriteLine($"AddNewApplication: Error adding new application: {ex.Message}");
                }
            }
            return -1;
        }
        public static bool UpdateApplicationStatus(int applicationID, int applicationStatus, DateTime lastStatusDate)
        {
            string query = @"UPDATE Applications
                                 SET ApplicationStatus = @ApplicationStatus, LastStatusDate = @LastStatusDate
                                 WHERE ApplicationID = @ApplicationID";
            using (SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@ApplicationID", applicationID);
                cmd.Parameters.AddWithValue("@ApplicationStatus", applicationStatus);
                cmd.Parameters.AddWithValue("@LastStatusDate", lastStatusDate);
                try
                {
                    connection.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
                catch (SqlException ex)
                {
                    Console.WriteLine($"UpdateApplicationStatus: Error updating application status: {ex.Message}");
                }
            }
            return false;
        }
        public static bool AddLocalLicenseApplication(int applicationType, int licenseClassID)
        {
            string query = @"INSERT INTO LocalDrivingLicenseApplications (ApplicationID, LicenseClassID)
                             OUTPUT INSERTED.ApplicationID
                             VALUES (@ApplicationID, @LicenseClassID)";
            using (SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@ApplicationID", applicationType);
                cmd.Parameters.AddWithValue("@LicenseClassID", licenseClassID);
                try
                {
                    connection.Open();
                    return (int)cmd.ExecuteScalar() > 0;
                }
                catch (SqlException ex)
                {
                    Console.WriteLine($"AddLocalLicenseApplication: Error adding new application: {ex.Message}");
                }
            }
            return false;
        }
    }
}
