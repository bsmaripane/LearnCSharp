namespace CallMethod
{
    internal class Program
    {
        static void MyMethod()
        {
            Console.WriteLine("MyMethod was called.");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Call a method!");
            MyMethod();

            Console.ReadKey();
        }
    }
}
