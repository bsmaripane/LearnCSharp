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
          
            int height = 20;
            int num = height;

            for (int launch = 0; launch <= height; launch++)
            {
                Console.Clear();
                string repeatNewLine = new string('\n', Math.Abs(num - 1));
                Console.WriteLine(repeatNewLine);
                Console.WriteLine(rocket_launching + "\t\t\t" + (launch * 10) + " meters");
                Thread.Sleep(500);
                num--;
            }
            Console.WriteLine("\nThe rocket has launched. Whoohoo! Another successful launching!");
            Thread.Sleep(3600);
            Console.Clear();
            num = 0;

            for (int land = height; land >= 0; land--)
            {
                Console.Clear();
                string repeatNewLine = new string('\n', num + 1);
                if (land <= 5)
                {
                    Console.WriteLine(repeatNewLine);
                    Console.WriteLine(rocket_launching + "\t\t\t" + (land * 10) + " meters");
                    Thread.Sleep(500);
                }
                else
                {
                    Console.WriteLine(repeatNewLine);
                    Console.WriteLine(rocket_landing + "\t\t\t" + (land * 10) + " meters");
                    Thread.Sleep(500);
                }
                num++;
            }

            Console.WriteLine("\nThe rocket has landed. Whoohoo! Another successful landing!");
            Console.ReadKey();
        }
    }
}
