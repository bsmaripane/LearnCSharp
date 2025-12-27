namespace Section_8_IS_A_Relationship
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HAS-A Relationship - Inheritance\n");

            Car myCar = new Car();
            myCar.Move();   // Inherited from Vehicle
            myCar.Honk();   // Specific to Car

            Console.ReadKey();
        }
    }

    class vehicle
    {
        public void Move() { Console.WriteLine("The vehicle is moving"); }
    }

    class Car : vehicle
    {
        public void Honk() { Console.WriteLine("The car is honking"); }
    }
}
