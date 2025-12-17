namespace Dictionaries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Key - value
            // Declaring an initialising a dictionary
            Dictionary<int, string> employee = new Dictionary<int, string>();
            employee.Add(101, "John Doe");
            employee.Add(102, "Jane Doe");
            employee.Add(103, "Sam Doe");
            employee.Add(104, "Bob Smith");

            // accessing data in dictionary
            string name = employee[101];
            Console.WriteLine(name);
            Console.WriteLine(employee[102]);

            // Update data in a dictionary
            employee[102] = "Jane Smith";
            Console.WriteLine(employee[102]);

            // Remove data dfrom the dictionary
            employee.Remove(101);

            foreach (var item in employee)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
