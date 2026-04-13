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
        }
    }
}
