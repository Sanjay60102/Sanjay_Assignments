using HandsOnApiUsingEFCodeFirst.Entities;
using HandsOnApiUsingEFCodeFirst.Repositories;
using HandsOnAPIUsingEFCodeFirst.DTOS;
using Microsoft.AspNetCore.Mvc;

namespace HandsOnApiUsingEFCodeFirst.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderRepository _orderRepository;

        public OrderController(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        //public OrderController()
        //{
        //    _orderRepository = new OrderRepository();
        //}
        [HttpPost, Route("MakeOrder")]
        public IActionResult MakeOrder(OrderDTO orderDto)
        {
            //assing orderDto to order entity
            var order = new Order()
            {
                OrderId = Guid.NewGuid(),
                ProductId = orderDto.ProductId,
                UserId = orderDto.UserId
            };

            _orderRepository.MakeOrder(order);
            return Ok(order);
        }
        [HttpGet, Route("GetOrder/{id}")]
        public IActionResult GetOrder([FromRoute]Guid id)
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
