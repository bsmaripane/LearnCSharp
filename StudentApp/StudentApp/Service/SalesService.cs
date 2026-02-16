using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentApp.Data;
using StudentApp.Models;

namespace StudentApp.Service
{
    public class SalesService
    {
        private readonly IOrderRepository _repository;

        public SalesService(IOrderRepository repository)
        {
            _repository = repository;
        }

        public async Task<decimal> GetTotalSalesAsync(int customerId)
        {
            var orders = await _repository.GetOrdersByCustomerAsync(customerId);

            return orders.Sum(o => o.Amount);
        }
    }
}
