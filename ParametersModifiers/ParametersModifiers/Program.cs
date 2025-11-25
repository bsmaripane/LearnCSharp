namespace ParametersModifiers
{
    internal class Program
    {
        static void ModifyValues(ref int num)
        {
            num += 10;
        }

        static void GetValue(out int age)
        {
            age = 30;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Parameter Modifers in C#!");

            int number = 5;
            int age;

            Console.WriteLine($"Before ModifyValues: {number}");
            ModifyValues(ref number);
            Console.WriteLine($"After ModifyValues: {number}");

            GetValue(out age);
            Console.WriteLine($"Age from GetValue: {age}");

            Console.ReadKey();
        }
    }
}
