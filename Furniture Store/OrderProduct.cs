using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Furniture_Store
{
    public class OrderProduct
    {
        public int Id_order;
        public int Id_product;

        public OrderProduct(int _id_ord, int _id_prod)
        {
            Id_order = _id_ord;
            Id_product = _id_prod;
        }
    }
}
