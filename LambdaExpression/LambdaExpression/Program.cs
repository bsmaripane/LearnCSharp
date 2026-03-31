using System.Linq.Expressions;

namespace LambdaExpression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lambda Expression!\n");
            Console.WriteLine($"square expression tree: {square}");
            Console.WriteLine($"Result: {square.Compile()(5)}");

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, };
            var squaredNumbers = numbers.Select(x => x * x);
            Console.WriteLine(string.Join(" ", squaredNumbers));

            Console.ReadKey();
        }

        static Expression<Func<int, int>> square = x => x * x;
    }
}
