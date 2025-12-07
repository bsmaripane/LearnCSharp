using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Section5Exercises
{
    internal class Program
    {
        public static int factorial(int a)
        {
            if (a == 0) return 1;
            return a * factorial(a - 1);
        }

        static void Main(string[] args)
        {
            // 1. Count how many numbers between 1 and 100 are divisible by 3 with no remainde
            var count = 0;
            var diviser = 3;
            var start = 1;
            var end = 100;

            for (var index = start; index <= end; index++)
            {
                if (index % diviser == 0)
                    count++;
            }
            Console.WriteLine($"Total numbers between {start} and {end} are divisible by {diviser} is {count}");

            // 2. Write a program and continuously ask the user to enter a number or "ok" to exit.
            //    Calculate the sum of all the previously entered numbers and display it on the console.
            var sum = 0;
            var strNumber = "";
            do
            {
                Console.Write("Enter a number or 'ok' to exit: ");
                strNumber = Console.ReadLine()??"";
                try
                {
                    var number = Convert.ToInt32(strNumber);
                    sum += number;
                }
                catch
                {
                    continue;
                }
            }while (strNumber.ToLower() != "ok");
            Console.WriteLine($"The sum of all the previously entered numbers is {sum} ");

            // 3. Ask the user to enter a number. Compute the factorial of the number and print it on the console.
            var num = 0;
            Console.Write("Enter a number and to get a factorial of the number: ");
            var strNum = Console.ReadLine() ?? "";
            
            try
            {
                num = Convert.ToInt32(strNum);
                if (num < 0) throw new ArgumentOutOfRangeException(nameof(num), "The number cannot be negative.");
            }
            catch (Exception ex) 
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            Console.WriteLine($"The factorial of {num} is {factorial(num)}");

            Console.ReadKey();
        }
    }
}
