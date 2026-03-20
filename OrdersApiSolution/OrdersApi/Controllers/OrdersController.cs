using Microsoft.AspNetCore.Mvc;
using OrdersApi.Services;
using OrdersApi.DTOs;
using OrdersApi.Models;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace OrdersApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrdersController : ControllerBase
    {
        private readonly OrderService _service;

        public OrdersController(OrderService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> CreateOrder([FromBody] OrderDto dto)
        {
            var order = new Order
            {
                ProductName = dto.ProductName,
                Quantity = dto.Quantity,
                Price = dto.Price
            };
            var created = await _service.CreateOrderAsync(order);
            return CreatedAtAction(nameof(GetOrderById), new { id = created.Id }, created);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetOrderById(int id)
        {
            var orders = await _service.GetOrdersAsync();
            var order = orders.FirstOrDefault(o => o.Id == id);
            if (order == null) return NotFound();
            return Ok(order);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllOrders()
        {
            var orders = await _service.GetOrdersAsync();
            return Ok(orders);
        }
    }
}