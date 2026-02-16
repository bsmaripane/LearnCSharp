using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentApp.Models;

namespace StudentApp.Data
{
    public interface IStudentRepository
    {
        Task AddStudentAsync(Student student);
        Task<Student?> GetStudentByNameAsync(string firstName, string lastName);
        Task<List<Student>> GetAllStudentsAsync();
        Task DeleteStudentByNameAsync(string firstName, string lastName);
    }
}
