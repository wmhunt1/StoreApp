using System.Collections.Generic;
using Model = StoreModels;
using Entity = StoreDL.Entities;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using StoreModels;

namespace StoreDL
{
    public class StoreRepoDB : ICustomerRepository, IOrderRepository
    {
        private Entity.StoreDBContext _context;
        private IMapper _mapper;
        public StoreRepoDB(Entity.StoreDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public Model.Customer AddCustomer(Model.Customer newCustomer)
        {
            _context.Customers.Add(_mapper.ParseCustomer(newCustomer));
            _context.SaveChanges();
            return newCustomer;
        }

        public Order AddOrder(Order newOrder)
        {
             _context.Orders.Add(_mapper.ParseOrder(newOrder));
            _context.SaveChanges();
            return newOrder;
            //throw new System.NotImplementedException();
        }

        // public Customer DeleteCustomer(Customer customer2BDeleted)
        // {
        //     _context.Customers.Remove(_mapper.ParseCustomer(customer2BDeleted));
        //     _context.SaveChanges();
        //     return customer2BDeleted;
        // }

        // public Customer GetCustomerByName(string name)
        // {
        //     return _context.Customer.AsNoTracking().Select(x => _mapper.ParseCustomer(x)).ToList().FirstOrDefault(x => x.CustomerName == name);
        // }

        public List<Model.Customer> GetCustomers()
        {
            return _context.Customers.AsNoTracking().Select(x => _mapper.ParseCustomer(x)).ToList();
        }

        public List<Order> GetOrders()
        {
             return _context.Orders.AsNoTracking().Select(x => _mapper.ParseOrder(x)).ToList();
            //throw new System.NotImplementedException();
        }

        // public void UpdateCustomer(Customer customer2BUpdated)
        // {
        //     Entity.Customer oldCustomer = _context.Customers.Find(customer2BUpdated.CId);
        //     _context.Entry(oldCustomer).CurrentValues.SetValues(_mapper.ParseCustomer(custmer2BUpdated));

        //     _context.SaveChanges();
        //     _context.ChangeTracker.Clear();
        // }
    }
}