// Challenge: Rocket Landing Simulation
// Create a fun and interactive console application in C# that simulates a rocket landing.
namespace Challenge_Rocket_Landing_Simulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // String that represents the rocket
            string rocket_landing = """
                 |\_/\_/|
                 \      /
                  |    |
                  | 0  |
                  |    |
                  \    /
                   \  /
                    \/
                """;
            int num = 0;
            for (int launch = 10; launch >= 0; launch--)
            {          
                string repeatNewLine = new string('\n', num + 1);
                Console.WriteLine(repeatNewLine);
                Console.WriteLine("\n" + rocket_landing + "\t\t\t" + (launch * 10) + " meters");
                Thread.Sleep(1500);
                Console.Clear();
                num++;
            }
            Console.ReadKey();
        }
    }
}
