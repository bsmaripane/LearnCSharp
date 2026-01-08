namespace ConstructorInheritanceApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee maxine = new Employee("Maxine", 29, "Teacher", 1345);
            maxine.DisplayEmployeeInfo();

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
        public string JobTitle { get; private set; }
        public int EmployeeID { get; private set; }
        public Employee(string name, int age, string jobTitle, int employeeID) : base(name, age) 
        {
            JobTitle = jobTitle;
            EmployeeID = employeeID;
            Console.WriteLine("Employee (Derived Class) constructor called");
        }

        public void DisplayEmployeeInfo()
        {
            DisplayPersonInfo();
            Console.WriteLine($"Job Title: {JobTitle}, Employee ID: {EmployeeID}");
        }
    }
}
