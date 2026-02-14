using System.Threading.Tasks;

namespace SimpleSynchronousVsAsynchronous
{
    internal class Program
    {
        public static async Task GetData()
        {
            await Task.Delay(5000);
            Console.WriteLine("Data Loaded");
        }
        static void Main(string[] args)
        {
            _ = GetData();
            Console.WriteLine("Asynchronous Programming");


            Task.Run(() =>
            {
                Console.WriteLine("Running on another thread");
                _ = GetData();
                Console.WriteLine("Thread completed!");
            });

            Console.ReadKey();
        }

    }
}
