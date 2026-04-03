namespace LINQ_BasicSyntax
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var evenNumbers = from n in numbers
                              where n % 2 == 0
                              select n;

            foreach (var number in evenNumbers)
                Console.WriteLine(number);

            Console.ReadKey();
        }
    }
}
