namespace SealedMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Demo of the Sealad Method in C#!\n");


            Console.ReadKey();
        }
    }


    class Animal
    {
        public virtual void MakeSound() { Console.WriteLine("The animal makes a sound"); }
    }


}
