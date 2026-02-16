using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentApp.Data;
using StudentApp.Models;

namespace StudentApp.Tests.Fakes
{
    public class FakeStudentRepository : IStudentRepository
    {
        private readonly List<Student> _students = new();

        public Task AddStudentAsync(Student student)
        {
            _students.Add(student);

            return Task.CompletedTask;
        }

        public Task<Student> GetStudentByNameAsync(string firstName, string lastName)
        {
            var student = _students.FirstOrDefault(s => s.FirstName == firstName && s.LastName == lastName);

            return Task.FromResult(student);
        }

        public Task<List<Student>> GetAllStudentsAsync()
        {
            return Task.FromResult(_students);
        }

        public Task DeleteStudentByNameAsync(string firstName, string lastName)
        {
            var student = _students.FirstOrDefault(s => s.FirstName == firstName && s.LastName == lastName);

            if (student != null)
                _students.Remove(student);

            return Task.CompletedTask;
        }
    }
}
