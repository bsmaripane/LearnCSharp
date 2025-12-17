namespace NullablesInCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int? age = null; // int? is a nullable int

            if (age.HasValue)
                Console.WriteLine($"Age is {age.Value}");
            else
                Console.WriteLine("Age is not specified");

            Console.ReadKey();
        }
    }
}
