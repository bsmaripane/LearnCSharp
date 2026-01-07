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


    class Cat : Animal
    {
        public void Meow() { Console.WriteLine("Cat is meowing"); } 
    }

    // A breed of dog
    class Collie : Dog
    {
        public void GoingNuts() { Console.WriteLine("Collie going Nuts"); }
    }

}
