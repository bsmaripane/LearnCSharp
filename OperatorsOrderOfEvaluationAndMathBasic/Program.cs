// Operators and Order of Evaluation

namespace OperatorsOrderOfEvaluationAndMathBasic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Decaring and initialising variables
            int number1 = 5;
            int number2 = 13;

            // Concatination
            Console.WriteLine("Age is " + number1);
            Console.WriteLine("Addition number1 + number2 = " + (number1 + number2));
            Console.WriteLine($"Addition number1 + number2 {number1 + number2}");

            // Order of Evaluation
            Console.WriteLine("Subtraction number1 - number2 = " + (number1 - number2));
            Console.WriteLine("Multiplication number1 * number2 = " + number1 * number2);
            Console.WriteLine("Division number1 / number2 = " + number1 / number2);
            Console.WriteLine($"Modulation number1 % number2 {number1 % number2}");

            // basic math
            Console.WriteLine($"Unordered calcualation: {5 / 6 - 3 + 2 * 4 - 8 * 3}");
            Console.WriteLine($"Ordered calcualtion: {(5 / 6 - 3) + (2 * 4 - 8 * 3)}");
            Console.WriteLine($"Order of evaluation: {(5 / 6 - 3) + ((2 * 4) - 8 * 3)}");
            Console.WriteLine($"Order of evaluation: {(5 / (6 - 3)) + ((2 * 4) - 8 * 3)}");
            Console.WriteLine($"Order of evaluation: {(5 / 6 - 3) + (2 * (4 - 8) * 3)}");

            // Wait for the key press before closing
            Console.ReadKey();
        }
    }
}
