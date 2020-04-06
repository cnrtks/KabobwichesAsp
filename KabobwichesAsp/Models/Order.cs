using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KabobwichesAsp.Models
{
    public class Order
    {
        public int Id { get; set; }
        private List<Kabobwich> _kabobwiches;
        public List<Kabobwich> Kabobwiches { get { return _kabobwiches; } set { this._kabobwiches = value; } }
        private IEnumerable<Side> _sides;
        private List<Drink> _drinks;
        public IEnumerable<Side> Sides
        {
            get { return _sides; }
            set { this._sides = value; }
        }
        public List<Drink> Drinks
        {
            get { return _drinks; }
            set { this._drinks = value; }
        }
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

        public void AddKabobwich(Kabobwich kabobwich)
        {
            _kabobwiches.Add(kabobwich);
        }
        public double CalculateTotal()
        {
            double total = 0;
            total += _kabobwiches.Count() * 5;
            total += _sides.Count() * 2;
            total += _drinks.Count() * 1.5;
            total *= 1.13;
            return total;
        }
    }
}
