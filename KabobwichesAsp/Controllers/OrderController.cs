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
        Repository _dbContext;

        public OrderController()
        {
            _dbContext = new Repository();
        }

        public IActionResult Index()
        {
            Order order = new Order();
            _dbContext.Orders.Add(order);
            _dbContext.SaveChanges();
            ViewBag.OrderId = order.Id;
            return View("KabobwichForm");
        }

        [HttpPost]
        public IActionResult AddKabobwich(Kabobwich kabobwich, int orderId)
        {
            var order = _dbContext.Orders.Find(orderId);
            if (kabobwich != null)
            {
                kabobwich.Order = order;
                _dbContext.Kabobwiches.Add(kabobwich);
                _dbContext.SaveChanges();
            }
            else { return RedirectToAction("index"); }
            ViewBag.OrderId = orderId;
            return View("SidesAndDrinks");
        }

        [HttpPost]
        public IActionResult AddSidesAndDrinksToOrder(int orderId, string sideString, string drinkString)
        {
            var order = _dbContext.Orders.Find(orderId);
            order.Sides = sideString;
            order.Drinks = drinkString;
            _dbContext.SaveChanges();
            ViewBag.Addresses = _dbContext.Addresses;
            ViewBag.Payments = _dbContext.PaymentInfos;
            return View("PaymentAndAddress", order);
        }
        [HttpPost]
        public IActionResult PlaceOrder(Order order)
        {
            _dbContext.Orders.Add(order);
            _dbContext.SaveChanges();
            return View("ThankYou");
        }
    }
}