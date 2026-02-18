namespace DelegateExampleApp
{
    // Delegates + Events
    public delegate void ClickHandler();

    public interface IButton
    {
        event ClickHandler OnClick;
        void Click();
    }

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
