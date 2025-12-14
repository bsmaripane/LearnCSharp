namespace PassingArgumentsToMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Passing Arguments by Value!\n");
            int number = 11;
            ModifyValue(number);
            Console.WriteLine(number);

            Console.ReadKey();
        }

        static void ModifyValue(int num)
        {
            num = 100;
        }
    }
}
