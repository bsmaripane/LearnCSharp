namespace Section_11_TemperatureChangeEventApp
{
    // Using the Generic Delegate EventHandler<TEventArgs>

    //public delegate void TemperatureChangeHandler(string message);

    public class TemperatureChangedEventArgs : EventArgs
    {
        public int Temperature {  get; }

        public TemperatureChangedEventArgs(int temperature)
        {
            Temperature = temperature;
        }
    }

    public class TemperatureMonitor
    {
       public event EventHandler<TemperatureChangedEventArgs> TemperatureChanged;

        //public event TemperatureChangeHandler OnTemperatureChanged;

        private int _temperature;

        public int Temperature { get { return _temperature; } 
            set
            { 
                

                if (_temperature != value)
                {
                    _temperature = value;
                    // Raise EVENT!!!
                    OnTemperatureChanged(new TemperatureChangedEventArgs(_temperature));
                }
            }
        }

        protected virtual void OnTemperatureChanged(TemperatureChangedEventArgs e)
        {
            // Letting every subscriber know!
            TemperatureChanged?.Invoke(this, e);
        }
    }

    public class TemperatureAlert
    {
        public void OnTemperatureChanged(object sender, TemperatureChangedEventArgs e)
        {
            Console.WriteLine($"Temperature Alert: {e.Temperature} sender is {sender}");
        }
    }

    public class TemperatureWarning
    {
        public void OnTemperatureChanged(object sender, TemperatureChangedEventArgs e)
        {
            Console.WriteLine($"Temperature Warning: {e.Temperature}  sender is {sender}");
        }
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            TemperatureMonitor monitor = new TemperatureMonitor();
            TemperatureAlert alert = new TemperatureAlert();
            TemperatureWarning warning = new TemperatureWarning();
            monitor.TemperatureChanged += alert.OnTemperatureChanged;
            monitor.TemperatureChanged += warning.OnTemperatureChanged;

            monitor.Temperature = 29;

            Console.Write("Enter current temperature: ");
            monitor.Temperature = int.Parse(Console.ReadLine() ?? "");

            Console.ReadKey();
        }
    }
}
