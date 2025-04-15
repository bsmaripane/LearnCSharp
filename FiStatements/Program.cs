namespace FiStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isRainy = false;
            bool hasUmbrella = true;
            bool isHeavyRain = true;

            // Logical Operators
            // AND  &&
            // OR   ||
            // NOT  !

            if (isRainy || !isHeavyRain)
            {
                Console.WriteLine("It is raining!");

                if (hasUmbrella && isHeavyRain)
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
