using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KabobwichesAsp.Models
{
    class Account
    {
        private List<PaymentInformation> _paymentList;
        private List<Address> _addressList;
        private List<Order> _orders;
        private List<Kabobwich> _kabobwiches;

        public Account()
        {
            _paymentList = new List<PaymentInformation>();
            _addressList = new List<Address>();
            _orders = new List<Order>();
            _kabobwiches = new List<Kabobwich>();
        }
        public void AddPayment()
        {

        }
        public void AddAddress()
        {

        }
        public void ProvideFeedback()
        {

        }
    }
}
