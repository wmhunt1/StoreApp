using StoreModels;

namespace StoreMVC.Models
{
    public class Mapper : IMapper
    {
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
    }
}
