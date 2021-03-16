using System;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using StoreBL;
using StoreMVC.Models;

namespace StoreMVC.Controllers
{
    public class CustomerController : Controller
    {
        private ICustomerBL _customerBL;
        private IMapper _mapper;

        public CustomerController(ICustomerBL customerBL, IMapper mapper)
        {
            _customerBL = customerBL;
            _mapper = mapper;
        }

        //Actions are public methods in controllers that respond to client requests
        //You can have specific actions respond to specific requests
        // you can also have actions, that respond to different requests
        //You just have to map the request type to the action properly
        // GET: HeroController
        public ActionResult Index(string Sorting_Order, string Search_Data)
        {
            ViewBag.SortingName = String.IsNullOrEmpty(Sorting_Order) ? "name_desc" : "";
            ViewBag.SortingId = Sorting_Order == "Id" ? "id_desc" : "Id";
            
            var customers = from cus in _customerBL.GetCustomers() select cus;
            if(Search_Data != null)
            { 
                customers = customers.Where(cus => cus.CustomerName.ToUpper().Contains(Search_Data.ToUpper()) || cus.CustomerName.ToUpper().Contains(Search_Data.ToUpper()));  
            }
            switch (Sorting_Order)
            {
                case "name_desc":
                    customers = customers.OrderByDescending(cus => cus.CustomerName);
                    break;
                case "id_desc":
                    customers = customers.OrderBy(cus => cus.Id);
                    break;
                //case "address_desc":
                    // customers = customers.OrderByDescending(cus => cus.CustomerAddress);
                    // break;
                default:
                    customers = customers.OrderBy(cus => cus.Id);
                    break;
            }
            return View(customers.Select(customer => _mapper.cast2CustomerIndexVM(customer)).ToList());
        }

        // GET: HeroController/Details?name={heroName}
        public ActionResult Details(string name)
        {
            return View(_mapper.cast2CustomerCRVM(_customerBL.GetCustomerByName(name)));
        }

        // GET: HeroController/Create
        public ActionResult Create()
        {
            return View("CreateCustomer");
        }

        // POST: HeroController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CustomerCRVM newCustomer)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _customerBL.AddCustomer(_mapper.cast2Customer(newCustomer));
                    return RedirectToAction(nameof(Index));
                }
                catch
                {
                    return View();
                }
            }
            return View();
        }

        // GET: HeroController/Edit/5
        public ActionResult Edit(string name)
        {
            return View(_mapper.cast2CustomerEditVM(_customerBL.GetCustomerByName(name)));
        }

        // POST: HeroController/Edit/
        //Model Binding: bind an action/view to a model, and apply the validation logic/structure stated in model
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(CustomerEditVM customer2BUpdated)
        {
            //Model state is valid literally means model data is valid
            //you're just checking if the data that you're receiving client side complies with the 
            // validation you set for the model 

            if (ModelState.IsValid)
            {
                try
                {

                    _customerBL.UpdateCustomer(_mapper.cast2Customer(customer2BUpdated));
                    return RedirectToAction(nameof(Index));
                }
                catch
                {
                    return View();
                }
            }
            return View();
        }

        // GET: HeroController/Delete/{hero name}
        public ActionResult Delete(string name)
        {
            _customerBL.DeleteCustomer(_customerBL.GetCustomerByName(name));
            return RedirectToAction(nameof(Index));
        }
    }
}