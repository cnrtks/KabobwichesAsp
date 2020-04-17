using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KabobwichesAsp.Models
{
    public class Address
    {
        public int Id { get; set; }
        
        
        private string _streetAddress;
       
        private string _city;
         private string _postalCode;

        public Address() { }
        public Address(string streetAddress, string city, string postalCode)
        {
            this._streetAddress = streetAddress;
            this._city = city;
            PostalCode = postalCode;
        }
        [Required(ErrorMessage = "Address is required")]
        
        public string StreetAddress
        {
            get { return _streetAddress; }
            set { this._streetAddress = value; }
        }
        
        [Required(ErrorMessage = "City is required")]
        public string City
        {
            get { return _city; }
            set { this._city = value; }
        }


        [Required(ErrorMessage = "Postal Code is required")]
        [RegularExpression(@"(^\d{5}(-\d{4})?$)|(^[ABCEGHJKLMNPRSTVXYabceghjklmnprstvxy]{1}\d{1}[ABCEGHJKLMNPRSTVWXYZabceghjklmnprstv‌​xy]{1} *\d{1}[ABCEGHJKLMNPRSTVWXYZabceghjklmnprstvxy]{1}\d{1}$)", ErrorMessage = "That postal code is not a valid Canadian postal code.")]
         public string PostalCode {
            get { return this._postalCode; }
            set { this._postalCode = value; }//add validation
        }
    }
}
