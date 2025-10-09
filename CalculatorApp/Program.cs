using System;

namespace CalculatorApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var calc = new Calculator();

            Console.WriteLine("Simple Calculator");
            Console.Write("Enter first number: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter operator (+, -, *, /): ");
            string op = Console.ReadLine();

            Console.Write("Enter second number: ");
            double b = Convert.ToDouble(Console.ReadLine());

            double result = 0;

            switch (op)
            {
                case "+": result = calc.Add(a, b); break;
                case "-": result = calc.Subtract(a, b); break;
                case "*": result = calc.Multiply(a, b); break;
                case "/": result = calc.Divide(a, b); break;
                default:
                    Console.WriteLine("Invalid operator.");
                    return;
            }

            Console.WriteLine($"Result: {result}");

            Console.ReadKey();
        }
    }
}
