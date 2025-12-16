namespace DeclareAddAndReadListItem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Declare a List, add and read List item!");
            // Declaring a list and initialising
            List<string > colors =
            [
                // Adding items to the list
                "green",
                "blue",
                "blue",
                "blue",
                "blue",
                "red",
                "orange",
                "black",
            ];

            Console.WriteLine("\nCurrent color:");
            foreach (string color in colors)
                Console.WriteLine(color);

            // Remove item from the list
            bool IsDeletingSuccessful = colors.Remove("red");
            Console.WriteLine(IsDeletingSuccessful ? "The item is successfully removed!" : "The item was not found");
            IsDeletingSuccessful = colors.Remove("pink");
            Console.WriteLine(IsDeletingSuccessful ? "The item is successfully removed!" : "The item was not found");

            Console.WriteLine("\nCurrent after removing red color:");
            foreach (string color in colors) 
                Console.WriteLine(color);

            bool IsBlueDeletingSuccessful = colors.Remove("blue");
            while (IsBlueDeletingSuccessful)
                IsBlueDeletingSuccessful = colors.Remove("blue");

            Console.WriteLine("\nCurrent after removing blue color:");
            foreach (string color in colors) 
                Console.WriteLine(color);

            // Sorting a list
            List<int> numbers = new List<int> { 10, 5, 4, 8, 3, 9, 6, 23, 1 };

            Console.Write("\n\nUnordered list: ");
            foreach (int number in numbers)
                Console.Write(number);

            numbers.Sort();

            Console.Write("\n\nOrdered list: ");
            foreach (int number in numbers)
                Console.Write(number);

            Console.ReadKey();
        }
    }
}
