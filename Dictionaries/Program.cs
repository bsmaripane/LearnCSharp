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

            string name = employee[101];
            Console.WriteLine(name);

            Console.ReadKey();
        }
    }
}
