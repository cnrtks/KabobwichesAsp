using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace KabobwichesAsp.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddKabobwich()
        {
            return View("KabobwichForm");
        }

        public IActionResult AddSides()
        {
            return View("SidesForm");
        }

        public IActionResult AddDrinks()
        {
            return View("DrinksForm");
        }
    }
}