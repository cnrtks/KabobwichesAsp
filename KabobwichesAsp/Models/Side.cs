using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KabobwichesAsp.Models
{
    public class Side
    {
        public int Id { get; set; }
        public string Name;
        public Side(SideEnum @enum)
        {
            Id = (int)@enum;
            Name = @enum.ToString();
        }
        protected Side() { }

        public static implicit operator Side(SideEnum @enum) => new Side(@enum);
        public static implicit operator SideEnum(Side side) => (SideEnum)side.Id;
    }
}
