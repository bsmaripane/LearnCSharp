namespace SealedMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Demo of the Sealad Method in C#!\n");

            Animal animal = new Animal();
            animal.MakeSound();

            Dog dog = new Dog();
            dog.MakeSound();

            Cat cat = new Cat();
            cat.MakeSound();

            Animal bulldog = new Dog();
            bulldog.MakeSound();

            PitBull pitBull = new PitBull();
            pitBull.MakeSound();

            Console.ReadKey();
        }
    }


    class Animal
    {
        public virtual void MakeSound() { Console.WriteLine("The animal makes a sound"); }
    }

    class Dog : Animal
    {
        public sealed override void MakeSound() { Console.WriteLine("The dog barks."); }
    }

    class PitBull : Dog {}

    class Cat : Animal
    {
        public override void MakeSound() { Console.WriteLine("A cat meows."); }
    }
}
