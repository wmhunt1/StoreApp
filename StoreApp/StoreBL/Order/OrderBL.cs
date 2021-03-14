using System;
using System.Collections.Generic;
using StoreDL;
using StoreModels;

namespace StoreBL
{
    public class OrderBL : IOrderBL
    {
        private IOrderRepository _repo;
        public OrderBL(IOrderRepository repo)
        {
            _repo = repo;
        }
       public void AddOrder(Order newOrder)
        {
            //Todo: Add BL
            _repo.AddOrder(newOrder);
        }
        public List<Order> GetOrders()
        {
            //TODO add BL
            return _repo.GetOrders();
        }

        public Order DeleteOrder(Order order2BDeleted)
        {
            return _repo.DeleteOrder(order2BDeleted);
        }
        public Order UpdateOrder(Order order2BUpdated)
        {
            return _repo.UpdateOrder(order2BUpdated);
        }

        public Order GetOrderByName(string name)
        {
            //Todo: check if the name given is not null or empty string 
            return _repo.GetOrderByName(name);
        }
    }
}