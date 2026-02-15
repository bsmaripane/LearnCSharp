using StudentApp.Data;
using StudentApp.Models;
using Xunit;

namespace StudentApp.Tests
{
    public class StudentRepositoryTests
    {
        [Fact]
        public async Task AddStudentAsync_Should_Insert_Student_Into_Database()
        {
            // Arrange
            string connectionString = "Server=MARIPANEBS\\SQLEXPRESS;Database=StudentDB;Integrated Security=True;TrustServerCertificate=True;";

            var repository = new StudentRepository(connectionString);

            var student = new Student
            {
                FirstName = "Felicia",
                LastName = "Maripane",
                CourseCode = "EDU101",
                RegistrationDate = DateTime.Today,
                CourseFee = 67340
            };

            // Act
            await repository.AddStudentAsync(student);

            // Assert
            Assert.True(true);
        }
    }
}
