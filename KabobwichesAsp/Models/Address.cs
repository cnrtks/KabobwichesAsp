using System;
using System.Collections.Generic;
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

        public string StreetAddress
        {
            get { return _streetAddress; }
            set { this._streetAddress = value; }
        }
        public string City
        {
            get { return _city; }
            set { this._city = value; }
        }
        public string PostalCode {
            get { return this._postalCode; }
            set { this._postalCode = value; }//add validation
        }
    }
}
