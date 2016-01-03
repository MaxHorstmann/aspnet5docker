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
        // GET: /<controller>/
        public IActionResult Index()
        {
            var locations = new List<Location>();
            locations.Add(new Location() {Name = "Zurich"});
            locations.Add(new Location() { Name = "Berlin" });
            locations.Add(new Location() { Name = "New York" });

            return View(locations);
        }
    }
}
