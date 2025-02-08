namespace DataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declaring a variable
            int num1;
            // assigning a value to a variable
            num1 = 9;
            Console.WriteLine("num1 is " + num1);
            // declaring and initializing a variable in one line
            int num2 = 28;
            int sum = num1 + num2;
            Console.WriteLine("num1: " + num1 + " + num2 " + num2 + " is " + sum);
            // declaring and initializing a double variable
            double d1 = 3.1415;
            double d2 = 5.1;
            double dDiv = d1 / d2;
            Console.WriteLine("d1/d2 is " + dDiv);
            // declaring and initializing a float variable
            float f1 = 3.1415f;
            float f2 = 5.1f;
            float fDiv = f1 / f2;
            Console.WriteLine("f1/f2 is " + fDiv);

        }
    }
}
