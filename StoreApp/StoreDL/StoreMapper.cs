using Model = StoreModels;
using Entity = StoreDL.Entities;
using StoreModels;
using StoreDL.Entities;
namespace StoreDL
{
    public class StoreMapper : IMapper
    {
        public Model.Customer ParseCustomer(Entity.Customer customer)
        {
            return new Model.Customer
            {
                CustomerName = customer.CustomerName,
                CustomerAddress = customer.CustomerAddress,
                CId = customer.CId
            };
        }

        public Entity.Customer ParseCustomer(Model.Customer customer)
        {
            // For when you add a new hero, Id isn't set yet
            if (customer.CId == null)
            {
                return new Entity.Customer
                {
                    CustomerName = customer.CustomerName,
                    CustomerAddress = customer.CustomerAddress,
                };
            }
            //for updating and deletion purposes
            return new Entity.Customer
            {
                CustomerName = customer.CustomerName,
                CustomerAddress = customer.CustomerAddress,
                CId = (int)customer.CId
            };

        }
        public Model.Order ParseOrder(Entity.Order order)
        {
            return new Model.Order
            {
            OrderCustomer = ParseCustomer(order.OrderCustomer),
            OrderId = order.OrderId
            };
        }

        public Entity.Order ParseOrder(Model.Order order)
        {
            // For when you add a new hero, Id isn't set yet
            if (order.OrderId == null)
            {
                return new Entity.Order
                {
                    OrderCustomer = ParseCustomer(order.OrderCustomer),
                };
            }
            //for updating and deletion purposes
            return new Entity.Order
            {
                OrderCustomer = ParseCustomer(order.OrderCustomer),
                OrderId = (int)order.OrderId
            };

        }
    }
}