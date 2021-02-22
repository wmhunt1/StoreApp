using StoreModels;
using System.Collections.Generic;
namespace StoreBL
{
    public interface IStoreBL
    {
        List<Customer> GetCustomers();
        void AddCustomer(Customer newCustomer);
    }
}