namespace isAndasOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal myPet = new Dog();

            Console.WriteLine(myPet is Dog ? "myPet is a Dog" : "myPet is NOT a Dog");
           
            Console.ReadKey();
        }
    }
}
