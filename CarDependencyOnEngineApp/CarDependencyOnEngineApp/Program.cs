namespace CarDependencyOnEngineApp
{
    public class Engine
    {
        public void Start()
        {
            Console.WriteLine("Starting an engine");
        }
    }

    public class Car
    {
        private Engine engine = new Engine();   // Car creates the engine

        public void Drive()
        {
            engine.Start();
            Console.WriteLine("Car is driving");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            Console.ReadKey();
        }
    }
}
