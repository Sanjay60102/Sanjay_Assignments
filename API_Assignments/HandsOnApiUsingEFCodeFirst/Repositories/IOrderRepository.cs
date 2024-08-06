using HandsOnApiUsingEFCodeFirst.Entities;

namespace HandsOnApiUsingEFCodeFirst.Repositories
{
    public interface IOrderRepository
    {
        void MakeOrder(Order order);
        Order GetOrder(int orderId);
        List<Order> GetAllOrders();
    }
}
