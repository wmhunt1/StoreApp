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
                CustomerName = customer2BCasted.CustomerName,
                CustomerAddress = customer2BCasted.CustomerAddress
            };
        }
        public Customer cast2Customer(CustomerCRVM customer2BCasted)
        {
            return new Customer
            {
                CustomerName = customer2BCasted.CustomerName,
                CustomerAddress = customer2BCasted.CustomerAddress
            };
        }
        public CustomerCRVM cast2CustomerCRVM(Customer customer)
        {
            return new CustomerCRVM
            {
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
                LocationName = location2BCasted.LocationName,
                LocationAddress = location2BCasted.LocationAddress
            };
        }
        public Location cast2Location(LocationCRVM location2BCasted)
        {
            return new Location
            {
                LocationName = location2BCasted.LocationName,
                LocationAddress = location2BCasted.LocationAddress
            };
        }
        public LocationCRVM cast2LocationCRVM(Location location)
        {
            return new LocationCRVM
            {
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
                ProductName = product2BCasted.ProductName,
                ProductDesc = product2BCasted.ProductDesc,
                Price = product2BCasted.Price
            };
        }
        public Product cast2Product(ProductCRVM product2BCasted)
        {
            return new Product
            {
                ProductName = product2BCasted.ProductName,
                ProductDesc = product2BCasted.ProductDesc,
                Price = product2BCasted.Price
            };
        }
        public ProductCRVM cast2ProductCRVM(Product product)
        {
            return new ProductCRVM
            {
                ProductName = product.ProductName,
                ProductDesc = product.ProductDesc,
                Price = product.Price
            };
        }
        public Product cast2Product(ProductEditVM product2BCasted)
        {
            return new Product
            {
                Id = product2BCasted.Id,
                ProductName = product2BCasted.ProductName,
                ProductDesc = product2BCasted.ProductDesc,
                Price = product2BCasted.Price
            };
        }
        public ProductEditVM cast2ProductEditVM(Product product)
        {
            return new ProductEditVM
            {
                Id = product.Id,
                ProductName = product.ProductName,
                ProductDesc = product.ProductDesc,
                Price = product.Price
            };
        }
        //Order
    }
}
