namespace UserInputAndDataTypeString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("My Addition Calculator\n");

            Console.WriteLine("Enter something: ");

            // Takes the user input and stores it
            // Variable with the name "userInput" and the data type "string"
            // strings are used for text
            string userInput = Console.ReadLine();
            Console.WriteLine("You entered " + userInput);

            Console.ReadKey();
        }
    }
}

