namespace DicktionaryWithStringKey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declarin and initialising a dictionary of string key
            var codes = new Dictionary<string, string>
            {
                ["NY"] = "New York",
                ["CA"] = "California",
                ["TX"] = "Texas"
            };

            if (codes.TryGetValue("NY", out string state))
                Console.WriteLine(state);

            Console.ReadKey();
        }
    }
}
