using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentApp.Models;
using StudentApp.Data;

namespace StudentApp.Data
{
    public class FakeOrderRepository : IOrderRepository
    {
        public List<Order> Orders { get; set; } = new();

        public Task<List<Order>> GetOrdersByCustomerAsync(int customerId)
        {
            var result = Orders.Where(o => o.CustomerId == customerId).ToList();

            return Task.FromResult(result);
        }
    }
}
