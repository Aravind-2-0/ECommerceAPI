using ECommerceAPI.Data;
using ECommerceAPI.Models;
using ECommerceAPI.Repository;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrdersController : Controller
    {
        private readonly IOrdersRepository _orders;
        private readonly AppDbContext _context;
        private readonly ILogger<OrdersController> _logger;

        public OrdersController(IOrdersRepository orders, AppDbContext context, ILogger<OrdersController> logger)
        {
            _orders = orders;
            _context = context;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> TotalCustomer(DateTime date)
        {
            try
            {
                var result = await _orders.TotalCustomersAsync(date);
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError("An error occurred while fetching total customers: {Message}", ex.Message);
                return StatusCode(500, "Internal server error");
            }            
        }

        [HttpGet]
        public async Task<IActionResult> TotalOrders(DateTime date)
        {
            try
            {
                var result = await _orders.TotalOrdersAsync(date);
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError("An error ocurred while fetching total orders: {Message}", ex.Message);
                return StatusCode(500, "Internal server error");
            }            
        }

        [HttpGet]
        public async Task<IActionResult> AverageOrders(DateTime date)
        {
            try
            {
                var result = await _orders.AverageOrdervalueAsync(date);
                return Ok(result);
            }
            catch(Exception ex)
            {
                _logger.LogError("An error ocurred while fetching average orders: {Message}", ex.Message);
                return StatusCode(500, "Internal server error");
            }
        }
    }
}