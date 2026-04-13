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
            students.Add(new Student { Id = 3, Name = "Earn", Gender = "Trans-gender", Age = 24, UniversityId = 2});
            students.Add(new Student { Id = 4, Name = "Maxine", Gender = "female", Age = 19, UniversityId = 3});
            students.Add(new Student { Id = 5, Name = "Kganya", Gender = "male", Age = 17, UniversityId = 3});
            students.Add(new Student { Id = 5, Name = "Belmy", Gender = "male", Age = 27, UniversityId = 2});
        }

        public void MaleStudents()
        {
            IEnumerable<Student> maleStudents = from student in students
                                                where student.Gender == "male"
                                                select student;

            foreach (var student in maleStudents)
            {
                student.Print();
            }
        }

        public void FemaleStudents()
        {
            IEnumerable<Student> femaleStudents = from student in students
                                                where student.Gender == "female"
                                                select student;

            foreach (var student in femaleStudents)
                student.Print();
        }

        public void AllStudents()
        {
            IEnumerable<Student> allStudents = from student in students select student;

            foreach (var student in allStudents)
                student.Print();
        }

        public void SortStudentsByAge()
        {
            var sortedStudents = from student in students
                                 orderby student.Age
                                 select student;

            foreach (var student in sortedStudents)
                student.Print();
        }
    }
}
