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

            // Registering Dependencies in ASP.NET Core
            var builder = WebApplication.CreateBuilder(args);

            // Register services
            builder.Services.AddScoped<IEmailService, EmailService>();
            builder.Services.AddScoped<UserService>();

            var app = builder.Build();

            // Resolve dependencies
            var userService = app.Services.GetRequiredService<IEmailService>();
            userService.RegisterUser("Jane Doe");

            app.Run();

            Console.ReadKey();
        }
    }
}
