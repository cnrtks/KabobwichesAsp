using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KabobwichesAsp.Models
{
    class Order
    {
        private List<Kabobwich> _kabobwiches;
        private List<Side> _sides;
        private List<Drink> _drinks;
        private Address _deliveryAddress;
        private PaymentInformation _paymentInformation;
        public Address DeliveryAddress { get { return this._deliveryAddress; } set { this._deliveryAddress = value; } }//add validation
        public PaymentInformation PaymentInformation { get { return this._paymentInformation; } set { this._paymentInformation = value; } }//add validation }

        public Order()
        {
            _kabobwiches = new List<Kabobwich>();
            _sides = new List<Side>();
            _drinks = new List<Drink>();
        }

        public void AddKabobwich()
        {

        }
        public void AddSide()
        {

        }
        public void AddDrink()
        {

        }
        public double CalculateTotal()
        {
            double total = 0;
            //add together each item and toppings
            //add delivery if required
            //add tax
            return total;
        }
        public void ConfirmOrder()
        {
            //check at least one item has been ordered
            //chack payment not null
            //check address not null
            //dbSet Kabobwiches
            //dbSet entire Order
            //add order to users orders
            //add kabobwich to users kabobs
        }
    }
}
