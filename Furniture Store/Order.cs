using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Furniture_Store
{
    public class Order
    {
        public int Id_order { get; set; }
        public string OrderDate { get; set; }
        public int OrderCost { get; set; }
        public string UserLogin { get; set; }
        public int Id_employee { get; set; }
        public string DeliveryPointName { get; set; }

        public Order(int _id_order,string _orderdate, int _ordercost, string _userlogin, int _id_emloyee, string _deliverypointname)
        {
            Id_order = _id_order;
            OrderDate = _orderdate;
            OrderCost = _ordercost;
            UserLogin = _userlogin;
            Id_employee = _id_emloyee;
            DeliveryPointName = _deliverypointname;
        }
    }
}
