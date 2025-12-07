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

            var ages = new int[] { 3, 11, 30, 32,  53 };

            Calculator addition = new Calculator();
            int x = addition.add(a, b);

            Console.WriteLine(x);
            Console.WriteLine($"Age: Lesego + Kganya = {addition.add(ages[1], ages[0])}");
            Console.WriteLine($"Age: Lesego - Kganya = {addition.add(ages[1], -ages[0])}");
            Console.WriteLine($"Age: Belmy + Tracy = {addition.add(ages[2], ages[3])}");
            Console.WriteLine($"Age: Belmy - Tracy = {addition.add(ages[2], -ages[3])}");
            Console.WriteLine($"Age: Emily - Tracy = {addition.add(ages[4], -ages[3])}");
            Console.WriteLine($"Age: Emily - Belmy = {addition.add(ages[4], -ages[2])}");

            Console.ReadKey();
        }
    }
}
