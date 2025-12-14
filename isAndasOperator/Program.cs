namespace isAndasOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal myPet = new Dog();

            if (myPet is Dog)
                Console.WriteLine("myPet is a Dog");
            else
                Console.WriteLine("myPet is NOT a Dog");

            Console.ReadKey();
        }
    }
}
