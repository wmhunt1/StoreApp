using StoreModels;

namespace StoreMVC.Models
{
    public interface IMapper
    {
        //Customer
        Customer cast2Customer(CustomerCRVM customer2BCasted);
        CustomerIndexVM cast2CustomerIndexVM(Customer customer2BCasted);
        CustomerCRVM cast2CustomerCRVM(Customer customer);
        CustomerEditVM cast2CustomerEditVM(Customer customer);
        //Location
        Location cast2Location(LocationEditVM location2BCasted);
        LocationIndexVM cast2LocationIndexVM(Location location2BCasted);
        LocationCRVM cast2LocationCRVM(Location location);
        LocationEditVM cast2LocationEditVM(Location location);
        //Product
         Product cast2Product(ProductEditVM product2BCasted);
        ProductIndexVM cast2ProductIndexVM(Product product2BCasted);
        ProductCRVM cast2ProductCRVM(Product product);
        ProductEditVM cast2ProductEditVM(Product product);
        //Order
        Order cast2Order(OrderEditVM order2BCasted);
        OrderIndexVM cast2OrderIndexVM(Order order2BCasted);
        OrderCRVM cast2OrderCRVM(Order order);
        OrderEditVM cast2OrderEditVM(Product product);
    }
}