namespace DelegateExampleApp
{
    // Delegates + Events
    public delegate void ClickHandler();

    public interface IButton
    {
        event ClickHandler OnClick;
        void Click();
    }

    public class Button : IButton
    {
        public event ClickHandler OnClick;

        public void Click()
        {
            Console.WriteLine("Button clicked");
            OnClick?.Invoke();
        }
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
