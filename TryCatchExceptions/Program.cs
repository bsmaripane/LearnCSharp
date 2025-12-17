namespace TryCatchExceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            int num2 = 2;

            Console.WriteLine("Please enter a number");

            try
            {
                int num1 = int.Parse(Console.ReadLine() ?? "");
                result = num2 / num1;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                Console.WriteLine($"Result: {result}");
            }

            Console.ReadKey();
        }
    }
}
