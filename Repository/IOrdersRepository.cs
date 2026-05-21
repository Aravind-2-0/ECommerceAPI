using ECommerceAPI.Models;
namespace ECommerceAPI.Repository
{
    public interface IOrdersRepository
    {
        public Task<Orderdetails> TotalCustomersAsync(DateTime date);
        public Task<Orderdetails> TotalOrdersAsync(DateTime date);
        public Task<Orderdetails> AverageOrdervalueAsync(DateTime date);
    }
}
