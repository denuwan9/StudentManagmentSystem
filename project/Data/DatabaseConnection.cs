using System;
using System.Configuration;
using System.Data.SqlClient;

namespace StudentManagementSystem.Data
{
    public class DatabaseConnection
    {
        private string connectionString;

        public DatabaseConnection()
        {
            // Try to get connection string from App.config, otherwise use default
            try
            {
                connectionString = ConfigurationManager.ConnectionStrings["StudentDBConnection"]?.ConnectionString 
                    ?? @"Data Source=DESKTOP-H2JFJE5\SQLEXPRESS;Initial Catalog=Student;Integrated Security=True;TrustServerCertificate=True";
            }
            catch
            {
                // Fallback connection string
                connectionString = @"Data Source=DESKTOP-H2JFJE5\SQLEXPRESS;Initial Catalog=Student;Integrated Security=True;TrustServerCertificate=True";
            }
        }

        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        public string ConnectionString => connectionString;
    }
}


