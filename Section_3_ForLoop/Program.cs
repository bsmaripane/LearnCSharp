namespace Section_3_ForLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int counter = 10; counter >= 0; counter--)
            {
                Console.WriteLine("Counter is " + counter);
            }
            Console.ReadKey();
        }
    }
}
