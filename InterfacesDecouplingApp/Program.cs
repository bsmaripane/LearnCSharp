
/*
 Decoupling: The Application class depends on the ILogger interface ather than specific implementations like FileLogger or DatabaseLogger.
 This means you can easily switch the logging mechanism without changing the Application class.
 */
namespace InterfacesDecouplingaApp
{
    public interface ILogger
    {
        void Log(string message);
    }

    public class FileLogger : ILogger
    {
        public void Log(string message)
        {
            //string directoryPath = "C:\\Users\\bsmar\\OneDrive\\Desktop\\Udemy\\LearnCSharp\\InterfacesDecouplingApp\\";
            // The @ sign in C# to used to denote a verbatim string literal
            string directoryPath = @"C:\Users\bsmar\OneDrive\Desktop\Udemy\LearnCSharp\InterfacesDecouplingApp\";
            string filePath = Path.Combine(directoryPath, "log.txt");

            if (!Directory.Exists(filePath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            File.AppendAllText(filePath, message +"\n");
        }
    }

    public class Application
    {
        private readonly ILogger _logger;
        public Application(ILogger logger)
        {
            _logger = logger;
        }

        public void DoWork()
        {
            _logger.Log("Work started");
            // DO ALL THE WORK
            _logger.Log("Work done!");
        }
    }

    public class DatabaseLogger : ILogger
    {
        public void Log(string message)
        {
            // Implement a logic to log a message to a database
            Console.WriteLine($"Logging to database: {message}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            ILogger fileLogger = new FileLogger();
            Application app = new Application(fileLogger);
            app.DoWork();

            ILogger dbLogger = new DatabaseLogger();
            app = new Application(dbLogger);
            app.DoWork();

            Console.ReadKey();
        }
    }
}
