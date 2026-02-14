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

            Console.ReadKey();
        }
    }
}
