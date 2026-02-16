using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using StudentApp.Models;

namespace StudentApp.Data
{
    public class StudentRepository
    {
        private readonly string _connectionString;

        public StudentRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public async Task AddStudentAsync(Student student)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string sql = @"
                        INSERT INTO Students
                        (FirstName, LastName, CourseCode, RegistrationDate, CourseFee)
                        VALUES (@FirstName, @LastName, @CourseCode, @RegistrationDate, @CourseFee)";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@FirstName", student.FirstName);
                    command.Parameters.AddWithValue("@LastName", student.LastName);
                    command.Parameters.AddWithValue("@CourseCode", student.CourseCode);
                    command.Parameters.AddWithValue("@RegistrationDate", student.RegistrationDate);
                    command.Parameters.AddWithValue("@CourseFee", student.CourseFee);

                    await connection.OpenAsync();
                    await command.ExecuteNonQueryAsync();
                }
            }
        }

        public async Task<Student?> GetStudentByNameAsync(string firstName, string lastName)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string sql = @"
                            SELECT TOP 1 * 
                            FROM Students
                            WHERE FirstName = @FirstName AND LastName = @LastName";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@FirstName", firstName);
                    command.Parameters.AddWithValue("@LastName", lastName);

                    await connection.OpenAsync();

                    using (SqlDataReader reader = await command.ExecuteReaderAsync())
                    {
                        if (await reader.ReadAsync())
                        {
                            return new Student
                            {
                                StudentID = (int)reader["StudentID"],
                                FirstName = reader["FirstName"].ToString()!,
                                LastName = reader["LastName"].ToString()!,
                                CourseCode = reader["CourseCode"].ToString()!,
                                RegistrationDate = (DateTime)reader["RegistrationDate"],
                                CourseFee = (decimal)reader["CourseFee"]
                            };
                        }
                    }
                }
            }
            return null;
        }

        public async Task DeleteStudentByNameAsync(string firstName, string lastName)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string sql = @"
                            DELETE FROM Students
                            WHERE FirstName = @FirstName AND LastName = @LastName";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@FirstName", firstName);
                    command.Parameters.AddWithValue("@LastName", lastName);

                    await connection.OpenAsync();
                    await command.ExecuteNonQueryAsync();
                }
            }
        }
    }
}
