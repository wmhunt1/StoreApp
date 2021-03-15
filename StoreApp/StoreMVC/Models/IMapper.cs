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
        Customer cast2Customer(CustomerEditVM customer2BCasted);
        //Location
        
        Location cast2Location(LocationCRVM location2BCasted);
        LocationIndexVM cast2LocationIndexVM(Location location2BCasted);
        LocationCRVM cast2LocationCRVM(Location location);
        LocationEditVM cast2LocationEditVM(Location location);
        Location cast2Location(LocationEditVM location2BCasted);
        //Product
        Product cast2Product(ProductCRVM product2BCasted);
        ProductIndexVM cast2ProductIndexVM(Product product2BCasted);
        ProductCRVM cast2ProductCRVM(Product product);
        ProductEditVM cast2ProductEditVM(Product product);
        Product cast2Product(ProductEditVM product2BCasted);
        //Order
        Order cast2Order(OrderCRVM order2BCasted);
        OrderIndexVM cast2OrderIndexVM(Order order2BCasted);
        OrderCRVM cast2OrderCRVM(Order order);
        OrderEditVM cast2OrderEditVM(Order order);
        Order cast2Order(OrderEditVM order2BCasted);
    }
}