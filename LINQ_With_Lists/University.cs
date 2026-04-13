using System;
using System.Collections.Generic;
using System.Text;

namespace LINQ_With_Lists
{
    internal class University
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Print()
        {
            Console.WriteLine($"University {Name} with id {Id}");
        }
    }
}
