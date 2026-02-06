namespace Section_11_TemperatureChangeEventApp
{
    public delegate void TemperatureChangeHandler(string message);

    public class TemperatureMonitor
    {
        public event TemperatureChangeHandler OnTemperatureChanged;

        private int _temperature;

        public int Temperature { get { return _temperature; } 
            set
            { 
                _temperature = value;

                if (_temperature > 30)
                {
                    // Raise EVENT!!!
                    RaiseTemperatureChangedEvent("Temperature is above threshold!");
                }
            }
        }

        protected virtual void RaiseTemperatureChangedEvent(string message)
        {
            OnTemperatureChanged?.Invoke(message);
        }
    }

    public class TemperatureAlert
    {
        public void OnTemperatureChanged(string message)
        {
            Console.WriteLine($"Temperature Alert: {message}");
        }
    }

    public class TemperatureWarning
    {
        public void OnTemperatureChanged(string message)
        {
            Console.WriteLine($"Temperature Warning: {message}");
        }
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            TemperatureMonitor monitor = new TemperatureMonitor();
            TemperatureAlert alert = new TemperatureAlert();
            TemperatureWarning warning = new TemperatureWarning();
            monitor.OnTemperatureChanged += alert.OnTemperatureChanged;
            monitor.OnTemperatureChanged += warning.OnTemperatureChanged;

            monitor.Temperature = 29;

            Console.Write("Enter current temperature: ");
            monitor.Temperature = int.Parse(Console.ReadLine() ?? "");

            Console.ReadKey();
        }
    }
}
