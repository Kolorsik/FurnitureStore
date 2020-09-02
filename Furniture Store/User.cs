using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Furniture_Store
{
    public class User
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public string Telephone { get; set; }
        public string Role { get; set; }

        public User(string _login, string _password, string _email, string _fullname, string _address, string _telephone, string _role)
        {
            Login = _login;
            Password = _password;
            Email = _email;
            FullName = _fullname;
            Address = _address;
            Telephone = _telephone;
            Role = _role;
        }

        public User(string _login, string _password, string _role)
        {
            Login = _login;
            Password = _password;
            Role = _role;
        }
    }
}
