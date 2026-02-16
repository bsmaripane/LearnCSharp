using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentApp.Models;
using StudentApp.Tests.Fakes;
using Xunit;


public class StudentServiceTests
{
    [Fact]
    public async Task FakeRepository_Should_Save_Student()
    {
        // Arrange
        var repository = new FakeStudentRepository();

        var student = new Student
        { 
            FirstName = "Mock",
            LastName = "Interface",
            CourseCode = "FAKE01",
            RegistrationDate = DateTime.Today,
            CourseFee = 0
        };

        // Act
        await repository.AddStudentAsync(student);
        var result = await repository.GetStudentByNameAsync("Mock", "Interface");

        // Assert
        Assert.NotNull(result);
        Assert.Equal("Mock", result!.FirstName);
        Assert.Equal("Interface", result!.LastName);
    }
}

