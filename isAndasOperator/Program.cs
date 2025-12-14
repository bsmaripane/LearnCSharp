namespace isAndasOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal myPet = new Dog();

            Console.WriteLine(myPet is Dog ? "myPet is a Dog" : "myPet is NOT a Dog");

            object obj = "Hello C# language";
            if (obj is string message)
                Console.WriteLine($"The message is: {message}");

            Dog myDog = myPet as Dog;
            Console.WriteLine(myDog != null ? "Successfully cast to Dog." : "Conversion failed.");

            Cat myCat = myPet as Cat;
            Console.WriteLine(myCat != null ? "Successfully cast to Dog." : "Conversion failed.");
           
            Console.ReadKey();
        }
    }
}
