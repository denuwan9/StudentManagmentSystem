using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using StudentManagementSystem.Data;
using StudentManagementSystem.Models;

namespace StudentManagementSystem.Repositories
{
    public class StudentRepository
    {
        private readonly DatabaseConnection _dbConnection;

        public StudentRepository()
        {
            _dbConnection = new DatabaseConnection();
        }

        public bool InsertStudent(Student student)
        {
            try
            {
                using (SqlConnection connection = _dbConnection.GetConnection())
                {
                    connection.Open();
                    string query = @"INSERT INTO Registration 
                        (regNo, firstName, lastName, dateOfBirth, gender, address, email, 
                         mobilePhone, homePhone, parentName, nic, contactNo) 
                        VALUES 
                        (@regNo, @firstName, @lastName, @dateOfBirth, @gender, @address, @email, 
                         @mobilePhone, @homePhone, @parentName, @nic, @contactNo)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@regNo", student.RegNo);
                        command.Parameters.AddWithValue("@firstName", student.FirstName);
                        command.Parameters.AddWithValue("@lastName", student.LastName);
                        command.Parameters.AddWithValue("@dateOfBirth", student.DateOfBirth);
                        command.Parameters.AddWithValue("@gender", student.Gender);
                        command.Parameters.AddWithValue("@address", student.Address);
                        command.Parameters.AddWithValue("@email", student.Email);
                        command.Parameters.AddWithValue("@mobilePhone", student.MobilePhone);
                        command.Parameters.AddWithValue("@homePhone", student.HomePhone);
                        command.Parameters.AddWithValue("@parentName", student.ParentName);
                        command.Parameters.AddWithValue("@nic", student.NIC);
                        command.Parameters.AddWithValue("@contactNo", student.ContactNo);

                        command.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool UpdateStudent(Student student)
        {
            try
            {
                using (SqlConnection connection = _dbConnection.GetConnection())
                {
                    connection.Open();
                    string query = @"UPDATE Registration SET 
                        firstName = @firstName, lastName = @lastName, dateOfBirth = @dateOfBirth, 
                        gender = @gender, address = @address, email = @email, 
                        mobilePhone = @mobilePhone, homePhone = @homePhone, 
                        parentName = @parentName, nic = @nic, contactNo = @contactNo 
                        WHERE regNo = @regNo";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@regNo", student.RegNo);
                        command.Parameters.AddWithValue("@firstName", student.FirstName);
                        command.Parameters.AddWithValue("@lastName", student.LastName);
                        command.Parameters.AddWithValue("@dateOfBirth", student.DateOfBirth);
                        command.Parameters.AddWithValue("@gender", student.Gender);
                        command.Parameters.AddWithValue("@address", student.Address);
                        command.Parameters.AddWithValue("@email", student.Email);
                        command.Parameters.AddWithValue("@mobilePhone", student.MobilePhone);
                        command.Parameters.AddWithValue("@homePhone", student.HomePhone);
                        command.Parameters.AddWithValue("@parentName", student.ParentName);
                        command.Parameters.AddWithValue("@nic", student.NIC);
                        command.Parameters.AddWithValue("@contactNo", student.ContactNo);

                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool DeleteStudent(int regNo)
        {
            try
            {
                using (SqlConnection connection = _dbConnection.GetConnection())
                {
                    connection.Open();
                    string query = "DELETE FROM Registration WHERE regNo = @regNo";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@regNo", regNo);
                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public Student? GetStudentByRegNo(int regNo)
        {
            Student? student = null;
            try
            {
                using (SqlConnection connection = _dbConnection.GetConnection())
                {
                    connection.Open();
                    string query = "SELECT * FROM Registration WHERE regNo = @regNo";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@regNo", regNo);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                student = new Student
                                {
                                    RegNo = reader["regNo"] != DBNull.Value ? Convert.ToInt32(reader["regNo"]) : 0,
                                    FirstName = reader["firstName"] as string ?? string.Empty,
                                    LastName = reader["lastName"] as string ?? string.Empty,
                                    DateOfBirth = reader["dateOfBirth"] != DBNull.Value ? Convert.ToDateTime(reader["dateOfBirth"]) : DateTime.MinValue,
                                    Gender = reader["gender"] as string ?? string.Empty,
                                    Address = reader["address"] as string ?? string.Empty,
                                    Email = reader["email"] as string ?? string.Empty,
                                    MobilePhone = reader["mobilePhone"] != DBNull.Value ? Convert.ToInt32(reader["mobilePhone"]) : 0,
                                    HomePhone = reader["homePhone"] != DBNull.Value ? Convert.ToInt32(reader["homePhone"]) : 0,
                                    ParentName = reader["parentName"] as string ?? string.Empty,
                                    NIC = reader["nic"] as string ?? string.Empty,
                                    ContactNo = reader["contactNo"] != DBNull.Value ? Convert.ToInt32(reader["contactNo"]) : 0
                                };
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return student;
        }

        public List<int> GetAllRegistrationNumbers()
        {
            List<int> regNumbers = new List<int>();
            try
            {
                using (SqlConnection connection = _dbConnection.GetConnection())
                {
                    connection.Open();
                    string query = "SELECT regNo FROM Registration ORDER BY regNo";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                regNumbers.Add(Convert.ToInt32(reader["regNo"]));
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return regNumbers;
        }
    }
}


