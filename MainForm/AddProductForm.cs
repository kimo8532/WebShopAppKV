using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebShopLibrary;

namespace MainForm
{
    public partial class AddProductForm : Form
    {
        public Product Product { get; set; }
        ShoppingCart shoppingCartcurr = new ShoppingCart();
        ShoppingCart ShoppingCartcurr { get { return shoppingCartcurr; } set { shoppingCartcurr = value;} }
        public AddProductForm(Product product, ref ShoppingCart shoppingCart)
        {
            InitializeComponent();
            Product = product;
            ShoppingCartcurr = shoppingCart;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddProductForm_Load(object sender, EventArgs e)
        {
            labelProductName.Text = Product.title; ;
            labelPrice.Text = $"{Convert.ToString(Product.price)}€";
            pictureBoxProductImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxProductImage.Load(Product.image);
            richTextBoxProductDescription.Text = Product.description;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShoppingCartcurr.Products.Add(Product);
            shoppingCartcurr.ProductQuantity.Add((int)numericUpDownQuantityProduct.Value);
            this.Hide();
        }

        private void buttonCloseForm_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pictureBoxProductImage_Click(object sender, EventArgs e)
        {

        }
    }
}
