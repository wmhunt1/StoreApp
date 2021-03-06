using Microsoft.AspNetCore.Mvc;
using System.Linq;
using StoreBL;
using StoreMVC.Models;

namespace StoreMVC.Controllers
{
    public class LocationController : Controller
    {
        private ILocationBL _locationBL;
        private IMapper _mapper;

        public LocationController(ILocationBL locationBL, IMapper mapper)
        {
            _locationBL = locationBL;
            _mapper = mapper;
        }

        //Actions are public methods in controllers that respond to client requests
        //You can have specific actions respond to specific requests
        // you can also have actions, that respond to different requests
        //You just have to map the request type to the action properly
        // GET: HeroController
        public ActionResult Index()
        {
            //You have different kinds of views:
            //Strongly-typed - tied to a model
            //Weakly-typed - not tied to a model. gets data via viewbag, viewdata, tempdata, etc.
            // Dynamic - pass a model, don't tie to a view, let the view figure it out,
            //(do some further research into this)
            //Let's create a strongly typed view:
            return View(_locationBL.GetLocations().Select(location => _mapper.cast2LocationIndexVM(location)).ToList());
        }

        // GET: HeroController/Details?name={heroName}
        public ActionResult Details(string name)
        {
            return View(_mapper.cast2LocationCRVM(_locationBL.GetLocationByName(name)));
        }

        // GET: HeroController/Create
        public ActionResult Create()
        {
            return View("CreateLocation");
        }

        // POST: HeroController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(LocationCRVM newLocation)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _locationBL.AddLocation(_mapper.cast2Location(newLocation));
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
            return View(_mapper.cast2LocationEditVM(_locationBL.GetLocationByName(name)));
        }

        // POST: HeroController/Edit/
        //Model Binding: bind an action/view to a model, and apply the validation logic/structure stated in model
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(LocationEditVM location2BUpdated)
        {
            //Model state is valid literally means model data is valid
            //you're just checking if the data that you're receiving client side complies with the 
            // validation you set for the model 

            if (ModelState.IsValid)
            {
                try
                {
                    _locationBL.UpdateLocation(_mapper.cast2Location(location2BUpdated));
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
            _locationBL.DeleteLocation(_locationBL.GetLocationByName(name));
            return RedirectToAction(nameof(Index));
        }
    }
}