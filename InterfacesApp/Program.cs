namespace InterfacesApp
{
    public class Animal
    {
        public virtual void MakeSound() { Console.WriteLine("Some generic animal sound"); }
    }

    public class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Dog barks");
        }
    }

    public class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Cat meows");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Animal dog = new Dog();
            dog.MakeSound();

            Animal cat = new Cat();
            cat.MakeSound();

            Console.ReadKey();
        }
    }
}
