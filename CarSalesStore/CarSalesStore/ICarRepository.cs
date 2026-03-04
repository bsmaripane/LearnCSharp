namespace CarSalesStore
{
    public interface ICarRepository
    {
        Task<IEnumerable<Car>> GetAllCarsAsync();
        Task<Car?> GetCarByIdAsync(int carId);
        Task AddCarAsync(Car car);
        Task SaveChangesAsync();
    }
}
