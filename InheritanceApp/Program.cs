namespace InheritanceApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inheritance App!");
            Dog dog = new Dog();

            dog.MakeSound();
            dog.Eat();
            dog.MakeSound();

            Cat cat = new Cat();
            cat.MakeSound();
            cat.Eat();
            cat.MakeSound();

            Console.ReadKey();
        }
    }

    // Base class
    class Animal
    {
        public void Eat() { Console.WriteLine("Eatng..."); }
        public virtual void MakeSound() { Console.WriteLine("Animal mkaes a generic sound"); }
    }

    // Derived class
    class Dog : Animal
    {
        public override void MakeSound() { Console.WriteLine("Barking..."); }
    }


    class Cat : Animal
    {
        public override void MakeSound() { Console.WriteLine("Cat is meowing"); } 
    }

    // A breed of dog
    class Collie : Dog
    {
        public void GoingNuts() { Console.WriteLine("Collie going Nuts"); }
    }

}
