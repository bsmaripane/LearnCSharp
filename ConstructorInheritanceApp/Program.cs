namespace ConstructorInheritanceApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee maxine = new Employee("Maxine", 29);
            maxine.DisplayPersonInfo();

            Console.ReadKey();
        }
    }

    public class Person
    {
        public string Name { get; private set; }
        public int Age { get; private set; }


        // Base class constructor
        public Person(string name, int age) 
        {
            Name = name;
            Age = age;
            Console.WriteLine("Person constructor called"); 
        }
        public void DisplayPersonInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }

    public class Employee : Person
    {
        public Employee(string name, int age) : base(name, age) { Console.WriteLine("Employee (Derived Class) constructor called"); }
    }
}
