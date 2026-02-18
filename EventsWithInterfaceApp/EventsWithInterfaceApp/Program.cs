namespace EventsWithInterfaceApp
{
    public interface IButton
    {
        event Action OnClick;
        void Click();
    }

    public class Button : IButton
    {
        public event Action OnClick;

        public void Click()
        {
            Console.WriteLine("Button clicked");
            OnClick?.Invoke();
        }
    }

    // Listener
    public class Light
    {
        public void TurnOn()
        {
            Console.WriteLine("Light turned on");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            IButton button = new Button();
            Light light = new Light();

            button.OnClick += light.TurnOn; // raises event

            button.Click();

            Console.ReadKey();
        }
    }
}
