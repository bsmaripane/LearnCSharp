namespace ArgumentPromotionMethodOverloading
{
    internal class Program
    {

        static void PrintValue(object value)
        {
            Console.WriteLine($"Object value: {value}");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Argument Promotion in Method Overloading");

            int intValue = 30;
            string strValue = "Belmy Semape Maripane!";
            double doubleValue = 11.67;
            float floatValue = 5.89f;

            PrintValue(intValue);        // Calls PrintValue(int)
            PrintValue(strValue);      // Calls PrintValue(string)
            PrintValue(doubleValue);   // Calls PrintValue(object) due to argument promotion
            PrintValue(floatValue);    // Calls PrintValue(object) due to argument promotion

            Console.ReadKey();
        }
    }
}
