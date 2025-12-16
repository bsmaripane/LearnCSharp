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
            colors.Add("red");
            colors.Add("orange");
            colors.Add("black");

            Console.WriteLine("\nCurrent color:");
            foreach (string color in colors)
                Console.WriteLine(color);

            // Remove item from the list
            colors.Remove("red");

            Console.WriteLine("\nCurrent after removing color:");
            foreach (string color in colors) 
                Console.WriteLine(color);

            Console.ReadKey();
        }
    }
}
