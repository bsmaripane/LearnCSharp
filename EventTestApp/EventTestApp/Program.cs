namespace EventTestApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press A to simulate a button click");
            var key = Console.ReadLine();

            if (key == "a")
            {
                KeyPressed();
            }

            Console.ReadKey();
        }

        static void KeyPressed()
        {
            Button button = new Button();
            button.ClickEvent += (s, args) =>
            {
                Console.WriteLine($"You clicked a button {args.Name}");
            };
            button.OnClick();
        }
    }

    public class Button
    {
        public EventHandler<MyCustomerArguments> ClickEvent;

        public void OnClick()
        {
            MyCustomerArguments myArgs = new MyCustomerArguments();
            myArgs.Name = "Belmy";
            ClickEvent.Invoke(this, myArgs);
        }
    }

    public class MyCustomerArguments : EventArgs
    {
        public string Name { get; set; }
    }
}
