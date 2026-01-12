namespace DependencyInjectionApp
{
    public class Hammer
    {
        public void Use() 
        {
            Console.WriteLine("Hammering Nails");
        }
    }

    public class Builder
    {
        public Hammer Hammer { get; set; }
        public Saw Saw { get; set; }

        // Setter Dependency Injection (DI)
        public void BuilHouse() 
        {
            Hammer.Use();
            Saw.Use();
            Console.WriteLine("Buid house"); 
        }
    }

    public class Saw
    {
        public void Use() { Console.WriteLine("Sawing  wood"); }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Hammer hammer = new Hammer();
            Saw saw = new Saw();
            Builder builder = new Builder();
            builder.Saw = saw;  // Inject dependencies via Setter
            builder.Hammer = hammer;    // Inject dependencies via Setter
            builder.BuilHouse();

            Console.ReadKey();
        }
    }
}
