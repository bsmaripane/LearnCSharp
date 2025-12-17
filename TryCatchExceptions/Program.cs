using System.Diagnostics;

namespace TryCatchExceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            int num2 = 2;

            Debug.WriteLine("Main method is running");

            Console.WriteLine("Please enter a number");

            try
            {
                int num1 = int.Parse(Console.ReadLine() ?? "");
                result = num2 / num1;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"DON'T DIVIDE BY ZERO!! {ex.Message}");
                result = 10;
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"I TOLD YOU TO ENTER A NUMBER! {ex.Message}");
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("NUMBER TOO HIGH!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                Debug.WriteLine(ex.ToString());
            }
            finally
            {
                Console.WriteLine($"Result: {result}");
            }

            try
            {
                Console.Write("Enter your age: ");
                GetUserAge(Console.ReadLine() ?? "");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception: {e.Message}");
            }

            Console.ReadKey();
        }

        static int GetUserAge(string input)
        {
            int age;

            if (int.TryParse(input, out age))
                throw new Exception("You didn't enter a valid age.");

            if (age < 0 || age > 65)
                throw new Exception("Your age must be between 0 and 65.");

            return age;
        }
    }
}
