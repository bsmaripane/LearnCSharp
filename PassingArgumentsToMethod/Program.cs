namespace PassingArgumentsToMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Passing Arguments by Value!");
            int number = 11;
            ModifyValue(number);
            Console.WriteLine(number);

            Console.WriteLine("Passing Arguments by Reference - ref");
            ChangeValue(ref number);
            Console.WriteLine(number);

            Console.ReadKey();
        }

        static void ModifyValue(int num)
        {
            num = 100;
        }

        static void ChangeValue(ref int num)
        {
            num = 250;
        }
    }
}
