namespace RecursionFunction
{
    internal class Program
    {
        static void CountDown(int number)
        {
            // Base case
            if (number == 0)
            {
                Console.WriteLine("Bast off!");
                return;
            }

            Console.WriteLine(number);

            // Recursive call
            CountDown(number - 1);
        }

        static int Factorial(int n)
        {
            // Base case
            if (n == 0)
            {
                return 1;
            }

            // Recursive call
            return n * Factorial(n - 1);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Recursion Function in C#!");

            var age = 11;

            CountDown(age);

            for (int i = 1; i <= 5; i++)
                Console.WriteLine($"{i}! = {Factorial(i)}");

            Console.ReadKey(true);
        }
    }
}
