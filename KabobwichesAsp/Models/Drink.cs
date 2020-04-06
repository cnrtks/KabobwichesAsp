using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KabobwichesAsp.Models
{
    public class Drink
    {
        public int Id { get; set; }
        public string Name;
        private Drink(DrinkEnum @enum)
        {
            Id = (int)@enum;
            Name = @enum.ToString();
        }
        protected Drink() { }

        public static implicit operator Drink(DrinkEnum @enum) => new Drink(@enum);
        public static implicit operator DrinkEnum(Drink drink) => (DrinkEnum)drink.Id;
    }
}
