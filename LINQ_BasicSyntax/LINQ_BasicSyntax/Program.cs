namespace LINQ_BasicSyntax
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var evenNumbers = numbers.Where(n => n % 2 == 0);

            foreach (var number in evenNumbers)
                Console.WriteLine(number);


            var names = new[] { "Lesego", "Alice", "Charlie", "David", "Bob", "Chris", "Chesta" };

            var filterName = names.Where(name => name.StartsWith("C"));

            foreach (var name in filterName)
                Console.WriteLine(name);

            Console.ReadKey();
        }
    }
}
