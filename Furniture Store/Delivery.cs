using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Furniture_Store
{
    public class Delivery
    {
        public int Id_delivery;
        public int Id_employee;
        public string Status;
        public int Id_order;

        public Delivery(int _id_del, int _id_emp, string _status, int _id_ord)
        {
            Id_delivery = _id_del;
            Id_employee = _id_emp;
            Status = _status;
            Id_order = _id_ord;
        }
    }
}
