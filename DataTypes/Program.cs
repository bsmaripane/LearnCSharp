namespace DataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Data Types!\n");

            // Declare and initialise variables
            int myInteger = 29;
            double myDouble = 29.1149;
            float myFloat = 3.14159f;
            char myChar = 'S';
            string myString = "Belmy Semape Maripane";
            bool myBool = true;

            // Output the variable values to the console
            Console.WriteLine("Integer: " + myInteger);
            Console.WriteLine("Double: " + myDouble);
            Console.WriteLine("Float: " + myFloat);
            Console.WriteLine("Char: " + myChar);
            Console.WriteLine("String: " + myString);
            Console.WriteLine("Boolean: " + myBool);

            Console.ReadKey();
        }
    }
}
