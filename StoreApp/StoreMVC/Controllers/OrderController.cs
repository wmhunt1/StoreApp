using System;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using StoreBL;
using StoreMVC.Models;

namespace StoreMVC.Controllers
{
    public class OrderController : Controller
    {
        private IOrderBL _orderBL;
        private IMapper _mapper;

        public OrderController(IOrderBL orderBL, IMapper mapper)
        {
            _orderBL = orderBL;
            _mapper = mapper;
        }

        //Actions are public methods in controllers that respond to client requests
        //You can have specific actions respond to specific requests
        // you can also have actions, that respond to different requests
        //You just have to map the request type to the action properly
        // GET: HeroController
        // public ActionResult Index()
        // {
        //     //You have different kinds of views:
        //     //Strongly-typed - tied to a model
        //     //Weakly-typed - not tied to a model. gets data via viewbag, viewdata, tempdata, etc.
        //     // Dynamic - pass a model, don't tie to a view, let the view figure it out,
        //     //(do some further research into this)
        //     //Let's create a strongly typed view:
        //     return View(_orderBL.GetOrders().Select(order => _mapper.cast2OrderIndexVM(order)).ToList());
        // }
        public ActionResult Index(string Sorting_Order, string Search_Data1, string Search_Data2)
        {
            ViewBag.SortingTotal = String.IsNullOrEmpty(Sorting_Order) ? "total_desc" : "";
            ViewBag.SortingId = Sorting_Order == "Id" ? "id_desc" : "Id";

            var orders = from ord in _orderBL.GetOrders() select ord;
            if(Search_Data1 != null)
            { 
                orders = orders.Where(ord => ord.OrderCustomerId.ToString().Contains(Search_Data1.ToUpper()) || ord.OrderCustomerId.ToString().Contains(Search_Data1.ToUpper()));  
            }
            if(Search_Data2 != null)
            { 
                orders = orders.Where(ord => ord.OrderLocationId.ToString().Contains(Search_Data2.ToUpper()) || ord.OrderCustomerId.ToString().Contains(Search_Data2.ToUpper()));  
            }
            switch (Sorting_Order)
            {
                case "total_desc":
                    orders = orders.OrderByDescending(ord => ord.OrderTotal);
                    break;
                case "id_desc":
                    orders = orders.OrderBy(cus => cus.Id);
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
    }
}