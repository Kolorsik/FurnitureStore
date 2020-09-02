using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Furniture_Store
{
    public class BuyItem
    {
        public string Name { get; set; }
        public int Cost { get; set; }
        public int Id_Prod { get; set; }
        public BuyItem(string _name, int _cost, int _id)
        {
            Name = _name;
            Cost = _cost;
            Id_Prod = _id;
        }
    }
}
