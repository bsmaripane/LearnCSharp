using System;

namespace ConditionalBasedCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number:");
            double number1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            double number2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Choose an operation: +, -, *, /");
            char ops = Console.ReadLine()[0];

            switch (ops)
            {
                case '+':
                    Console.WriteLine($"Result: {number1 + number2}");
                    break;
                case '-':
                    Console.WriteLine($"Result: {number1 - number2}");
                    break;
                case '*':
                    Console.WriteLine($"Result: {number1 * number2}");
                    break;
                case '/':
                    Console.WriteLine(number2 != 0? $"Result: {number1 / number2}" : "Error: Division by zero is not allowed.");
                    break;
                default:
                    Console.WriteLine("Invalid operation. Please choose +, -, *, or /.");
                    break;
            }

            Console.ReadKey();
        }
    }
}
