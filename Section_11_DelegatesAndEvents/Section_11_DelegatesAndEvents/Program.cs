namespace Section_11_DelegatesAndEvents
{
    public delegate void LogHandler(string message);

    public class Logger
    {
        public void LogToConsole(string message)
        {
            Console.WriteLine($"Console Log: { message}");
        }

        public void LogToFile(string message)
        {
            Console.WriteLine($"File Log: {message}");
        }
    }

    internal class Program
    {
        // 1. Declaration:
        public delegate void Notify(string message);
         
        static void Main(string[] args)
        {
            // Delegates define a method signature, and any method assigned to a delegate must match this signature

            // 2. Instatiation:
            Notify notifyDelegate = ShowMessage;
            //Notify notifyDelegate = new Notify(notifyDelegate); // old style

            // 3. Invocation:
            notifyDelegate("Morning Delegate");

            Logger logger = new Logger();
            LogHandler logHandler = logger.LogToConsole;
            logHandler("Logging to console");

            logHandler = logger.LogToFile;
            logHandler("Logging to a file");

            Console.ReadKey();
        }

        // Mehod
        static void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
