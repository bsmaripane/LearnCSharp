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

            foreach (string color in colors) 
                Console.WriteLine($"Current color: {color}");

            Console.ReadKey();
        }
    }
}
