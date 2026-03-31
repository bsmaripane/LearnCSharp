namespace LambdaExpression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lambda Expression!\n");
            Console.WriteLine($"square of 5: {square(5)}");

            Console.ReadKey();
        }

        static Func<int, int> square = x => x * x;
    }
}
