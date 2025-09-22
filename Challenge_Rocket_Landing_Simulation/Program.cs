// Challenge: Rocket Landing Simulation
// Create a fun and interactive console application in C# that simulates a rocket landing.
namespace Challenge_Rocket_Landing_Simulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // String that represents the rocket
            string rocket_launching = """
                    /\
                   /  \
                  /    \
                  |    |
                  |  O |
                  |    |
                 /      \
                 |/-\/-\|

                """;
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

            for (int launch = 10; launch >= 0; launch--)
            {
                Console.WriteLine(rocket_landing + "\t" + (launch * 10) + " meters");
                Thread.Sleep(1500);
            }
            Console.ReadKey();
        }
    }
}
