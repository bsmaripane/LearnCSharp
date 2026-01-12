namespace DependencyInjection
{
    public class EmailService
    {
        public void SendEmail(string message) { Console.WriteLine($"Sending email: {message}"); }
    }

    public class UserService
    {
        private EmailService _emailService;
        public UserService() { _emailService = new EmailService(); }   // Directly creating the dependancy

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
            UserService userService = new UserService();
            userService.RegisterUser("John Doe");


            Console.ReadKey();
        }
    }
}
