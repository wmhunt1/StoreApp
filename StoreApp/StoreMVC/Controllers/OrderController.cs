using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;
using StoreBL;
using StoreMVC.Models;
using System.Collections.Generic;

namespace StoreMVC.Controllers
{
    public class OrderController : Controller
    {
        private IOrderBL _orderBL;
        private IMapper _mapper;
        private ILocationBL _locationBL;
        private ICustomerBL _customerBL;

        public OrderController(IOrderBL orderBL, IMapper mapper, ILocationBL locationBL, ICustomerBL customerBL)
        {
            _orderBL = orderBL;
            _mapper = mapper;
            _locationBL = locationBL;
            _customerBL = customerBL;
        }
        // GET: HeroController
        public ActionResult Index(string Sorting_Order, string Search_Data1, string Search_Data2)
        {
            ViewBag.SortingTotal = String.IsNullOrEmpty(Sorting_Order) ? "total_desc" : "";
            ViewBag.SortingId = Sorting_Order == "Id" ? "id_desc" : "Id";

            var orders = from ord in _orderBL.GetOrders() select ord;
            if (Search_Data1 != null)
            {
                orders = orders.Where(ord => ord.OrderCustomerId.ToString().Contains(Search_Data1.ToUpper()) || ord.OrderCustomerId.ToString().Contains(Search_Data1.ToUpper()));
            }
            if (Search_Data2 != null)
            {
                orders = orders.Where(ord => ord.OrderLocationId.ToString().Contains(Search_Data2.ToUpper()) || ord.OrderCustomerId.ToString().Contains(Search_Data2.ToUpper()));
            }
            switch (Sorting_Order)
            {
                case "total_desc":
                    orders = orders.OrderByDescending(ord => ord.OrderTotal);
                    break;
                case "id_desc":
                    orders = orders.OrderBy(ord => ord.Id);
                    break;
                default:
                    orders = orders.OrderBy(ord => ord.Id);
                    break;
            }
            return View(orders.Select(order => _mapper.cast2OrderIndexVM(order)).ToList());
        }

        // GET: HeroController/Details?name={heroName}
        public ActionResult Details(string name)
        {
            return View(_mapper.cast2OrderCRVM(_orderBL.GetOrderByName(name)));
        }

        // GET: HeroController/Create
        public ActionResult Create()
        {
            return View("CreateOrder");
        }

        // POST: HeroController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(OrderCRVM newOrder)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _orderBL.AddOrder(_mapper.cast2Order(newOrder));
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
            return View(_mapper.cast2OrderEditVM(_orderBL.GetOrderByName(name)));
        }

        // POST: HeroController/Edit/
        //Model Binding: bind an action/view to a model, and apply the validation logic/structure stated in model
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(OrderEditVM order2BUpdated)
        {
            //Model state is valid literally means model data is valid
            //you're just checking if the data that you're receiving client side complies with the 
            // validation you set for the model 

            if (ModelState.IsValid)
            {
                try
                {
                    _orderBL.UpdateOrder(_mapper.cast2Order(order2BUpdated));
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
            _orderBL.DeleteOrder(_orderBL.GetOrderByName(name));
            return RedirectToAction(nameof(Index));
        }
        public ActionResult Customers()
        {

             List<SelectListItem> customerList= new List<SelectListItem>();
            var items = _customerBL.GetCustomers().Select(customer => _mapper.cast2CustomerIndexVM(customer)).ToList();
            if (items != null)
            {
                ViewBag.customer = items;
            }

            return View();
        }
        public ActionResult Locations()
        {

             List<SelectListItem> locationList= new List<SelectListItem>();
            var items = _locationBL.GetLocations().Select(location => _mapper.cast2LocationIndexVM(location)).ToList();
            if (items != null)
            {
                ViewBag.location = items;
            }

            return View();
        }
       
    }
}