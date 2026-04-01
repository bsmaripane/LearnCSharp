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



            Console.ReadKey();
        }
    }
}
