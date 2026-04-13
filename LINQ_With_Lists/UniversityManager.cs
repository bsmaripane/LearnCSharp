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
        }
    }
}
