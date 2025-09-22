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

            Console.WriteLine(rocket_launching);
            Console.WriteLine(rocket_landing);
            Console.ReadKey();
        }
    }
}
