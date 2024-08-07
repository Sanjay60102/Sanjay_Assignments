using HandsOnApiUsingEFCodeFirst.Entities;

namespace HandsOnApiUsingEFCodeFirst.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly ECommContext _context;

        public OrderRepository(ECommContext context)
        {
            _context = context;
        }

        //public OrderRepository()
        //{
        //    _context = new ECommContext();
        //}
        public List<Order> GetAllOrders()
        {
            return _context.Orders.ToList();
        }

        public Order GetOrder(Guid Id)
        {
            var order = _context.Orders.Find(Id);
            return order;
        }

        public Order GetOrder(int orderId)
        {
            throw new NotImplementedException();
        }

        public void MakeOrder(Order order)
        {
            _context.Orders.Add(order);
            _context.SaveChanges();
        }

        
    }
}
