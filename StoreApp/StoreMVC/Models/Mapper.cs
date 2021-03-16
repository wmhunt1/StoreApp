using StoreModels;

namespace StoreMVC.Models
{
    public class Mapper : IMapper
    {
        //Customer
        public CustomerIndexVM cast2CustomerIndexVM(Customer customer2BCasted)
        {
            return new CustomerIndexVM
            {
                Id = customer2BCasted.Id,
                CustomerName = customer2BCasted.CustomerName,
                CustomerAddress = customer2BCasted.CustomerAddress
            };
        }
        public Customer cast2Customer(CustomerCRVM customer2BCasted)
        {
            return new Customer
            {
                Id = customer2BCasted.Id,
                CustomerName = customer2BCasted.CustomerName,
                CustomerAddress = customer2BCasted.CustomerAddress
            };
        }
        public CustomerCRVM cast2CustomerCRVM(Customer customer)
        {
            return new CustomerCRVM
            {
                Id = customer.Id,
                CustomerName = customer.CustomerName,
                CustomerAddress = customer.CustomerAddress
            };
        }
        public Customer cast2Customer(CustomerEditVM customer2BCasted)
        {
            return new Customer
            {
                Id = customer2BCasted.Id,
                CustomerName = customer2BCasted.CustomerName,
                CustomerAddress = customer2BCasted.CustomerAddress
            };
        }
        public CustomerEditVM cast2CustomerEditVM(Customer customer)
        {
            return new CustomerEditVM
            {
                Id = customer.Id,
                CustomerName = customer.CustomerName,
                CustomerAddress = customer.CustomerAddress
            };
        }
        //Location
        public LocationIndexVM cast2LocationIndexVM(Location location2BCasted)
        {
            return new LocationIndexVM
            {
                Id = location2BCasted.Id,
                LocationName = location2BCasted.LocationName,
                LocationAddress = location2BCasted.LocationAddress
            };
        }
        public Location cast2Location(LocationCRVM location2BCasted)
        {
            return new Location
            {
                Id = location2BCasted.Id,
                LocationName = location2BCasted.LocationName,
                LocationAddress = location2BCasted.LocationAddress
            };
        }
        public LocationCRVM cast2LocationCRVM(Location location)
        {
            return new LocationCRVM
            {
                Id = location.Id,
                LocationName = location.LocationName,
                LocationAddress = location.LocationAddress
            };
        }
        public Location cast2Location(LocationEditVM location2BCasted)
        {
            return new Location
            {
                Id = location2BCasted.Id,
                LocationName = location2BCasted.LocationName,
                LocationAddress = location2BCasted.LocationAddress
            };
        }
        public LocationEditVM cast2LocationEditVM(Location location)
        {
            return new LocationEditVM
            {
                Id = location.Id,
                LocationName = location.LocationName,
                LocationAddress = location.LocationAddress
            };
        }
        //Product
        public ProductIndexVM cast2ProductIndexVM(Product product2BCasted)
        {
            return new ProductIndexVM
            {
                Id = product2BCasted.Id,
                ProductName = product2BCasted.ProductName,
                ProductDesc = product2BCasted.ProductDesc,
                Price = product2BCasted.Price,
                ProductQuantity = product2BCasted.ProductQuantity,
                ProductLocation = product2BCasted.ProductLocation
            };
        }
        public Product cast2Product(ProductCRVM product2BCasted)
        {
            return new Product
            {
                Id = product2BCasted.Id,
                ProductName = product2BCasted.ProductName,
                ProductDesc = product2BCasted.ProductDesc,
                Price = product2BCasted.Price,
                ProductQuantity = product2BCasted.ProductQuantity,
                ProductLocation = product2BCasted.ProductLocation
            };
        }
        public ProductCRVM cast2ProductCRVM(Product product)
        {
            return new ProductCRVM
            {
                Id = product.Id,
                ProductName = product.ProductName,
                ProductDesc = product.ProductDesc,
                Price = product.Price,
                ProductQuantity = product.ProductQuantity,
                ProductLocation = product.ProductLocation
            };
        }
        public Product cast2Product(ProductEditVM product2BCasted)
        {
            return new Product
            {
                Id = product2BCasted.Id,
                ProductName = product2BCasted.ProductName,
                ProductDesc = product2BCasted.ProductDesc,
                Price = product2BCasted.Price,
                ProductQuantity = product2BCasted.ProductQuantity,
                ProductLocation = product2BCasted.ProductLocation
            };
        }
        public ProductEditVM cast2ProductEditVM(Product product)
        {
            return new ProductEditVM
            {
                Id = product.Id,
                ProductName = product.ProductName,
                ProductDesc = product.ProductDesc,
                Price = product.Price,
                ProductQuantity = product.ProductQuantity,
                ProductLocation = product.ProductLocation
            };
        }
        //Order
        public OrderIndexVM cast2OrderIndexVM(Order order2BCasted)
        {
            return new OrderIndexVM
            {
                Id = order2BCasted.Id,
                OrderName = order2BCasted.OrderName,
                OrderCustomerId = order2BCasted.OrderCustomerId,
                OrderLocationId = order2BCasted.OrderLocationId,
                OrderContents = order2BCasted.OrderContents,
                OrderTotal = order2BCasted.OrderTotal,
            };
        }
        public Order cast2Order(OrderCRVM order2BCasted)
        {
            return new Order
            {
                Id = order2BCasted.Id,
                OrderName = order2BCasted.OrderName,
                OrderCustomerId = order2BCasted.OrderCustomerId,
                OrderLocationId = order2BCasted.OrderLocationId,
                OrderContents = order2BCasted.OrderContents,
                OrderTotal = order2BCasted.OrderTotal,
            };
        }
        public OrderCRVM cast2OrderCRVM(Order order)
        {
            return new OrderCRVM
            {
                Id = order.Id,
                OrderName = order.OrderName,
                OrderCustomerId = order.OrderCustomerId,
                OrderLocationId = order.OrderLocationId,
                OrderContents = order.OrderContents,
                OrderTotal = order.OrderTotal,
            };
        }
        public Order cast2Order(OrderEditVM order2BCasted)
        {
            return new Order
            {
                Id = order2BCasted.Id,
                OrderName = order2BCasted.OrderName,
                OrderCustomerId = order2BCasted.OrderCustomerId,
                OrderLocationId = order2BCasted.OrderLocationId,
                OrderContents = order2BCasted.OrderContents,
                OrderTotal = order2BCasted.OrderTotal,
            };
        }
        public OrderEditVM cast2OrderEditVM(Order order)
        {
            return new OrderEditVM
            {
                Id = order.Id,
                OrderName = order.OrderName,
                OrderCustomerId = order.OrderCustomerId,
                OrderLocationId = order.OrderLocationId,
                OrderContents = order.OrderContents,
                OrderTotal = order.OrderTotal,
            };
        }
    }
}
