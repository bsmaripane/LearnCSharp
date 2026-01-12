namespace DependencyInjectionApp
{

    public interface IToolUser
    {
        void SetHammer(Hammer hammer);
        void SetSaw(Saw saw);
    }
    public class Hammer
    {
        public void Use() 
        {
            Console.WriteLine("Hammering Nails");
        }
    }

    public class Builder : IToolUser
    {
        private Hammer _hammer;
        private Saw _saw;

        // Use Interface Dependency Injection (DI)
        public void BuilHouse() 
        {
            _hammer.Use();
            _saw.Use();
            Console.WriteLine("Buid house"); 
        }

        public void SetHammer(Hammer hammer)
        {
            _hammer = hammer;
        }

        public void SetSaw(Saw saw)
        {
            _saw = saw;
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
            Hammer hammer = new Hammer();   // Create the dependencies outside
            Saw saw = new Saw();    // Create the dependencies outside
            Builder builder = new Builder();
            builder.SetSaw(saw);
            builder.SetHammer(hammer);
            builder.BuilHouse();

            Console.ReadKey();
        }
    }
}
