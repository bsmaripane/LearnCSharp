namespace CallMethod
{
    internal class Program
    {
        static void MyMethod()
        {
            Console.WriteLine("MyMethod was called.");
        }

        static void WriteSomething(string something)
        {
            Console.WriteLine($"This argument is passed to the method: {something}");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Call a method!");
            MyMethod();
            WriteSomething("Today is a beautiful day!");

            Console.ReadKey();
        }
    }
}
