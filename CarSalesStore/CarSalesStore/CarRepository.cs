using Microsoft.EntityFrameworkCore;

namespace CarSalesStore
{
    public class CarRepository : ICarRepository
    {
        private readonly CarSalesStoreContext _context;

        public CarRepository(CarSalesStoreContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Car>> GetAllCarsAsync()
        {
            return await _context.Cars.ToListAsync();
        }

        public async Task<Car?> GetCarByIdAsync(int carId)
        {
            return await _context.Cars.FindAsync(carId);
        }

        public async Task AddCarAsync(Car car)
        {
            await _context.Cars.AddAsync(car);
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
