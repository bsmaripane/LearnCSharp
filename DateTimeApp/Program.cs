namespace DateTimeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime birthDate = new DateTime(1995, 5, 17);

            Console.WriteLine($"My birthday is {birthDate}");

            Console.ReadKey();
        }
    }
}
