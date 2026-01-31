namespace GenericsInC_
{
    internal class Program
    {
        static void PrintArray<Type>(Type[] array)
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

            double[] decArray = { 5.7, 78.4, 1.67, 4.5 };

            PrintArray(decArray);

            Console.ReadKey();
        }
    }
}
