namespace CreatingClass
{
    public class Calculator
    {
        public int add(int x, int y) => x+y;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C# Creating a class and object!");

            int a = 11;
            int b = 3;

            Calculator addition = new Calculator();
            int x = addition.add(a, b);

            Console.WriteLine(x);
            Console.WriteLine(addition.add(32, 30));
            Console.WriteLine(addition.add(56, -53));
            Console.WriteLine(addition.add(56, -32));
            Console.WriteLine(addition.add(56, -30));
            Console.WriteLine(addition.add(53, -32));
            Console.WriteLine(addition.add(53, -30));

            Console.ReadKey();
        }
    }
}
