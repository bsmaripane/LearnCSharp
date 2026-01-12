namespace DateTimeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime birthDate = new DateTime(1995, 5, 17);

            Console.WriteLine($"My birthday is {birthDate}");
            Console.WriteLine($"The current date: {DateTime.Today}");
            Console.WriteLine($"The current date and current time: {DateTime.Now}");
            Console.ReadKey();
        }
    }
}
