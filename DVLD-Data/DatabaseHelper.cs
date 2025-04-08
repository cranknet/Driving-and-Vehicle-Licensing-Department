using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_Data
{
    public class DatabaseHelper
    {
        public static readonly string ConnectionString = "Server=.;Database=DVLD;User Id=sa;Password=123456;";
        public static SqlParameter CreateParameter(string name, SqlDbType type, object value)
        {
            return new SqlParameter(name, type)
            {
                Value = value ?? DBNull.Value
            };
        }
    }
}
