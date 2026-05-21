using ECommerceAPI.Models;

namespace ECommerceAPI.Repository
{
    public class OrdersRepository : IOrdersRepository
    {
        private readonly IOrdersRepository _ordersRepository;

        public OrdersRepository(IOrdersRepository ordersRepository)
        {
            _ordersRepository = ordersRepository;
        }

        public async Task<Orderdetails> TotalCustomersAsync(DateTime date)
        {
            return await _ordersRepository.TotalCustomersAsync(date);
        }

        public async Task<Orderdetails> TotalOrdersAsync(DateTime date)
        {
            return await _ordersRepository.TotalOrdersAsync(date);
        }

        public async Task<Orderdetails> AverageOrdervalueAsync(DateTime date)
        {
            return await _ordersRepository.AverageOrdervalueAsync(date);
        }
    }
}
