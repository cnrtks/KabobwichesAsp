using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using KabobwichesAsp.Models;

namespace KabobwichesAsp.Controllers
{
    public class OrderController : Controller
    {
        Order order = new Order();
        Repository _dbContext;

        public OrderController()
        {
            _dbContext = new Repository();
        }

        public IActionResult Index()
        {
            ViewBag.Total = order.CalculateTotal();
            return View();
        }

        public IActionResult KabobwichForm()
        {
            return View("KabobwichForm");
        }
        [HttpPost]
        public IActionResult AddKabobwich(Kabobwich kabobwich)
        {
            order.AddKabobwich(kabobwich);
            return RedirectToAction("index");
        }


        public IActionResult SidesForm()
        {
            return View("SidesForm");
        }
        public IActionResult AddSides(IEnumerable<Side> sides)
        {
            order.Sides = sides;
            return RedirectToAction("index");
        }

        public IActionResult DrinksForm()
        {
            return View("DrinksForm");
        }

        [HttpPost]
        public IActionResult AddDrinks(List<Drink> drinks)
        {
            order.Drinks = drinks;
            return RedirectToAction("index");
        }

        [HttpPost]
        public IActionResult SaveOrder()
        {
            _dbContext.Kabobwiches.AddRange(order.Kabobwiches);
            _dbContext.Orders.Add(order);
            _dbContext.SaveChanges();
            order = new Order();
            return View("ThankYou");
        }
    }
}