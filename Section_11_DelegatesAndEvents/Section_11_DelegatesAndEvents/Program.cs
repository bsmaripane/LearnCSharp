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

            // Creating a multicast delegate
            Logger logger = new Logger();
            LogHandler logHandler = logger.LogToConsole;
            logHandler += logger.LogToFile;

            // invoking the multicast delegate
            logHandler("Log this info");

            foreach (LogHandler handler in logHandler.GetInvocationList())
            {
                try
                {
                    handler("Event occurred with error handling");
                }
                catch (Exception ex)
                { Console.WriteLine($"Exception caught: {ex.Message}"); }
            }

            // remove multicast delegate
            if (IsMethodInDelegate(logHandler, logger.LogToFile))
            {
                logHandler -= logger.LogToFile;
                Console.WriteLine("LogToFile method removed");
            }
            else
                Console.WriteLine("LogToFile not found");
            InvokeSafely(logHandler, "After removing logToFile");

            Console.ReadKey();
        }

        // Mehod
        static void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }

        static void InvokeSafely(LogHandler logHandler, string message)
        {
            LogHandler tempLogHander = logHandler;

            if (tempLogHander != null)
                tempLogHander(message);
        }

        static bool IsMethodInDelegate(LogHandler logHandler, LogHandler method)
        {
            if (logHandler == null) return false;

            foreach (var item in logHandler.GetInvocationList())
            {
                if (item == (Delegate)method)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
