namespace UseTryParse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a number");
            string inputString = Console.ReadLine();
            int num1;
            //int num1 = int.Parse(inputString);
            bool isNumber = int.TryParse(inputString, out num1);

            if (isNumber)
                Console.WriteLine("Well done, you entered a number");
            else
                Console.WriteLine("Haha you troll, You should've entered a number");

            num1++;
            Console.WriteLine("User entered number +1 " + num1);

            Console.ReadKey();
        }
    }
}
