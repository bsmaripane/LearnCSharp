namespace CreateFileApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string directoryPath = "C:\\Users\\bsmar\\OneDrive\\Desktop\\Udemy\\LearnCSharp\\CreateFileApp\\";
            string filePath = Path.Combine(directoryPath, "log.txt");
           
            if (!Directory.Exists(filePath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            File.AppendAllText(filePath, "Today is going to be a great day!\n");

            Console.ReadKey();
        }
    }
}
