namespace Section_11_EventsApp
{
    public delegate void Notify(string message);

    public class EventPublisher
    {
        // It signifies that the method is not just a regular method but one that is called when a specific event occurs.
        public event Notify OnNotify;

        public void RaisEvent(string message)
        {
            OnNotify?.Invoke(message);  // Invoke the event if there are any subscribers
        }
    }

    public class EvenSubcriber
    {
        public void OnEvenRaised(string message)
        {
            Console.WriteLine($"Event received: {message}");
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
