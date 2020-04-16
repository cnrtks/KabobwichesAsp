using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KabobwichesAsp.Models
{
    public class PaymentInformation
    {
        public int Id { get; set; }
        private CardType _cardType;
        private string _cardNum;
        private int _securityCode;
        private string _cardholderName;
        private Address _billingAddress;

        public PaymentInformation() { }

        public CardType CardType
        {
            get { return this._cardType; }
            set { this._cardType = value; }
        }
        public string CardNum
        {
            get { return this._cardNum; }
            set { this._cardNum = value; }
        }
        public int SecurityCode
        {
            get { return this._securityCode; }
            set { this._securityCode = value; }
        }
        public string CardholderName
        {
            get { return this._cardholderName; }
            set { this._cardholderName = value; }
        }
        public Address BillingAddress
        {
            get { return this._billingAddress; }
            set { this._billingAddress = value; }
        }
    }
}
