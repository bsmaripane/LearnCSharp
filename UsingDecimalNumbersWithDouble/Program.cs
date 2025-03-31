using System.Globalization;

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

            try
            {
                // Prompt user for input of two numbers
                Console.WriteLine("Enter the first number: ");
                firstNumber = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); // to ensure consistent parsing of decimal numbers

                Console.WriteLine("Enter the second number: ");
                secondNumber = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);  // to ensure consistent parsing of decimal numbers

                // Compute the sum
                sum = firstNumber + secondNumber;

                // Display the sum
                Console.WriteLine($"The sum of {firstNumber.ToString(CultureInfo.InvariantCulture)} and {secondNumber.ToString(CultureInfo.InvariantCulture)} is: {sum.ToString(CultureInfo.InvariantCulture)}");
            }
            catch(FormatException)
            {
                Console.WriteLine("Invalid input, Please enter a valid number.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }

            // Wait for a key press before closing
            Console.ReadKey();
        }
    }
}
