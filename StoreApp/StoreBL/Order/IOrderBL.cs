using StoreModels;
using System.Collections.Generic;
namespace StoreBL
{
    public interface IOrderBL
    {
       List<Order> GetOrders();
        void AddOrder(Order newOrder);
        Order DeleteOrder(Order order2BDeleted);

        Order UpdateOrder(Order order2BUpdated);
    }
}