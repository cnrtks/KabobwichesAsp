using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KabobwichesAsp.Models
{
    public class Order
    {
        public int Id { get; set; }
        private string _sides = "";
        private string _drinks = "";
        public string Sides
        {
            get { return _sides; }
            set { this._sides = value; }
        }
        public string Drinks
        {
            get { return _drinks; }
            set { this._drinks = value; }
        }
       
        private Address _deliveryAddress;
        
        private PaymentInformation _paymentInformation;
        [Required(ErrorMessage = "Delivery Address is required")]
        public Address DeliveryAddress { get { return this._deliveryAddress; } set { this._deliveryAddress = value; } }//add validation
       
        public PaymentInformation PaymentInformation { get { return this._paymentInformation; } set { this._paymentInformation = value; } }//add validation }

        public int CountSides()
        {
            return String.IsNullOrEmpty(_sides) ? 0 : _sides.Count(ch => ch == ',');
        }
        public int CountDrinks()
        {
            return String.IsNullOrEmpty(_drinks) ? 0 : _drinks.Count(ch => ch == ',');
        }
    }
}
