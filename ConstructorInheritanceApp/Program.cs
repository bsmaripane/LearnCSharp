namespace ConstructorInheritanceApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee maxine = new Employee("Maxine", 29, "Teacher", 1345);
            maxine.DisplayEmployeeInfo();

            Manager felicia = new Manager("Felicia", 29, "Senior Teacher", 9474, 9);
            felicia.DisplayManagerInfo();

            //Console.WriteLine(maxine.ToString() + "\n" + felicia.ToString());

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

    public class Manager : Employee
    {
        public int TeamSize { get; private set; }
        public Manager(string name, int age, string jobTitle, int employeeID, int teamSize) : base(name, age, jobTitle, employeeID)
        {
            TeamSize = teamSize ;
            Console.WriteLine("Manager constrcutor is called");
        }

        public void DisplayManagerInfo()
        {
            DisplayEmployeeInfo();
            Console.WriteLine($"Team Size: {TeamSize}");
        }
    }
}
