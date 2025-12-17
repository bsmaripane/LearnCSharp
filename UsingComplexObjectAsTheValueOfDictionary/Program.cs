namespace UsingComplexObjectAsTheValueOfDictionary
{
    class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }

        public Employee(string name, int age, double salary)
        {
            Name = name;
            Age = age;
            Salary = salary;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaring dictionary
            Dictionary<int,Employee> employees = new Dictionary<int,Employee>();

            // Add new employee
            employees.Add(1, new Employee("John Doe", 36, 13435.70));
            employees.Add(2, new Employee("James Stork", 26, 15767.70));
            employees.Add(3, new Employee("Joseph Ask", 27, 10435.70));
            employees.Add(4, new Employee("Alex Alex", 30, 23435.70));
            employees.Add(5, new Employee("Major Major", 46, 33435.70));

            // Print the dictionary data
            foreach (var item in employees)
            {
                Console.WriteLine($"ID: {item.Key} Name: {item.Value.Name} Age: {item.Value.Age} Salary: {item.Value.Salary, 2}");
            }

            Console.ReadKey();
        }
    }
}
