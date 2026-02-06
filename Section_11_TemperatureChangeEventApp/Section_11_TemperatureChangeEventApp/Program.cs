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

    internal class Program
    {
        static void Main(string[] args)
        {


            Console.ReadKey();
        }
    }
}
