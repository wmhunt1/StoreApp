using StoreModels;
using System.Collections.Generic;
namespace StoreBL
{
    public interface ICustomerBL
    {
        List<Customer> GetCustomers();
        void AddCustomer(Customer newCustomer);
        Customer GetCustomerByName(string name);
        Customer DeleteCustomer(Customer customer2BDeleted);

        Customer UpdateCustomer(Customer customer2BUpdated);
    }
}