using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Furniture_Store
{
    public class Furniture
    {
        public string Title { get; set; }
        public string Type { get; set; }
        public int Price { get; set; }

        public Furniture()
        {

        }

        public Furniture(string _title, string _type, int _price)
        {
            Title = _title;
            Type = _type;
            Price = _price;
        }
    }
}
