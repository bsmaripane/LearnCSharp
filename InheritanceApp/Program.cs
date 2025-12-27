namespace InheritanceApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inheritance App!");
            Dog dog = new Dog();

            dog.Bark();
            dog.Eat();
            dog.Bark();

            Console.ReadKey();
        }
    }

    // Base class
    class Animal
    {
        public void Eat() { Console.WriteLine("Eatng..."); }
    }

    // Derived class
    class Dog : Animal
    {
        public void Bark() { Console.WriteLine("Barking..."); }
    }
}
