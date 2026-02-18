namespace DelegateExampleApp
{
    internal class Program
    {
        // Delegate
        public delegate void MyDelegate();

        // Method
        public static void SayHello() { Console.WriteLine("Hello Delegate"); }

        static void Main(string[] args)
        {
            // Use the delegate
            MyDelegate del = SayHello;
            del();

            Console.ReadKey();
        }
    }
}
