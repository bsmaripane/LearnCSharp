using CarSalesStore.Models;
using Microsoft.EntityFrameworkCore;

namespace CarSalesStore.Data
{
    public class CarSalesStoreContext : DbContext
    {
        public CarSalesStoreContext(DbContextOptions<CarSalesStoreContext> options) : base(options) { }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Sale> Sales { get; set; }
    }
}
