
using CarSalesStore.Data;
using CarSalesStore.Repositories.Implementations;
using CarSalesStore.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CarSalesStore
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddDbContext<CarSalesStoreContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("CarSalesStoreDb") ?? throw new InvalidOperationException("Connection string 'CarSalesStoreContext' not found.")));

            builder.Services.AddScoped<ICarRepository, CarRepository>();

            builder.Services.AddControllers();
            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
            builder.Services.AddOpenApi();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
