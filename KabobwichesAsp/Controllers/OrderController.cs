using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using KabobwichesAsp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;

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

            if (String.IsNullOrEmpty(HttpContext.Session.GetString("kabobwichId"))){
                ViewBag.KabobwichCount = 0;
            }
            else
            {
                ViewBag.KabobwichCount = _dbContext.Kabobwiches.Where(k => k.Id == HttpContext.Session.GetInt32("orderId")).Count();
            }
            return RedirectToAction("OrderOverview");
        }

        public IActionResult OrderOverview()
        {

            ViewBag.addressid = HttpContext.Session.GetString("addressid");
            ViewBag.billingid = HttpContext.Session.GetString("billingid");
            ViewBag.KabobwichCount = _dbContext.Kabobwiches.Where(k => k.Id == HttpContext.Session.GetInt32("kabobwichId")).Count();
           
            Order order = new Order();
            order.Sides = String.IsNullOrEmpty(HttpContext.Session.GetString("sideString")) ? "" : HttpContext.Session.GetString("sideString");
            order.Drinks = String.IsNullOrEmpty(HttpContext.Session.GetString("drinkString")) ? "" : HttpContext.Session.GetString("drinkString");
            ViewBag.numOfSides = String.IsNullOrEmpty(order.Sides) ? 0: order.CountSides();
            ViewBag.numOfDrinks = String.IsNullOrEmpty(order.Drinks) ? 0 : order.CountDrinks();
            return View("OrderOverview");
        }

        public IActionResult KabobwichForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddKabobwich(Kabobwich kabobwich)
        {
            if (kabobwich != null)
            {
               // kabobwich.Order = order;
                _dbContext.Kabobwiches.Add(kabobwich);
                _dbContext.SaveChanges();
            }
            HttpContext.Session.SetInt32("kabobwichId", kabobwich.Id);
            return RedirectToAction("OrderOverview");
        }

        public IActionResult SidesAndDrinks()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddSidesAndDrinksToOrder(string sideString, string drinkString)
        {
            HttpContext.Session.SetString("sideString", sideString);
            HttpContext.Session.SetString("drinkString", drinkString);
           
            return RedirectToAction("OrderOverview");
        }

        public IActionResult PaymentAndAddress()
        {
            ViewBag.Addresses = new SelectList(_dbContext.Addresses, "Id", "StreetAddress");
            ViewBag.Payments = new SelectList(_dbContext.PaymentInfos, "Id", "CardNum");
            return View();
        }
        [HttpPost]
        public IActionResult AddPaymentAndAddressToOrder(string addressid, string billingid)
        {
            
            HttpContext.Session.SetString("addressid", addressid);
            HttpContext.Session.SetString("billingid", billingid);
            return RedirectToAction("OrderOverview");
        }
        public IActionResult PlaceOrder()
        {
            Order order = new Order();
            order.DeliveryAddress = _dbContext.Addresses.Find(Convert.ToInt32(HttpContext.Session.GetString("addressid")));
            order.PaymentInformation = _dbContext.PaymentInfos.Find(Convert.ToInt32(HttpContext.Session.GetString("billingid")));
            order.Drinks = HttpContext.Session.GetString("drinkString");
            order.Sides = HttpContext.Session.GetString("sideString");
            _dbContext.Orders.Add(order);
            _dbContext.SaveChanges();

            Kabobwich kabobwich = _dbContext.Kabobwiches.Find(HttpContext.Session.GetInt32("kabobwichId"));
            kabobwich.Order = order;
            _dbContext.SaveChanges();
            return View("ThankYou");
        }
    }
}