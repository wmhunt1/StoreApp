using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using StoreModels;

namespace StoreDL
{
    public class OrderRepoDB : IOrderRepository
    {
        private readonly StoreDBContext _context;
        public OrderRepoDB(StoreDBContext context)
        {
            _context = context;
        }
        public Order AddOrder(Order newOrder)
        {
            _context.Orders.Add(newOrder);
            _context.SaveChanges();
            return newOrder;
        }

        public Order DeleteOrder(Order order2BDeleted)
        {
            _context.Orders.Remove(order2BDeleted);
            _context.SaveChanges();
            return order2BDeleted;
        }

        public List<Order> GetOrders()
        {
            return _context.Orders
                .AsNoTracking()
                .Select(order => order)
                .ToList();
        }

        public Order UpdateOrder(Order order2BUpdated)
        {
            return order2BUpdated;
        }
    }
    
}