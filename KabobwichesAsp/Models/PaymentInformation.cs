using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KabobwichesAsp.Models
{
    public class PaymentInformation
    {
        [Key]
        public int Id { get; set; }
       
        private CardType _cardType;
        private string _cardNum;
        private string _securityCode;
        private string _cardholderName;
        private Address _billingAddress;

        public PaymentInformation() { }
        [Required(ErrorMessage = "Card Type is required")]
        public CardType CardType
        {
            get { return this._cardType; }
            set { this._cardType = value; }
        }
        [Required(ErrorMessage = "Card Number is required")]
        [StringLength(16, MinimumLength = 16, ErrorMessage = "Card Number must be 16 digit")]
        [RegularExpression("([0-9]+)", ErrorMessage = "Please enter valid Number")]
        public string CardNum
        {
            get { return this._cardNum; }
            set { this._cardNum = value; }
        }
        [Required(ErrorMessage = "Security Code is required")]
        [StringLength(3, MinimumLength = 3, ErrorMessage = "CCV must be 3 digit")]
        [RegularExpression("([0-9]+)", ErrorMessage = "Please enter valid Number")]
        public string SecurityCode
        {
            get { return this._securityCode; }
            set { this._securityCode = value; }
        }
        [Required(ErrorMessage = "Card Holder Name is required")]
        public string CardholderName
        {
            get { return this._cardholderName; }
            set { this._cardholderName = value; }
        }


       // [Required(ErrorMessage = "Billing Address is required")]
        public Address BillingAddress
        {
            get { return this._billingAddress; }
            set { this._billingAddress = value; }
        }
    }
}
