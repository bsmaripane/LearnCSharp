namespace MultipleConstructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Using multiple constructor!\n");
            Customer belmy = new Customer("Belmy");
            Customer lessego = new Customer("Lesego", "10352 Vergelegen C, JANE FURSE 1085", "+2769 120 0195");
            Customer newCustomer = new Customer();

            belmy.GetDetails();
            lessego.GetDetails();

            newCustomer.SetDetails("MrHacker", "127.0.0.1", "Kali Linux");
            newCustomer.GetDetails();
        
            Console.ReadKey();
        }
    }
}
