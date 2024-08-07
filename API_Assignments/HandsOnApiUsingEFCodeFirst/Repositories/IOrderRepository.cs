using HandsOnApiUsingEFCodeFirst.Entities;

namespace HandsOnApiUsingEFCodeFirst.Repositories
{
    public interface IOrderRepository
    {
        void MakeOrder(Order order);
        Order GetOrder(Guid orderId);
        List<Order> GetAllOrders();
        
    }
}
