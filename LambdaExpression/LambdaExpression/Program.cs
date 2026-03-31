using System.Linq.Expressions;

namespace LambdaExpression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lambda Expression!\n");
            Console.WriteLine($"square expression tree: {square}");

            Console.ReadKey();
        }

        static Expression<Func<int, int>> square = x => x * x;
    }
}
