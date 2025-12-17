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
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                Debug.WriteLine(ex.ToString());
            }
            finally
            {
                Console.WriteLine($"Result: {result}");
            }

            Console.ReadKey();
        }
    }
}
