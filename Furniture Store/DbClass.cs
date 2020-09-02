using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using System.Collections.ObjectModel;
using System.Windows;
using System.IO;
using Oracle.DataAccess.Types;
using System.Windows.Media;

namespace Furniture_Store
{
    public class DbClass
    {
        public static string connectionUser = "User Id=C##USER_ADMIN;Password=admin123;Data Source=localhost:1521/orcl;";
        public static string connectionAdmin = "User Id=C##USER_ADMIN;Password=admin123;Data Source=localhost:1521/orcl;";
        public static ObservableCollection<Provider> Providers = new ObservableCollection<Provider>();
        public static ObservableCollection<DeliveryPoint> DeliveryPoints = new ObservableCollection<DeliveryPoint>();
        public static ObservableCollection<Employee> Employees = new ObservableCollection<Employee>();
        public static ObservableCollection<Product> Products = new ObservableCollection<Product>();
        public static ObservableCollection<User> Users = new ObservableCollection<User>();
        public static ObservableCollection<Delivery> Deliverys = new ObservableCollection<Delivery>();
        public static ObservableCollection<Order> UsersOrders = new ObservableCollection<Order>();
        public static ObservableCollection<OrderProduct> OrdersProducts = new ObservableCollection<OrderProduct>();

        public string CheckUser(bool isAdmin)
        {
            if (isAdmin)
                return "User Id=C##USER_ADMIN;Password=admin123;Data Source=localhost:1521/orcl;";
            else
                return "User Id=C##USER_BASIC;Password=user123;Data Source=localhost:1521/orcl;";
        }

        public void GetAllProviders(bool isAdmin)
        {
            Providers.Clear();
            OracleConnection con;
            if (isAdmin)
                con = new OracleConnection(connectionAdmin);
            else
                con = new OracleConnection(connectionUser);
            con.Open();
            
            string provider, email, telephone;

            OracleCommand cmd = new OracleCommand("SelectAllProviders", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            OracleParameter oraP = new OracleParameter("p_cursor", OracleDbType.RefCursor, System.Data.ParameterDirection.Output);

            cmd.Parameters.Add(oraP);
            OracleDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while(reader.Read())
                {
                    provider = reader.GetString(0);
                    email = reader.GetString(1);
                    telephone = reader.GetString(2);
                    Providers.Add(new Provider(provider, email, telephone));
                }
            }
            con.Close();
        }

        public void GetAllDeliveryPoints(bool isAdmin)
        {
            DeliveryPoints.Clear();
            OracleConnection con;
            if (isAdmin)
                con = new OracleConnection(connectionAdmin);
            else
                con = new OracleConnection(connectionUser);
            con.Open();

            string name, address, telephone;

            OracleCommand cmd = new OracleCommand("SelectAllDeliveryPoints", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            OracleParameter oraP = new OracleParameter("p_cursor", OracleDbType.RefCursor, System.Data.ParameterDirection.Output);

            cmd.Parameters.Add(oraP);
            OracleDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    name = reader.GetString(0);
                    address = reader.GetString(1);
                    telephone = reader.GetString(2);
                    DeliveryPoints.Add(new DeliveryPoint(name, address, telephone));
                }
            }
            con.Close();
        }

