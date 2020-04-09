using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KabobwichesAsp.Models
{
    public class Kabobwich
    {
        public int Id { get; set; }
        private Order _order;
        public Order Order { get { return this._order; } set { this._order = value; } }
        private Bread _bread;
        public Bread Bread { get { return this._bread; } set { this._bread = value; } }
        private Meat _meat;
        public Meat Meat { get { return this._meat; } set { this._meat = value; } }
        private Sauce _sauce;
        public Sauce Sauce { get { return this._sauce; } set { this._sauce = value; } }
        private string _toppings;
        public string Toppings { get{ return this._toppings; } set { this._toppings = value; } }

        public Kabobwich() { }
        public Kabobwich(Order order, Bread bread, Meat meat, Sauce sauce, string toppings)
        {
            this._order = order;
            this._bread = bread;
            this._meat = meat;
            this._sauce = sauce;
            this._toppings = toppings;
        }
    }
}
