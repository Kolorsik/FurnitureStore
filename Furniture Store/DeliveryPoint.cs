using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Furniture_Store
{
    public class DeliveryPoint
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Telephone { get; set; }

        public DeliveryPoint(string _name, string _address, string _telephone)
        {
            Name = _name;
            Address = _address;
            Telephone = _telephone;
        }
    }
}
