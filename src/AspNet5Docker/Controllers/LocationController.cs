using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNet5Docker.Models;
using Microsoft.AspNet.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace AspNet5Docker.Controllers
{
    public class LocationController : Controller
    {
        static readonly List<Location> Locations  = new List<Location>(); 

        public IActionResult Index()
        {
            return View(Locations);
        }

        public IActionResult Add(string newLocation)
        {
            Locations.Add(new Location() { Name = newLocation } );
            return RedirectToAction("Index");
        }
    }
}
