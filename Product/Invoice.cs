using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShopLibrary
{
    public class Invoice
    {
        public int id { get; set; }
        public string paymentmethod { get; set; }
        public string address { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string phonenumber { get; set; }
        public string city { get; set; }
        public string postalcode { get; set; }
        public string creditCardNumber { get; set; }
        public string expirationDate { get; set; }
        public ShoppingCart shoppingCart { get; set; }
    }
}
