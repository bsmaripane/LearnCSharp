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

        public Builder()
        {
            _hammer = new Hammer();    // Builder is responsible for creating its dependenies
            _saw = new Saw();
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
            Builder builder = new Builder();
            builder.BuilHouse();

            Console.ReadKey();
        }
    }
}
