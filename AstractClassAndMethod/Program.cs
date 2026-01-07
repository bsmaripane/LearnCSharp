namespace AstractClassAndMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Defining an Astract Class and Method!\n");
            Dog dog = new Dog();
            dog.Sleep();
            dog.MakeSound();
            dog.MakeSound();
            dog.MakeSound();



            Console.ReadKey();
        }
    }

    abstract class Animal
    {
        public abstract void MakeSound();
        public void Sleep() { Console.WriteLine("Sleeping..."); }
    }

    class Dog : Animal
    {
        public override void MakeSound() { Console.WriteLine("Woof! Woof!"); }
    }

    abstract class Vehicle
    {
        public int Speed { get; set; }
        public abstract void Move();
    }

    class Car : Vehicle
    {
        public override void Move() { Console.WriteLine($"The car is driving at {Speed} KPM"); }
        public Car(int x) { Speed = x; }
    }
}
