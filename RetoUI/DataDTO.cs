using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace RetoUI
{
    public class Root
    {
        public Data data { get; set; }
        public Settings settings { get; set; }
    }

    public class Data
    {
        public List<Customer> customers { get; set; }
        public List<Sale> sales { get; set; }
    }

    public class Customer
    {
        public int id { get; set; }
        public string name { get; set; }
        public string cellphone { get; set; }
        public string address { get; set; }
    }

    public class Sale
    {
        // Puedes definir las propiedades de las ventas aquí
    }

    public class Settings
    {
        public string username { get; set; }
    }

}


