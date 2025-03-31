namespace UsingDecimalNumbersWithDouble
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare and initialise variables
            double firstNumber = 0.0;
            double secondNumber = 0.0;
            double sum = 0.0;

            // Prompt user for input of two integers
            Console.WriteLine("Enter the first number: ");
            firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            secondNumber = int.Parse(Console.ReadLine());

            // Compute the sum
            sum = firstNumber + secondNumber;

            // Display the sum
            Console.WriteLine($"The sum of {firstNumber} and {secondNumber} is: {sum}");

            Console.ReadKey();
        }
    }
}
