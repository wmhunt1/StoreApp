using System;
using System.Collections.Generic;
using StoreDL;
using StoreModels;

namespace StoreBL
{
    public class CustomerBL : ICustomerBL
    {
        private ICustomerRepository _repo;
        public CustomerBL(ICustomerRepository repo)
        {
            _repo = repo;
        }
        public void AddCustomer(Customer newCustomer)
        {
            //Todo: Add BL
            _repo.AddCustomer(newCustomer);
        }
        public Customer GetCustomerByName(string name)
        {
            //Todo: check if the name given is not null or empty string 
            return _repo.GetCustomerByName(name);
        }
        public List<Customer> GetCustomers()
        {
            //TODO add BL
            return _repo.GetCustomers();
        }

        public Customer DeleteCustomer(Customer customer2BDeleted)
        {
            return _repo.DeleteCustomer(customer2BDeleted);
        }
        public Customer UpdateCustomer(Customer customer2BUpdated)
        {
            return _repo.UpdateCustomer(customer2BUpdated);
        }

    }
}
