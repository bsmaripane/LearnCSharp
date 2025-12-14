using System;

namespace Coding.Exercise
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // TODO
            Person person = new Person("John", 30);
            person.Greet();
            Console.ReadKey();
        }
    }

    public class Person
    {
        // TODO
        private string _name = "";
        private int _age;
        public string Name { get => _name; set => _name = value; }
        public int Age
        {
            get => _age;
            set
            {
                if (value > 0) _age = value;
            }
        }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public void Greet() => Console.WriteLine($"Hello, my name is {Name} and I am {Age} years old.");
    }
}
