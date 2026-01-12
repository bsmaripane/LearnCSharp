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
        private Hammer _hammer;
        private Saw _saw;

        // Constructor Dependency Injection (DI)
        public Builder(Hammer hammer, Saw saw)
        {
            _hammer = hammer;
            _saw = saw;
        }

        public void BuilHouse() 
        {
            _hammer.Use();
            _saw.Use();
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
            Builder builder = new Builder(hammer, saw);
            builder.BuilHouse();

            Console.ReadKey();
        }
    }
}
