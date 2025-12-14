using System.ComponentModel;

namespace OperatorOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Using Operator Overloading!\n]");

            Vector v1 = new Vector(3, 5);
            Vector v2 = new Vector(7, 2);
            Vector result = v1 + v2;

            result.Display();

            Vector vec1 = new Vector(11, 3);
            Vector vec2 = new Vector(30, 32);
            Vector vecResult = vec1.Add(vec2);

            vecResult.Display();

            Console.ReadKey();
        }
    }
}
