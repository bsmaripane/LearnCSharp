using System;
using System.Collections.Generic;
using System.Text;

namespace LINQ_With_Lists
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }   

        // Foreign Key
        public int UniversityId { get; set; }

        public void Print()
        {
            Console.WriteLine($"Student {Name} with Id {Id}, Gender {Gender} and Age {Age} from University with the Id {UniversityId}");
        }
    }
}
