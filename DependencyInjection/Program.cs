namespace DependencyInjection
{
    public interface IEmailService
    {
        void SendEmail(string message);
    }

    public class EmailService : IEmailService
    {
        public void SendEmail(string message) { Console.WriteLine($"Sending email: {message}"); }
    }

    public class UserService
    {
        private readonly IEmailService _emailService;
        public UserService(IEmailService emailService) { _emailService = emailService; }   // Injecting dependancy via constructor

        public void RegisterUser(string name)
        {
            Console.WriteLine($"User {name} registeed successfully.");
            _emailService.SendEmail($"Welcome {name}!");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            IEmailService emailService = new EmailService();
            UserService userService = new UserService(emailService);
            userService.RegisterUser("John Doe");

            Console.ReadKey();
        }
    }
}
