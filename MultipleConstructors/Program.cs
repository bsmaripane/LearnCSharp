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

            Console.WriteLine($"Name of Customer: {belmy.Name}");
            Console.WriteLine($"Name of Customer: {lessego.Name}");
            Console.WriteLine($"Address of Customer: {lessego.Address}");
            Console.WriteLine($"Contact of Customer: {lessego.ContactNumber}");

            Console.ReadKey();
        }
    }
}
