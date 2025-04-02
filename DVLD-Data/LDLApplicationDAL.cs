using System;
using System.Data;
using System.Data.SqlClient;
namespace DVLD_Data
{
    public class LDLApplicationDAL
    {
        public static DataTable GetLDLApplications()
        {
            DataTable dt = new DataTable();
            string query = @"SELECT LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID AS LDLApplicationID, LicenseClasses.ClassName, People.NationalNo, CONCAT(People.FirstName,' ', People.LastName) AS FullName , Applications.ApplicationDate, 
                             CASE   Applications.ApplicationStatus 
                             	   WHEN 1 THEN 'New'
                             	   WHEN 2 THEN 'Cancelled'
                             	   WHEN 3 THEN 'Completed'
                             	   ELSE 'None'
                             END AS Status
                             FROM   LocalDrivingLicenseApplications INNER JOIN Applications ON LocalDrivingLicenseApplications.ApplicationID = Applications.ApplicationID
				             INNER JOIN LicenseClasses ON LocalDrivingLicenseApplications.LicenseClassID = LicenseClasses.LicenseClassID
				             INNER JOIN People ON Applications.ApplicantPersonID = People.PersonID;";
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
                    Console.WriteLine($"GetLDLApplications: Error getting applications: {ex.Message}");
                }
            }
            return null;
        }
        public static int GetActiveLDLApplicationIDForLicenseClass(int personID, int licenseClassID, int applicationStatus)
        {
            const string query = @" SELECT TOP 1 a.ApplicationID FROM Applications a
                                    JOIN LocalDrivingLicenseApplications l 
                                        ON a.ApplicationID = l.ApplicationID
                                    WHERE a.ApplicantPersonID = @PersonID 
                                        AND l.LicenseClassID = @LicenseClassID 
                                        AND a.ApplicationStatus = @ApplicationStatus;";
            using (SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@PersonID", personID);
                command.Parameters.AddWithValue("@LicenseClassID", licenseClassID);
                command.Parameters.AddWithValue("@ApplicationStatus", applicationStatus);
                connection.Open();
                object result = command.ExecuteScalar();
                return result != null ? Convert.ToInt32(result) : -1;
            }
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
        public static bool FindBy(int ldlApplicationID, ref int licenseClassID, ref int applicationID)
        {
            bool isFound = false;
            string query = @"SELECT ApplicationID, LicenseClassID
                             FROM LocalDrivingLicenseApplications
                             WHERE LocalDrivingLicenseApplicationID = @LDLApplicationID";
            using (SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@LDLApplicationID", ldlApplicationID);
                try
                {
                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        isFound = true;
                        applicationID = (int)reader["ApplicationID"];
                        licenseClassID = (int)reader["LicenseClassID"];
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine($"FindBy: Error finding application: {ex.Message}");
                }
            }
            return isFound;
        }
        public static int AddNewLDLApplication(int licenseClassID, int applicationID)
        {
            string query = @"INSERT INTO LocalDrivingLicenseApplications (LicenseClassID, ApplicationID)
                             OUTPUT INSERTED.LocalDrivingLicenseApplicationID
                             VALUES (@LicenseClassID, @ApplicationID)";
            using (SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@LicenseClassID", licenseClassID);
                cmd.Parameters.AddWithValue("@ApplicationID", applicationID);
                try
                {
                    connection.Open();
                    int result = (int)cmd.ExecuteScalar();
                    return result;
                }
                catch (SqlException ex)
                {
                    Console.WriteLine($"AddNewLDLApplication: Error adding new application: {ex.Message}");
                }
                return -1;
            }
        }
        public static bool UpdateLDLApplication(int ldlApplicationID, int licenseClassID, int applicationID)
        {
            string query = @"UPDATE LocalDrivingLicenseApplications
                             SET LicenseClassID = @LicenseClassID, ApplicationID = @ApplicationID
                             WHERE LocalDrivingLicenseApplicationID = @LDLApplicationID";
            using (SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@LDLApplicationID", ldlApplicationID);
                cmd.Parameters.AddWithValue("@LicenseClassID", licenseClassID);
                cmd.Parameters.AddWithValue("@ApplicationID", applicationID);
                try
                {
                    connection.Open();
                    int rowAffected = cmd.ExecuteNonQuery();
                    return rowAffected > 0;
                }
                catch (SqlException ex)
                {
                    Console.WriteLine($"UpdateLDLApplication: Error updating application: {ex.Message}");
                }
            }
            return false;
        }
    }
}
