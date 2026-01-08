namespace FileOperation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamWriter sw = new StreamWriter("file.txt"))
            {
                sw.WriteLine("My name is Belmy Semape Maripane,\nI love Felicia van der Merwe, actually I'm in love with her, she is my everything,\nand I truly want to marry her before end of 2026.");
            }

            using (StreamReader sr = new StreamReader("file.txt"))
            {
                string content = sr.ReadToEnd();
                Console.WriteLine(content);
            }
            
            Console.ReadKey();
        }
    }
}
