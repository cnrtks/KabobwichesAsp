using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using KabobwichesAsp.Models;
using Microsoft.AspNetCore.Http;

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
            return View();
        }

        public IActionResult NewOrder()
        {
            Order order = new Order();
            _dbContext.Orders.Add(order);
            _dbContext.SaveChanges();
            HttpContext.Session.SetInt32("orderId", order.Id);
            return RedirectToAction("OrderOverview");
        }

        public IActionResult OrderOverview()
        {
            var orderId = HttpContext.Session.GetInt32("orderId");
            var order = _dbContext.Orders.Find(orderId);
            ViewBag.KabobwichCount = _dbContext.Kabobwiches.Where(k => k.Order.Id == orderId).Count();
            return View("OrderOverview", order);
        }

        public IActionResult KabobwichForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddKabobwich(Kabobwich kabobwich)
        {
            var order = _dbContext.Orders.Find(HttpContext.Session.GetInt32("orderId"));
            if (kabobwich != null)
            {
                kabobwich.Order = order;
                _dbContext.Kabobwiches.Add(kabobwich);
                _dbContext.SaveChanges();
            }
            return RedirectToAction("OrderOverview");
        }

        public IActionResult SidesAndDrinks()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddSidesAndDrinksToOrder(string sideString, string drinkString)
        {
            var order = _dbContext.Orders.Find(HttpContext.Session.GetInt32("orderId"));
            order.Sides = sideString;
            order.Drinks = drinkString;
            _dbContext.SaveChanges();
            return RedirectToAction("OrderOverview");
        }

        public IActionResult PaymentAndAddress()
        {
            ViewBag.Addresses = _dbContext.Addresses;
            ViewBag.Payments = _dbContext.PaymentInfos;
            return View();
        }
        [HttpPost]
        public IActionResult AddPaymentAndAddressToOrder(Order tempOrder)
        {
            var order = _dbContext.Orders.Find(HttpContext.Session.GetInt32("orderId"));
            order.DeliveryAddress = tempOrder.DeliveryAddress;
            order.PaymentInformation = tempOrder.PaymentInformation;
            _dbContext.SaveChanges();
            return RedirectToAction("OrderOverview");
        }
        public IActionResult PlaceOrder()
        {
            return View("ThankYou");
        }
    }
}