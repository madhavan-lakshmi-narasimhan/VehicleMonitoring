using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VehicleTracker.Controllers
{
    public class Tracking : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
