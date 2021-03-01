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
                CustomerId = customer.CustomerId
            };
        }

        public Entity.Customer ParseCustomer(Model.Customer customer)
        {
            if (customer.CustomerId == null)
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
                CustomerId = (int)customer.CustomerId
            };

        }
        public Model.Order ParseOrder(Entity.Order order)
        {
            return new Model.Order
            {
                //OrderCustomerId = ParseCustomer(order.OrderCustomerId),
                OrderCustomerId = (int)order.OrderCustomerId,
                OrderId = order.OrderId,
                OrderLocation = order.OrderLocation,
                OrderAddress = order.OrderAddress,
                OrderQuantity1 = (int)order.OrderQuantity1,
                OrderQuantity2 = (int)order.OrderQuantity2,
                OrderQuantity3 = (int)order.OrderQuantity3,
                 OrderTotal = (decimal)order.OrderTotal
            };
        }

        public Entity.Order ParseOrder(Model.Order order)
        {
            if (order.OrderId == null)
            {
                return new Entity.Order
                {
                    //OrderCustomerId = ParseCustomer(order.OrderCustomerId),
                    OrderCustomerId = (int)order.OrderCustomerId,
                    OrderLocation = order.OrderLocation,
                    OrderAddress = order.OrderAddress,
                    OrderQuantity1 = (int)order.OrderQuantity1,
                    OrderQuantity2 = (int)order.OrderQuantity2,
                    OrderQuantity3 = (int)order.OrderQuantity3,
                    OrderTotal = (decimal)order.OrderTotal
                };
            }
            //for updating and deletion purposes
            return new Entity.Order
            {
                //OrderCustomerId = ParseCustomer(order.OrderCustomerId),
                OrderCustomerId = (int)order.OrderCustomerId,
                OrderId = (int)order.OrderId,
                OrderLocation = order.OrderLocation,
                OrderAddress = order.OrderAddress,
                OrderQuantity1 = (int)order.OrderQuantity1,
                OrderQuantity2 = (int)order.OrderQuantity2,
                OrderQuantity3 = (int)order.OrderQuantity3,
                OrderTotal = (decimal)order.OrderTotal
            };

        }
        public Model.Location ParseLocation(Entity.Location location)
        {
            return new Model.Location
            {
                LocationName = location.LocationName,
                StreetAddress = location.StreetAddress,
                LocationInventory = location.LocationInventory
            };
        }

        public Entity.Location ParseLocation(Model.Location location)
        {

            //for updating and deletion purposes
            return new Entity.Location
            {
                LocationName = location.LocationName,
                StreetAddress = location.StreetAddress,
                LocationInventory = location.LocationInventory
            };

        }
        public Model.Product ParseProduct(Entity.Product product)
        {
            return new Model.Product
            {
                ProductName = product.ProductName,
                Price = product.Price,
            };
        }

        public Entity.Product ParseProduct(Model.Product product)
        {
            //for updating and deletion purposes
            return new Entity.Product
            {
                ProductName = product.ProductName,
                Price = product.Price,
            };

        }
    }
}