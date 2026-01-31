namespace GenericsInC_
{
    internal class Program
    {
        static void PrintArray(int[] numbersArray)
        {
            foreach (var number in numbersArray)
                Console.WriteLine(number);
        }
        static void Main(string[] args)
        {
            int[] numbersArray = { 1, 2, 3, 4, 5 };

            PrintArray(numbersArray);

            Console.ReadKey();
        }
    }
}
