namespace RelationalOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 6;

            // Relational operators
            // <  less than
            // <=  less or equal to
            // > greater than
            // >=  greater or equal to

            bool isHigher =  num1 > num2;

            int age = 89;

            if (age >= 18 && age < 60)
                Console.WriteLine("Go party in the club!");
            else if (age >= 60)
                Console.WriteLine("Too old for club, look after grandkids!");
            else if (age > 5)
                Console.WriteLine("Go to school!");
            else
                Console.WriteLine("Go watch cocomelon!");
        }
    }
}
