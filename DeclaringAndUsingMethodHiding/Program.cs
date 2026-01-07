namespace DeclaringAndUsingMethodHiding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Declaring anf Using Method Hiding\n!");
            Animal animal = new Animal();
            animal.Speak();

            Dog dog = new Dog();
            dog.Speak();

            Animal pet = new Dog();
            pet.Speak();

            Console.ReadKey();
        }
    }


    class Animal
    {
        public void Speak() { Console.WriteLine("The animal makes a sound."); }
    }

    class Dog : Animal
    {
        public new void Speak() { Console.WriteLine("The dog is barks."); } 
    }
}
