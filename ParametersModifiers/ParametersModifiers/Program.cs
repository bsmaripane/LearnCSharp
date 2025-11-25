namespace ParametersModifiers
{
    internal class Program
    {
        static void ModifyValues(ref int num)
        {
            num += 10;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Parameter Modifers in C#!");

            int number = 5;

            Console.WriteLine($"Before ModifyValues: {number}");
            ModifyValues(ref number);
            Console.WriteLine($"After ModifyValues: {number}");

            Console.ReadKey();
        }
    }
}
