namespace AdditionCalculater
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare and initialise variables
            int firstNumber = 0;
            int secondNumber = 0;
            int sum = 0;

            // Prompt user for input of two integers
            Console.WriteLine("Enter the first number: ");
            firstNumber = Console.Read();

            Console.WriteLine("Enter the second number: ");
            secondNumber = Console.Read();

            // Compute the sum
            sum = firstNumber + secondNumber;

            // Display the sum
            Console.WriteLine($"The sum of {firstNumber} and {secondNumber} is: {sum}");

            Console.ReadKey();
        }
    }
}
