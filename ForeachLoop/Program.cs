namespace ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            List<int> numbers = new List<int> {1, 2, 3, 4, 5, 6, 7};

            foreach (var number in numbers)
                Console.WriteLine(number);
        }
    }
}
