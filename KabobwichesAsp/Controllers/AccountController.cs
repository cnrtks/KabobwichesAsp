using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using KabobwichesAsp.Models;

namespace KabobwichesAsp.Controllers
{
    public class AccountController : Controller
    {
        public Repository _dbContext;
        public AccountController()
        {
            _dbContext = new Repository();
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddAddress()
        {
            return View("AddressForm");
        }

        public IActionResult AddPaymentInfo()
        {
            ViewBag.Addresses = _dbContext.Addresses;
            return View("PaymentInfoForm");
        }

        [HttpPost]
        public IActionResult SaveAddress(Address address)
        {
            _dbContext.Addresses.Add(address);
            _dbContext.SaveChanges();
            return RedirectToAction("index");
        }
        
        //remove address
        //update address

        [HttpPost]
        public IActionResult SavePaymentInfo(PaymentInformation paymentInfo, string BillingAddress)
        {
            paymentInfo.BillingAddress = _dbContext.Addresses.Find(Convert.ToInt32(BillingAddress));
            _dbContext.PaymentInfos.Add(paymentInfo);
            _dbContext.SaveChanges();
            return RedirectToAction("index");
        }
        //remove payment
        //update payment
    }
}