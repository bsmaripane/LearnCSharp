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

    public class Light
    {
        public void TurnOn() { Console.WriteLine("Light turned on"); }
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

            // Connect everything
            IButton button = new Button();
            Light light = new Light();

            button.OnClick += light.TurnOn();

            button.Click();

            Console.ReadKey();
        }
    }
}
