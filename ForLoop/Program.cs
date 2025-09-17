namespace ForLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {
                if (i == 3) Console.WriteLine($"Kganya is {i} years old");
                if (i == 11) Console.WriteLine($"Lesego is {i} years old");
                if (i == 25) Console.WriteLine($"Felicia and I celebrate 4th annervesary on {i} of Sep 20{i}");
                if (i == 29) Console.WriteLine($"Felicia is turning {i} years old on the 31st Dec 2025");
                if (i == 30) Console.WriteLine($"I'm getting old... {i} years old!");
                if (i == 32) Console.WriteLine($"My sister is turning {i} years old on the 28th Dec 2025");
                if (i == 53) Console.WriteLine($"My mom is {i} years old");
            }
            Console.ReadKey();
        }
    }
}
