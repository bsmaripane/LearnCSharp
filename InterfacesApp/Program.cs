namespace InterfacesApp
{
    public interface IAnimal
    {
        void MakeSound();
        void Eat(string food);
    }

    public class Dog : IAnimal
    {
        public void Eat(string food)
        {
            Console.WriteLine($"Dog eat {food}");
        }

        public void MakeSound()
        {
            Console.WriteLine("Dog barks");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.Eat("bones");
            dog.MakeSound();

            Console.ReadKey();
        }
    }
}
