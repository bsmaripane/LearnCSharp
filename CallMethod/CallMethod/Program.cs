namespace CallMethod
{
    internal class Program
    {
        static void MyMethod()
        {
            Console.WriteLine("MyMethod was called.");
        }

        static void WriteSomething(string something = "Nothing passed!")
        {
            Console.WriteLine($"This argument is passed to the method: {something}");
        }

        static int AddTwoValues(int a, int b)
        {
            return a + b;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Call a method!");
            MyMethod();
            WriteSomething("Today is a beautiful day!");
            WriteSomething();

            Console.Write("Enter a number, I'll add 10 to it: ");
            int num = Convert.ToInt32(Console.ReadLine());

            int result = AddTwoValues(num, 10);

            Console.WriteLine($"The result is: {result}");

            Console.ReadKey();
        }
    }
}
