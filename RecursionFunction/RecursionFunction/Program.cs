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
        static void Main(string[] args)
        {
            Console.WriteLine("Recursion Function in C#!");

            var age = 30;

            CountDown(age);

            Console.ReadKey(true);
        }
    }
}
