using System;
using System.Collections.Generic;
using System.Text;

namespace LINQ_With_Lists
{
    internal class UniversityManager
    {
        public List<University> universities;
        public List<Student> students;

        // constructor
        public UniversityManager()
        {
            universities = new List<University>();
            students = new List<Student>();

            universities.Add(new University { Id = 1, Name = "UJ"});
            universities.Add(new University { Id = 2, Name = "UNISA"});
            universities.Add(new University { Id = 3, Name = "Wits"});

            students.Add(new Student { Id = 1, Name = "Felicia", Gender = "Female", Age = 29, UniversityId = 1});
            students.Add(new Student { Id = 2, Name = "Lesego", Gender = "Male", Age = 23, UniversityId = 1});
            students.Add(new Student { Id = 3, Name = "Mmashele", Gender = "Female", Age = 53, UniversityId = 2});
            students.Add(new Student { Id = 4, Name = "Maxine", Gender = "Female", Age = 19, UniversityId = 3});
            students.Add(new Student { Id = 5, Name = "Kganya", Gender = "Male", Age = 17, UniversityId = 3});
            students.Add(new Student { Id = 5, Name = "Belmy", Gender = "Male", Age = 27, UniversityId = 2});
        }
    }
}
