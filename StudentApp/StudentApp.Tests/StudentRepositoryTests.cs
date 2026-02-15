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
                FirstName = "Maxine",
                LastName = "van der Merwe",
                CourseCode = "EDU123",
                RegistrationDate = DateTime.Today,
                CourseFee = 65000
            };

            // Act
            await repository.AddStudentAsync(student);
            var savedStudent = await repository.GetStudentByNameAsync(
                student.FirstName,
                student.LastName);

            // Assert
            Assert.NotNull(savedStudent);
            Assert.Equal("Maxine", savedStudent.FirstName);
            Assert.Equal("van der Merwe", savedStudent.LastName);
        }
    }
}
