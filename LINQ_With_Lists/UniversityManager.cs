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

            students.Add(new Student { Id = 1, Name = "Felicia", Gender = "female", Age = 29, UniversityId = 1});
            students.Add(new Student { Id = 2, Name = "Lesego", Gender = "male", Age = 23, UniversityId = 1});
            students.Add(new Student { Id = 3, Name = "Mmashele", Gender = "female", Age = 53, UniversityId = 2});
            students.Add(new Student { Id = 4, Name = "Maxine", Gender = "female", Age = 19, UniversityId = 3});
            students.Add(new Student { Id = 5, Name = "Kganya", Gender = "male", Age = 17, UniversityId = 3});
            students.Add(new Student { Id = 5, Name = "Belmy", Gender = "male", Age = 27, UniversityId = 2});
        }

        public void MaleStudents()
        {
            IEnumerable<Student> maleStudents = from student in students
                                                where student.Gender == "male"
                                                select student;
        }
    }
}
