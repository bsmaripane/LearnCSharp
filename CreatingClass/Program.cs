namespace CreatingClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creating a Class!");
            Car audi = new Car("RS3", "Audi", true);
            Car bmw = new Car("325is", "BMW");

            Console.Write("Please enter the car Brand: ");
            audi.Brand = Console.ReadLine() ?? "";

            Console.WriteLine($"The brand is {audi.Brand}");
            Console.WriteLine($"The brand is {bmw.Brand}");
            audi.Drive();
            bmw.Drive();

            // Create instance of the inner class
            OuterClass outerObject = new OuterClass();
            OuterClass.InnerClass innerObject = new OuterClass.InnerClass(outerObject);
            innerObject.DisplayMessage();
            innerObject.DisplayOuterField();   

            // Using a static nested class
            OuterClass.StaticNestedClass.ShowMessage();

            Console.ReadKey();
        }
    }
}
