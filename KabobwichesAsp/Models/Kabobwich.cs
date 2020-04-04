using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KabobwichesAsp.Models
{
    public class Kabobwich
    {
        private Bread _bread;
        private Meat _meat;
        private Sauce _sauce;
        private Topping[] _toppings;

        Kabobwich(Bread bread, Meat meat, Sauce sauce, Topping[] toppings)
        {
            this._bread = bread;
            this._meat = meat;
            this._sauce = sauce;
            this._toppings = toppings;
        }
    }
}
