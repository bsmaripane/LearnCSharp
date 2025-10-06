namespace TheWhileLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;

            while (counter <= 30)
            {
                if (counter % 2 == 0)
                    Console.WriteLine($"The counter is {counter}");
                counter++;
            }
            Console.ReadKey();
        }
    }
}
