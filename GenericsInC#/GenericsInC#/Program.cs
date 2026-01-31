namespace GenericsInC_
{
    internal class Program
    {
        static void PrintArray(int[] numbersArray)
        {
            foreach (var number in numbersArray)
                Console.WriteLine(number);
        }
        static void PrintArray(string[] wordsArray)
        {
            foreach (var word in wordsArray)
                Console.WriteLine(word);
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
