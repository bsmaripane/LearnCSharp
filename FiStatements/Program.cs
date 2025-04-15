namespace FiStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isRainy = true;
            bool hasUmbrella = true;
            bool isHeavyRain = true;

            // Logical Operators
            // AND  &&
            // OR   ||
            // NOT  !

            // Varieants of the OR operator
            // true  || true -. true
            // true  || false -> true
            // false || true -> true
            // false || false -> false

            // Varients of the AND operator
            // true  && true -> true
            // true  && false -> false
            // false && false -> false
            // false && false -> false

            // Varients fo NOT operator
            // !true  -> false
            // !false -> true

            if (isRainy)
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
