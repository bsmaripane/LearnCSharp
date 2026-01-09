namespace CreateFileApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            File.AppendAllText("C:\\Users\\bsmar\\OneDrive\\Desktop\\Udemy\\LearnCSharp\\CreateFileApp\\Log.txt", "Hello World\n");

            Console.ReadKey();
        }
    }
}
