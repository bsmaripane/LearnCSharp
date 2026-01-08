namespace InterfacesApp
{
    public interface IAnimal
    {
        void MakeSound();
        string Eat(string food);
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
