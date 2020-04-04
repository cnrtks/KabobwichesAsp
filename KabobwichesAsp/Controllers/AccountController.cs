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
            return View("PaymentInfoForm");
        }

        [HttpPost]
        public IActionResult SaveAddress(Address address)
        {
            _dbContext.Addresses.Add(address);
            return RedirectToAction("index");
        }
        
        //remove address
        //update address

        //add payment
        //remove payment
        //update payment
    }
}