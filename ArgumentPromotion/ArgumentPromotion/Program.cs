namespace ArgumentPromotion
{
    internal class Program
    {
        static void DisplayNumber(double number)
        {
            Console.WriteLine($"The number is: {number}");
        }

        static void CalculateArea(double radius)
        {
            double area = Math.PI * radius * radius;
            Console.WriteLine($"The area of the circle with radius {radius} is: {area}");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Argument Promotion C# automatically promote argument from smaller to larger data type!");
            int smallInt = 10;
            int radius = 5;

            // Implicitly promote int to double
            DisplayNumber(smallInt); // 42 is an int, but it will be promoted to double
            CalculateArea(radius);   // 5 is an int, but it will be promoted to double

            Console.ReadKey();
        }
    }
}
