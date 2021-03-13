using StoreModels;

namespace StoreMVC.Models
{
    public interface IMapper
    {
        Customer cast2Customer(CustomerCRVM customer2BCasted);
        CustomerIndexVM cast2CustomerIndexVM(Customer customer2BCasted);
        CustomerCRVM cast2CustomerCRVM(Customer customer);
        CustomerEditVM cast2CustomerEditVM(Customer customer);
        Location cast2Location(LocationEditVM location2BCasted);
        LocationIndexVM cast2LocationIndexVM(Location location2BCasted);
        LocationCRVM cast2LocationCRVM(Location location);
        LocationEditVM cast2LocationEditVM(Location location);
    }
}