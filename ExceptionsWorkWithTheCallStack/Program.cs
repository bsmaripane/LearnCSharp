namespace ExceptionsWorkWithTheCallStack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                LevelOne();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception caught in Main: {ex.Message}");
            }
            
            Console.ReadKey();
        }

        static void LevelOne()
        {
            LevelTwo();
        }

        static void LevelTwo()
        {
            throw new Exception("Something went wrong!");
        }
    }
}
