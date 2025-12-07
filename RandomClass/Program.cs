namespace RandomClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            const int passwordLength = 20;
            var buffer = new char[passwordLength];

            for (var index = 0; index < passwordLength; index++)
                buffer[index] = (char)('!'+random.Next(0, 95));

            var password = new string(buffer);
            Console.WriteLine($"Password phrase: { password}");

            Console.ReadKey();
        }
    }
}
