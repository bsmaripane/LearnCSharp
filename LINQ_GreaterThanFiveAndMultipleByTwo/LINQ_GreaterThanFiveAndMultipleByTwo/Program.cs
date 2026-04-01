namespace LINQ_GreaterThanFiveAndMultipleByTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 2, 5, 7, 8, 10 };

            // LINQ query to get numbers greater than 5 and double them
            var result = numbers.Where(x => x > 5).Select(x => x * 2);

            Console.WriteLine("Result of LINQ query:");
            foreach (var number in result)
                Console.WriteLine(number);

            Console.ReadKey();
        }
    }
}
