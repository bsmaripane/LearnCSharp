namespace FiStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isRainy = false;
            bool hasUmbrella = true;

            // Logical Operators
            // AND  &&
            // OR   ||
            // NOT  !

            if (!isRainy)
            {
                Console.WriteLine("It is raining!");

                if (!hasUmbrella)
                    Console.WriteLine("Lucky me, I have an Umbrella.");
                else
                    Console.WriteLine("Sorry for me, I don't have an Umbrella.");
            }
            else
            {
                Console.WriteLine("It is not raining!");
            }
        }
    }
}
