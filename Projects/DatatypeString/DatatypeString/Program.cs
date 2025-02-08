namespace DatatypeString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, \n");
            string myname = "Belmy";
            string message = "\nDon't have a good day, have a great day";
          
            Console.WriteLine("My name is " + myname.ToUpper() + message);
            Console.Read();

        }
    }
}
