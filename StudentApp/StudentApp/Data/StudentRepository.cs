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
    }
}
