namespace CarDependencyOnEngineApp
{
    public interface IEngine
    {
        void Start();
    }

    public class PetrolEngine : IEngine
    {
        public void Start()
        {
            Console.WriteLine("Petrol engine started");
        }
    }

    public class DieselEngine : IEngine
    {
        public void Start()
        {
            Console.WriteLine("Diesel engine started");
        }
    }

    public class ElectricEngine : IEngine
    {
        public void Start()
        {
            Console.WriteLine("Electric engine started");
        }
    }

    public class Car
    {
        private IEngine _engine;

        public Car(IEngine engine)   // Inject interface
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
            // IEngine creates engines 
            IEngine petrolEngine = new PetrolEngine();
            IEngine dieselEngine = new DieselEngine();
            IEngine electricEngine = new ElectricEngine();

            // Inject engines into car
            Car audi = new Car(petrolEngine);
            Car toyota = new Car(dieselEngine);
            Car tasla = new Car(electricEngine);

            // Car calls start() through IEngine
            audi.Drive();
            toyota.Drive();
            tasla.Drive();

            Console.ReadKey();
        }
    }
}
