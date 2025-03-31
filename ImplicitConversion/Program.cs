// Implicit convertion
namespace ImplicitConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int myInt = 24744944589;
            double myDouble = myInt;       // implicit conversion

            long myLong = myInt;    // implicit conversion

            float myFloat = myInt;

            myFloat = 15.91548f;

            myDouble = myFloat;

            // Wait for the key press before closing
            Console.ReadKey();
        }
    }
}
