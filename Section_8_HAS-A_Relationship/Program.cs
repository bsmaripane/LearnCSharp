namespace Section_8_HAS_A_Relationship
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HAS-A Relationship - Composition\n");

            Car myCar = new Car();
            myCar.StartCar();

            Console.ReadKey();
        }
    }

    class Engine
    {
        public void Start() { Console.WriteLine("Engine started"); }
    }

    class Car
    {
        private Engine engine = new Engine();
        public void StartCar()
        {
            engine.Start();     // Car contains an Engine and uses it
            Console.WriteLine("Car is ready to drive");
        } 
    }
}
