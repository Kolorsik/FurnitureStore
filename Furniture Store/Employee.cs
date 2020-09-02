using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Furniture_Store
{
    public class Employee
    {
        public int Id_employee { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }

        public Employee(int _id, string _fullname, string _email, string _telephone)
        {
            Id_employee = _id;
            FullName = _fullname;
            Email = _email;
            Telephone = _telephone;
        }
    }
}
