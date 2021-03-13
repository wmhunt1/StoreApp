using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using StoreModels;

namespace StoreDL
{
    public class CustomerRepoDB : ICustomerRepository
    {
        private readonly StoreDBContext _context;
        public CustomerRepoDB(StoreDBContext context)
        {
            _context = context;
        }
        public Customer AddCustomer(Customer newCustomer)
        {
            _context.Customers.Add(newCustomer);
            _context.SaveChanges();
            return newCustomer;
        }

        public Customer DeleteCustomer(Customer customer2BDeleted)
        {
            _context.Customers.Remove(customer2BDeleted);
            _context.SaveChanges();
            return customer2BDeleted;
        }

        public Customer GetCustomerByName(string name)
        {
            return _context.Customers
                .AsNoTracking()
                .FirstOrDefault(customer => customer.CustomerName == name);
        }

        public List<Customer> GetCustomers()
        {
            return _context.Customers
                .AsNoTracking()
                .Select(customer => customer)
                .ToList();
        }

        public Customer UpdateCustomer(Customer customer2BUpdated)
        {
            return customer2BUpdated;
        }
    }
    
}