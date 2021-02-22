using System;
using System.Collections.Generic;
using StoreDL;
using StoreModels;

namespace StoreBL
{
    public class StoreBL : IStoreBL
    {
        private IStoreRepository _repo;
        public StoreBL(IStoreRepository repo)
        {
            _repo = repo;
        }
        public void AddCustomer(Customer newCustomer)
        {
            //Todo: Add BL
            _repo.AddHero(newCustomer);
        }

        public List<Customer> GetCustomers()
        {
            //TODO add BL
            return _repo.GetCustomers();
        }
    }
}
