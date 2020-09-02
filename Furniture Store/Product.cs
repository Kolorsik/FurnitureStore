using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Types;
using System.IO;

namespace Furniture_Store
{
    public class Product
    {
        public int Id_product { get; set; }
        public string Title { get; set; }
        public int Price { get; set; }
        public string Provider { get; set; }
        public string Type { get; set; }
        public int Rating { get; set; }
        public MemoryStream Image { get ; set; }

        public Product(int _id, string _title, int _price, string _provider, string _type, int _rating, MemoryStream _img)
        {
            Id_product = _id;
            Title = _title;
            Price = _price;
            Provider = _provider;
            Type = _type;
            Rating = _rating;
            Image = _img;
        }
    }
}