        public void GetAllEmployees(bool isAdmin)
        {
            Employees.Clear();
            OracleConnection con;
            if (isAdmin)
                con = new OracleConnection(connectionAdmin);
            else
                con = new OracleConnection(connectionUser);
            con.Open();

            int id;
            string name, email, telephone;

            OracleCommand cmd = new OracleCommand("SelectAllEmployees", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            OracleParameter oraP = new OracleParameter("p_cursor", OracleDbType.RefCursor, System.Data.ParameterDirection.Output);

            cmd.Parameters.Add(oraP);
            OracleDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    id = reader.GetInt32(0);
                    name = reader.GetString(1);
                    email = reader.GetString(2);
                    telephone = reader.GetString(3);
                    Employees.Add(new Employee(id, name, email, telephone));
                }
            }
            con.Close();
        }

        public void GetAllProducts(bool isAdmin)
        {
            Products.Clear();
            OracleConnection con;
            if (isAdmin)
                con = new OracleConnection(connectionAdmin);
            else
                con = new OracleConnection(connectionUser);
            con.Open();

            int id, price, rating;
            string title, provider, type;
            OracleBlob blob;

            OracleCommand cmd = new OracleCommand("SelectAllProducts", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            OracleParameter oraP = new OracleParameter("p_cursor", OracleDbType.RefCursor, System.Data.ParameterDirection.Output);

            cmd.Parameters.Add(oraP);
            OracleDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    id = reader.GetInt32(0);
                    title = reader.GetString(1);
                    price = reader.GetInt32(2);
                    provider = reader.GetString(3);
                    type = reader.GetString(4);
                    rating = reader.GetInt32(5);
                    blob = reader.GetOracleBlob(6);
                    Byte[] byteArr = new Byte[blob.Length];
                    int i = blob.Read(byteArr, 0, System.Convert.ToInt32(blob.Length));
                    MemoryStream memstream = new MemoryStream(byteArr);
                    Products.Add(new Product(id, title, price, provider, type, rating, memstream));
                }
            }
            con.Close();
        }

        public void GetAllUsers(bool isAdmin)
        {
            Users.Clear();
            OracleConnection con;
            if (isAdmin)
                con = new OracleConnection(connectionAdmin);
            else
                con = new OracleConnection(connectionUser);
            con.Open();

            string login, password, email, fullname, address, telephone, isadm;

            OracleCommand cmd = new OracleCommand("SelectAllUsers", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            OracleParameter oraP = new OracleParameter("p_cursor", OracleDbType.RefCursor, System.Data.ParameterDirection.Output);

            cmd.Parameters.Add(oraP);
            OracleDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    login = reader.GetString(0);
                    password = reader.GetString(1);
                    email = reader.GetString(2);
                    fullname = reader.GetString(3);
                    address = reader.GetString(4);
                    telephone = reader.GetString(5);
                    isadm = reader.GetString(6);
                    Users.Add(new User(login, password, email, fullname, address, telephone, isadm));
                }
            }
            con.Close();
        }

        public void GetLoginsAndPasswords(bool isAdmin)
        {
            Users.Clear();
            OracleConnection con;
            if (isAdmin)
                con = new OracleConnection(connectionAdmin);
            else
                con = new OracleConnection(connectionUser);
            con.Open();

            string login, password, isadm;

            OracleCommand cmd = new OracleCommand("SelectAllUsers", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            OracleParameter oraP = new OracleParameter("p_cursor", OracleDbType.RefCursor, System.Data.ParameterDirection.Output);

            cmd.Parameters.Add(oraP);
            OracleDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    login = reader.GetString(0);
                    password = reader.GetString(1);
                    isadm = reader.GetString(6);
                    Users.Add(new User(login, password, isadm));
                }
            }
            con.Close();
        }

        public void GetAllDeliverys(bool isAdmin)
        {
            Deliverys.Clear();
            OracleConnection con;
            if (isAdmin)
                con = new OracleConnection(connectionAdmin);
            else
                con = new OracleConnection(connectionUser);
            con.Open();

            int id_del, id_emp, id_ord;
            string status;

            OracleCommand cmd = new OracleCommand("SelectAllDeliverys", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            OracleParameter oraP = new OracleParameter("p_cursor", OracleDbType.RefCursor, System.Data.ParameterDirection.Output);

            cmd.Parameters.Add(oraP);
            OracleDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    id_del = reader.GetInt32(0);
                    id_emp = reader.GetInt32(1);
                    status = reader.GetString(2);
                    id_ord = reader.GetInt32(3);
                    Deliverys.Add(new Delivery(id_del, id_emp, status, id_ord));
                }
            }
            con.Close();
        }

        public void GetAllOrders(bool isAdmin)
        {
            UsersOrders.Clear();
            OracleConnection con;
            if (isAdmin)
                con = new OracleConnection(connectionAdmin);
            else
                con = new OracleConnection(connectionUser);
            con.Open();

            int id_ord, ordercost, id_emp;
            string userlogin, deliverypointname, orddate;

            OracleCommand cmd = new OracleCommand("SelectAllOrders", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            OracleParameter oraP = new OracleParameter("p_cursor", OracleDbType.RefCursor, System.Data.ParameterDirection.Output);

            cmd.Parameters.Add(oraP);
            OracleDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    id_ord = reader.GetInt32(0);
                    orddate = reader.GetString(1);
                    ordercost = reader.GetInt32(2);
                    userlogin = reader.GetString(3);
                    id_emp = reader.GetInt32(4);
                    deliverypointname = reader.GetString(5);
                    UsersOrders.Add(new Order(id_ord,orddate, ordercost, userlogin, id_emp, deliverypointname));
                }
            }
            con.Close();
        }

        public void GetAllOrdersProducts(bool isAdmin)
        {
            OrdersProducts.Clear();
            OracleConnection con;
            if (isAdmin)
                con = new OracleConnection(connectionAdmin);
            else
                con = new OracleConnection(connectionUser);
            con.Open();

            int id_ord, id_prod;

            OracleCommand cmd = new OracleCommand("SelectAllOrdersProducts", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            OracleParameter oraP = new OracleParameter("p_cursor", OracleDbType.RefCursor, System.Data.ParameterDirection.Output);

            cmd.Parameters.Add(oraP);
            OracleDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    id_ord = reader.GetInt32(0);
                    id_prod = reader.GetInt32(1);
                    OrdersProducts.Add(new OrderProduct(id_ord, id_ord));
                }
            }
            con.Close();
        }
    }
}