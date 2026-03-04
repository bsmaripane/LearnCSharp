namespace CarSalesStore
{
    public class Sale
    {
        public int SaleId { get; set; }
        public int CarId { get; set; }
        public Car? car { get; set; }
        public int CustomerId { get; set; }
        public Customer? customer { get; set; }
        public DateTime SaleDate { get; set; }
    }
}
