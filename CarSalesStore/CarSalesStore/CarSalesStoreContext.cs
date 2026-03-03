using Microsoft.EntityFrameworkCore;

namespace CarSalesStore
{
    public class CarSalesStoreContext
    {
        public CarSalesStoreContext(DbContextOptions<CarSalesStoreContext> options) : base(options) { }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Sale> Sales { get; set; }
    }
}
