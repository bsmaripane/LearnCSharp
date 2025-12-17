namespace TryCatchExceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = 0;

            Console.WriteLine("Please enter a number");
            //int num1 = int.Parse(Console.ReadLine());
            int num1 = 0;
            int num2 = 2;

            try
            {
                result = num2 / num1;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            

            Console.WriteLine($"Result: {result}");

            Console.ReadKey();
        }
    }
}
