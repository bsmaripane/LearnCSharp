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
            int num = 0;

            for (int launch = 20; launch >= 0; launch--)
            {
                
                string repeatNewLine = new string('\n', launch + 1);
                Console.WriteLine(repeatNewLine);
                Console.WriteLine(rocket_launching + "\t\t\t" + (num * 10) + " meters");
                Thread.Sleep(500);
                Console.Clear();
                num++;
            }
            Console.WriteLine("\nThe rocket has launched. Whoohoo! Another successful launching!");
            Thread.Sleep(3600);
            Console.Clear();
            num = 0;

            for (int launch = 20; launch >= 0; launch--)
            {          
                string repeatNewLine = new string('\n', num + 1);
                Console.WriteLine(repeatNewLine);
                Console.WriteLine(rocket_landing + "\t\t\t" + (launch * 10) + " meters");
                Thread.Sleep(500);
                Console.Clear();
                num++;
            }

            Console.WriteLine("\nThe rocket has landed. Whoohoo! Another successful landing!");
            Console.ReadKey();
        }
    }
}
