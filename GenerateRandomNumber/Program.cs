namespace GenerateRandomNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Generate a random number!\n");

            // Creating an instance of the Random Class
            Random random = new Random();

            // Generate random number between 1 and 50
            int randomNumber = random.Next(1, 50);

            Console.WriteLine("Guess thr number");
            string inputString = Console.ReadLine();

            int num1 = 0;
            bool isNumber = int.TryParse(inputString, out num1);

            if (isNumber)
            {
                Console.WriteLine("Well done, you have entered a number");

                if (num1 == randomNumber)
                {
                    Console.WriteLine("Wow, great guess");
                }
                else
                {
                    Console.WriteLine("Sorry, guessed wrong!");
                }

                Console.WriteLine($"\nRandom number: {randomNumber} and entered number: {num1}");
            }
            else
            {
                Console.WriteLine("Haha you troil. You shoud've entered a number");
            }

            

            Console.ReadKey();
        }
    }
}
