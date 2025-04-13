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
        public static bool FindBy(int testAppointmentID, ref int testTypeID, ref int lDLAppID, ref DateTime appointmentDate, ref decimal paidFees, ref int createdByUserID, ref bool isLocked, ref int retakeTestApplicationID)
        {
            bool isFound = false;
            string query = @"SELECT TestAppointmentID, TestTypeID, LocalDrivingLicenseApplicationID, AppointmentDate, PaidFees, CreatedByUserID, IsLocked, RetakeTestApplicationID
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
                        lDLAppID = (int)reader["LocalDrivingLicenseApplicationID"];
                        appointmentDate = (DateTime)reader["AppointmentDate"];
                        paidFees = (decimal)reader["PaidFees"];
                        createdByUserID = (int)reader["CreatedByUserID"];
                        isLocked = (bool)reader["IsLocked"];
                        retakeTestApplicationID = reader["RetakeTestApplicationID"] != DBNull.Value ? (int)reader["RetakeTestApplicationID"] : -1;
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
        public static int AddTestAppointment(int testTypeID, int lDLAppID, DateTime appointmentDate, decimal paidFees, int createdByUserID, bool isLocked, int retakeTestApplicationID)
        {
            string query = @"INSERT INTO TestAppointments (TestTypeID, LocalDrivingLicenseApplicationID, AppointmentDate, PaidFees, CreatedByUserID, IsLocked, RetakeTestApplicationID)
                             VALUES (@TestTypeID, @LDLAppID, @AppointmentDate, @PaidFees, @CreatedByUserID, @IsLocked, @RetakeTestApplicationID);
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
                if (retakeTestApplicationID != -1)
                {
                    command.Parameters.AddWithValue("@RetakeTestApplicationID", retakeTestApplicationID);
                }
                else
                {
                    command.Parameters.AddWithValue("@RetakeTestApplicationID", DBNull.Value);
                }

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
        public static bool DoesActiveTestAppointmentExist(int testTypeID, int lDlAppID)
        {
            string query = @"SELECT COUNT(*) FROM TestAppointments 
                             WHERE TestTypeID = @TestTypeID 
                             AND LocalDrivingLicenseApplicationID = @LDLAppID AND IsLocked = 0;";
            using (SqlConnection sqlConnection = new SqlConnection(DatabaseHelper.ConnectionString))
            using (SqlCommand command = new SqlCommand(query, sqlConnection))
            {
                command.Parameters.Add(DatabaseHelper.CreateParameter("@TestTypeID", SqlDbType.Int, testTypeID));
                command.Parameters.Add(DatabaseHelper.CreateParameter("LDLAppID", SqlDbType.Int, lDlAppID));
                try
                {
                    sqlConnection.Open();
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
                catch (SqlException ex)
                {
                    Console.WriteLine($"TestAppointmentDAL DoesActiveTestAppointmentExist : SQL Error -> {ex.Message}");
                    return false;
                }
            }
        }
        public static bool DoesTestAppointmentExist(int testAppointmentID)
        {
            string query = @"SELECT COUNT(*) FROM TestAppointments 
                             WHERE TestAppointmentID = @TestAppointmentID";
            using (SqlConnection sqlConnection = new SqlConnection(DatabaseHelper.ConnectionString))
            using (SqlCommand command = new SqlCommand(query, sqlConnection))
            {
                command.Parameters.Add(DatabaseHelper.CreateParameter("@TestAppointmentID", SqlDbType.Int, testAppointmentID));
                try
                {
                    sqlConnection.Open();
                    object result = command.ExecuteScalar();
                    if (result is int testAppointmentExists && testAppointmentExists > 0)
                    {
                        return true;
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine($"TestAppointmentDAL DoesActiveTestAppointmentExist : SQL Error -> {ex.Message}");
                }
            }
            return false;

        }
        public static bool GetTestAppointmentLockedStatus(int testAppointmentID)
        {
            string query = @"SELECT Top 1 IsLocked FROM TestAppointments 
                             WHERE TestAppointmentID = @TestAppointmentID";
            using (SqlConnection sqlConnection = new SqlConnection(DatabaseHelper.ConnectionString))
            using (SqlCommand command = new SqlCommand(query, sqlConnection))
            {
                command.Parameters.Add(DatabaseHelper.CreateParameter("@TestAppointmentID", SqlDbType.Int, testAppointmentID));
                try
                {
                    sqlConnection.Open();
                    object result = command.ExecuteScalar();
                    if (result is bool isLocked)
                    {
                        return isLocked;
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine($"TestAppointmentDAL GetTestAppointmentLockedStatus  : SQL Error -> {ex.Message}");
                }
            }
            return false;
        }
        public static int GetLatestAppointmentIDBy(int testTypeID, int lDlAppID, bool isLocked)
        {
            string query = @"SELECT TOP 1 TestAppointmentID FROM TestAppointments 
                             WHERE TestTypeID = @TestTypeID
                             AND LocalDrivingLicenseApplicationID = @LDLAppID AND IsLocked = @IsLocked
                             ORDER BY TestAppointmentID DESC;";
            using (SqlConnection sqlConnection = new SqlConnection(DatabaseHelper.ConnectionString))
            using (SqlCommand command = new SqlCommand(query, sqlConnection))
            {
                command.Parameters.Add(DatabaseHelper.CreateParameter("@TestTypeID", SqlDbType.Int, testTypeID));
                command.Parameters.Add(DatabaseHelper.CreateParameter("@LDLAppID", SqlDbType.Int, lDlAppID));
                command.Parameters.Add(DatabaseHelper.CreateParameter("@IsLocked", SqlDbType.Bit, isLocked));
                try
                {
                    sqlConnection.Open();
                    object result = command.ExecuteScalar();
                    if (result is int latestAppointmentID)
                    {
                        return latestAppointmentID;
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine($"TestAppointmentDAL GetLatestAppointmentID : SQL Error -> {ex.Message}");
                }
            }
            return -1;
        }
    }
}
