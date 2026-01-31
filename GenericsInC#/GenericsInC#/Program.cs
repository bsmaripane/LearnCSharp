namespace GenericsInC_
{
    internal class Program
    {
        static void PrintArray<T>(T[] array)
        {
            foreach (var element in array)
                Console.WriteLine(element);
        }
     

        static void Main(string[] args)
        {
            int[] numbersArray = { 1, 2, 3, 4, 5 };

            PrintArray(numbersArray);

            string[] names = { "Belmy", "Felicia", "Maxine", "Thapelo" };

            PrintArray(names);

            Console.ReadKey();
        }
    }
}
