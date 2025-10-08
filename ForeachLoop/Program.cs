namespace ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] weekDays = ["Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"];

            foreach (var item in weekDays)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
