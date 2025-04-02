using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_Data
{
    public class TestAppointmentDAL
    {
        public static DataTable GetAllTestAppointments(int testTypeID, int ldlAppID)
        {
            string query = @"SELECT TestAppointmentID, AppointmentDate, PaidFees, IsLocked  FROM TestAppointments
                             WHERE TestTypeID = @TestTypeID AND LocalDrivingLicenseApplicationID = @LDLAppID";
            using (SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@TestTypeID", testTypeID);
                cmd.Parameters.AddWithValue("@LDLAppID", ldlAppID);
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

        public static bool FindBy(int testAppointmentID, ref int testTypeID, ref int lDLAppID, ref DateTime appointmentDate, ref double paidFees, ref int createdByUserID, ref bool isLocked)
        {
            bool isFound = false;
            string query = @"SELECT TestAppointmentID, TestTypeID, LocalDrivingLicenseApplicationID, AppointmentDate, PaidFees, CreatedByUserID, IsLocked
                             FROM TestAppointments
                             WHERE TestAppointmentID = @TestAppointmentID";
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
                        testAppointmentID = (int)reader["TestAppointmentID"];
                        testTypeID = (int)reader["TestTypeID"];
                        lDLAppID = (int)reader["LDLAppID"];
                        appointmentDate = (DateTime)reader["AppointmentDate"];
                        paidFees = (double)reader["PaidFees"];
                        createdByUserID = (int)reader["CreatedByUserID"];
                        isLocked = (bool)reader["IsLocked"];
                    }
                    else
                    {
                        isFound = false;
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine($"TestAppointmentDAL FindBy By : SQL Error -> {ex.Message}");
                }
            }
            return isFound;
        }
        public static int AddTestAppointment(int testTypeID, int lDLAppID, DateTime appointmentDate, double paidFees, int createdByUserID, bool isLocked)
        {
            string query = @"INSERT INTO TestAppointments (TestTypeID, LocalDrivingLicenseApplicationID, AppointmentDate, PaidFees, CreatedByUserID, IsLocked)
                             VALUES (@TestTypeID, @LDLAppID, @AppointmentDate, @PaidFees, @CreatedByUserID, @IsLocked);
                             SELECT SCOPE_IDENTITY();";
            using (SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@TestTypeID", testTypeID);
                command.Parameters.AddWithValue("@LDLAppID", lDLAppID);
                command.Parameters.AddWithValue("@AppointmentDate", appointmentDate);
                command.Parameters.AddWithValue("@PaidFees", paidFees);
                command.Parameters.AddWithValue("@CreatedByUserID", createdByUserID);
                command.Parameters.AddWithValue("@IsLocked", isLocked);
                try
                {
                    connection.Open();
                    return Convert.ToInt32(command.ExecuteScalar());
                }
                catch (SqlException ex)
                {
                    Console.WriteLine($"TestAppointmentDAL AddTestAppointment : SQL Error -> {ex.Message}");
                }
            }
            return -1;
        }
        public static bool UpdateTestAppointmentDate(int testAppointmentID, DateTime appointmentDate)
        {
            string query = @"UPDATE TestAppointments
                             SET AppointmentDate = @AppointmentDate
                             WHERE TestAppointmentID = @TestAppointmentID";
            using (SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@AppointmentDate", appointmentDate);
                command.Parameters.AddWithValue("@TestAppointmentID", testAppointmentID);
                try
                {
                    connection.Open();
                    int affectedRow = command.ExecuteNonQuery();
                    return affectedRow > 0;
                }
                catch (SqlException ex)
                {
                    Console.WriteLine($"TestAppointmentDAL UpdateTestAppointmentDate : SQL Error -> {ex.Message}");
                }
            }
            return false;
        }
        public static bool LockAppointment(int testAppointmentID)
        {
            string query = @"UPDATE TestAppointments
                             SET IsLocked = 1
                             WHERE TestAppointmentID = @TestAppointmentID";
            using (SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@TestAppointmentID", testAppointmentID);
                try
                {
                    connection.Open();
                    int affectedRow = command.ExecuteNonQuery();
                    return affectedRow > 0;
                }
                catch (SqlException ex)
                {
                    Console.WriteLine($"TestAppointmentDAL LockAppointment : SQL Error -> {ex.Message}");
                }
            }
            return false;
        }
    }
}
