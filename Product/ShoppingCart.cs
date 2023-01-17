using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShopLibrary
{
    public class ShoppingCart
    {
        private List<Product> products = new List<Product>();
        private List<int> productQuantity = new List<int>();
        public List<Product> Products { get { return products; } set { products = value; } }
        public List<int> ProductQuantity { get { return productQuantity; } set { productQuantity = value; } }

        
    }
}
