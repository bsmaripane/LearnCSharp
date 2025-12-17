namespace UsingListWithComplexObjects
{
    public class Product
    {
        public string Name {  get; set; }
        public double Price { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product> {
                new Product{Name ="Bread", Price = 16.99},
                new Product{Name ="2.25lt Zero Suger Sprite", Price = 21.99},
                new Product{Name ="Butter", Price = 27.99}
            };
            products.Add(new Product { Name = "Milk", Price = 17.99 });

            Console.WriteLine("List of product:");
            foreach(Product p in products) 
                Console.WriteLine($"{p.Name}: R{p.Price,2}");

            Console.ReadKey();
        }
    }
}
