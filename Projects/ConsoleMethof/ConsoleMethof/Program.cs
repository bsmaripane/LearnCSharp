namespace ConsoleMethof
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HELLO WELCOME"); // prints the text and jumps to a new line
            Console.Write("BELMY");
            Console.Write(" MARIPANE\n\n"); // prints in the same line and doesn't jump to the new line

            Console.Write("Enter a string and press enter: ");
            string readInput = Console.ReadLine();
            Console.WriteLine("You have entered: {0}", readInput);

            Console.Write("Enter a string and press enter: ");
            int asciiValue = Console.Read();
            Console.WriteLine("ASCII valuw is {0}:", asciiValue);
            Console.ReadKey();

        }
    }
}
