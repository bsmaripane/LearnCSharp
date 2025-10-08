namespace DoWhileLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int currentScore;
            int sum = 0;
            int counter = 0;
            do
            {
                Console.WriteLine("Enter your student score. Enter -1 to finish!");
                currentScore = int.Parse(Console.ReadLine());

                if (currentScore != -1)
                {
                    sum += currentScore;
                    counter++;
                }
            }
            while (currentScore != -1);

            int averageScore = sum / counter;
            Console.WriteLine($"The student average score is {averageScore}");

            Console.ReadKey();
        }
    }
}
