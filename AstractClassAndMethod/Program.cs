namespace AstractClassAndMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Defining an Astract Class and Method!\n");


            Console.ReadKey();
        }
    }

    abstract class Animal
    {
        public abstract void MakeSound();
        public void Sleep() { Console.WriteLine("Sleeping..."); }
    }


}
