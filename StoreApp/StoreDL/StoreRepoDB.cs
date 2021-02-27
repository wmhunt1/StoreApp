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
        }

        public List<Model.Customer> GetCustomers()
        {
            return _context.Customers.AsNoTracking().Select(x => _mapper.ParseCustomer(x)).ToList();
        }
          public Customer GetCustomerByName(string name)
        {
            //this method returns the hero entity, and eagerly loads the superpower entity associated with it 
            //using the .Include() method. the .AsNoTracking() method makes sure that the enities aren't being 
            //tracked by the change tracker. the .Select() method is used to transform each entity type to a model type
            //The .ToList() method structures the collection into a list, and the FirstOrDefault() method searches
            //that list for a element whose heroName is equal to the parameter
            return _context.Customers
            .AsNoTracking()
            .Select(x => _mapper.ParseCustomer(x))
            .ToList()
            .FirstOrDefault(x => x.CustomerName == name);
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