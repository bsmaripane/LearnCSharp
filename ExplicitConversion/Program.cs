// Explicit Conversion          
namespace ExplicitConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long myLong = 123451815116198;

            int myInt = (int)myLong;

            Console.WriteLine(myInt);

            float myFloat = 2458.254f;
            double myDouble = 1943.987218151891;
            Console.WriteLine(myDouble);

            myFloat = (float)myDouble;
            Console.WriteLine(myFloat);

            myInt = (int)myDouble;
            Console.WriteLine(myInt);

            Console.ReadKey();
        }
    }
}
