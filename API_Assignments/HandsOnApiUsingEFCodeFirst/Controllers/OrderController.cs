using HandsOnApiUsingEFCodeFirst.Entities;
using HandsOnApiUsingEFCodeFirst.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace HandsOnApiUsingEFCodeFirst.Controllers
{
    [Route("api/controller")]
    [ApiController]
    public class OrderController : Controller
    {
        private readonly IOrderRepository _orderRepository;
        public OrderController()
        {
            _orderRepository = new OrderRepository();
        }
        [HttpPost, Route("AddOrder")]
        public IActionResult MakeOrder(Order order)
        {
            _orderRepository.MakeOrder(order);
            return StatusCode(200, order);
        }
        [HttpGet, Route("GetOrder/{id}")]
        public IActionResult GetOrder([FromRoute]int id)
        {
            var order = _orderRepository.GetOrder(id);
            if (order != null)
                return StatusCode(200, order);
            else
                return StatusCode(404, "invalid Id");
        }
        [HttpGet, Route("GetOrders")]
        public IActionResult GetAllOrders()
        {
            var orders = _orderRepository.GetAllOrders();
            return StatusCode(200, orders);
        }
    }
}
