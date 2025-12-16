namespace DeclareAddAndReadListItem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Declare a List, add and read List item!");
            // Declaring a list and initialising
            List<string > colors = new List<string>();

            // Adding items to the list
            colors.Add("green");
            colors.Add("blue");
            colors.Add("blue");
            colors.Add("blue");
            colors.Add("blue");
            colors.Add("red");
            colors.Add("orange");
            colors.Add("black");

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

            Console.ReadKey();
        }
    }
}
