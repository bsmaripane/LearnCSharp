using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentApp.Models;
using Xunit;

namespace StudentApp.Tests
{
    public class SalesServiceTests
    {
        [Fact]
        public async Task Should_Calculate_Total_Sales_For_Customer()
        {
            // Arrange
            var fakeRepo = new FakeOrderRepository();

            fakeRepo.Orders = new List<Order>
            (
                new Order { CustomerId = 1, Amount = 100},
                new Order { CustomerId = 1, Amount = 200},
                new Order { CustomerId = 2, Amount = 500}
            );

            var service = new SalesService(fakeRepo);

            // Act
            var total = await service.GetTotalSalesAsync(1);

            // Assert
            Assert.Equal(300, total);
        }
    }
}
