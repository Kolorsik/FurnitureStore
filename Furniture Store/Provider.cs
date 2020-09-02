using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Furniture_Store
{
    public class Provider
    {
        public string NameProvider { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }

        public Provider(string _nameprovider, string _email, string _telephone)
        {
            NameProvider = _nameprovider;
            Email = _email;
            Telephone = _telephone;
        }
    }
}
