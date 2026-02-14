namespace SimpleSynchronousVsAsynchronous
{
    internal class Program
    {
        public static void GetData()
        {
            Thread.Sleep(5000);
            Console.WriteLine("Data Loaded");
        }
        static void Main(string[] args)
        {
            GetData();
            Console.WriteLine("Synchronous Programming");

            Console.ReadKey();
        }
    }
}
