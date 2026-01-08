using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using StudentManagementSystem.Data;

namespace StudentManagementSystem.Repositories
{
    public class UserRepository
    {
        private readonly DatabaseConnection _dbConnection;

        public UserRepository()
        {
            _dbConnection = new DatabaseConnection();
        }

        public bool ValidateLogin(string username, string password)
        {
            // Default credentials check (for backward compatibility)
            if (username == "Admin" && password == "Skills@123")
            {
                return true;
            }

            try
            {
                using (SqlConnection connection = _dbConnection.GetConnection())
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM Users WHERE username = @username AND password = @password";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", password);

                        int count = Convert.ToInt32(command.ExecuteScalar());
                        return count > 0;
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (Exception)
            {
                // If database doesn't exist or table doesn't exist, fall back to default credentials
                if (username == "Admin" && password == "Skills@123")
                {
                    return true;
                }
                return false;
            }
        }
    }
}


