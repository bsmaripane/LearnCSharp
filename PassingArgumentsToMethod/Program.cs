namespace PassingArgumentsToMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Passing Arguments by Value!");
            int number = 11;
            ModifyValue(number);
            Console.WriteLine("number: " + number);

            Console.WriteLine("Passing Arguments by Reference - ref");
            ChangeValue(ref number);
            Console.WriteLine("numer: " + number);

            Console.WriteLine("Passing Arguments by Reference - out");
            int value;
            SetValue(out value);
            Console.WriteLine("value: " + value);

            Console.WriteLine("Swapping two numbers using ref");
            Swap(ref number, ref value);
            Console.WriteLine($"number: {number}\nvalue: {value}");

            Console.ReadKey();
        }

        static void ModifyValue(int num)
        {
            num = 100;
        }

        static void ChangeValue(ref int num)
        {
            num = 250;
        }

        static void SetValue(out int num)
        {
            num = 200;
        }

        static void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
    }
}
