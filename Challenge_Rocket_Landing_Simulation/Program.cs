// Challenge: Rocket Landing Simulation
// Create a fun and interactive console application in C# that simulates a rocket landing.
namespace Challenge_Rocket_Landing_Simulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // String that represents the rocket
            string rocket = """
                    /\
                   /  \
                   |  |
                   |  |
                  /    \
                  |/\/\|

                """;

            Console.WriteLine(rocket);
            Console.ReadKey();
        }
    }
}
