namespace LambdaExpressionWithCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 36, 71, 12, 15, 29, 18, 27, 17, 9, 34, };

            Console.Write("The list: ");
            foreach (var number in numbers)
                Console.Write($"{number} ");
            Console.WriteLine();

            // Lambda to calculate square of each number
            var squares = numbers.Select(x => x * x);

            foreach (var square in squares)
                Console.Write($"{square} ");
            Console.WriteLine();

            // Lambda to find numbers divisible by 3
            var numberDivisibleBy3 = numbers.FindAll(x => x % 3 == 0);

            Console.Write("Numbers divisible by 3: ");
            foreach (var number in numberDivisibleBy3)
                Console.Write($"{number} ");
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
