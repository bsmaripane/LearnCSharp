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
        private Engine _engine;

        public Car(Engine engine)   // Engine is given from outside
        {
            _engine = engine;
        }

        public void Drive()
        {
            _engine.Start();
            Console.WriteLine("Car is driving");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Engine engine = new Engine();
            Car audi = new Car(engine);

            audi.Drive();

            Console.ReadKey();
        }
    }
}
