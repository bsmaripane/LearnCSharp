namespace GuessNumberWhileLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 53;
            int guessedNumber = 0;
            bool isValid = true;
            int counter = 0;


            while (isValid)
            {
                ++counter;
                Console.WriteLine($"Number of Tries: {counter}");

                Console.Write("Guess the number: ");
                bool isNumber = int.TryParse( Console.ReadLine(), out guessedNumber );

                if (isNumber)
                {
                    if (guessedNumber < number)
                        Console.WriteLine("Too low! Try again.");
                    else if (guessedNumber > number)
                        Console.WriteLine("Too high! Tyr again.");
                    else
                    {
                        Console.WriteLine($"\n\nCongratulations! You gessed the number right! It took you {counter} tries");
                        isValid = false;
                    }
                }
                else
                    Console.WriteLine($"\n\nError: {guessedNumber} is not a valid number! try again!");

                if (counter == 5)
                {
                    Console.WriteLine($"\n\nFailed the guess number! \nMaximum of {counter} tries reached.");
                    isValid = false;
                }
            }

            Console.ReadKey();
        }
    }
}
