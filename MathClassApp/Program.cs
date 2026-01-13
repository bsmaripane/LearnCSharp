namespace MathClassApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ceiling: " + Math.Ceiling(15.3));
            Console.WriteLine("Floor: " + Math.Floor(15.3));

            int num1 = 11;
            int num2 = 3;
            Console.WriteLine($"Lower of num1 {num1} and num2 {num2} is {Math.Min(num1, num2)}");
            Console.WriteLine($"Higher of num1 {num1} and num2 {num2} is {Math.Max(num1, num2)}");

            Console.WriteLine($"3 to the power of 5 is {Math.Pow(3,5)}");
            Console.WriteLine($"PI is {Math.PI}");

            Console.WriteLine($"The square root of 25 is {Math.Sqrt(25)}");

            DateTime s = new DateTime(2024, 07, 01);
            DateTime e = new DateTime(2024, 07, 10);
            DateTime s1 = new DateTime(2024, 07, 05);
            DateTime e1 = new DateTime(2024, 07, 15);

            TimeSpan ts = e.Subtract(s);
            TimeSpan ts1 = e1.Subtract(s1);

            double d = ts.TotalDays;
            double d1 = ts1.TotalDays;

            Console.WriteLine(s < e1 && e > s1);

            Console.WriteLine(d);
            Console.WriteLine(d1);

            Console.ReadKey();
        }
    }
}
