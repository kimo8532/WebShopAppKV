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
    public partial class ShoppingCartForm : Form
    {
        private ShoppingCart _shoppingCart = new ShoppingCart();
        public ShoppingCartForm(ShoppingCart shoppingCart)
        {
            InitializeComponent();
            _shoppingCart = shoppingCart;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.HotPink;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.CellClick += new DataGridViewCellEventHandler(dataGridView1_CellClick);
            //dataGridView1.CellFormatting += new DataGridViewCellFormattingEventHandler(dataGridView1_CellFormatting);
        }

        private void ShoppingCartForm_Load(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = _bindingSource;
            float overAllPrice = 0;
            for (int i = 0; i < _shoppingCart.Products.Count; i++)
            {
                dataGridView1.Rows.Add(_shoppingCart.Products[i].id, _shoppingCart.Products[i].title, _shoppingCart.Products[i].price, _shoppingCart.ProductQuantity[i]);
                overAllPrice += _shoppingCart.Products[i].price * _shoppingCart.ProductQuantity[i];
            }
            labelPrice.Text = overAllPrice.ToString() + "€";
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                float overAllPrice = 0;
                if (e.ColumnIndex == 4)
                {
                    dataGridView1.Rows.RemoveAt(e.RowIndex);
                    _shoppingCart.Products.RemoveAt(e.RowIndex);
                    for (int i = 0; i < _shoppingCart.Products.Count; i++)
                    {
                        overAllPrice += _shoppingCart.Products[i].price * _shoppingCart.ProductQuantity[i];
                    }
                    labelPrice.Text = overAllPrice.ToString() + "€";
                }
            }
            catch (Exception)
            {

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
 
        }
        //private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        //{
        //    DataGridViewColumn column = dataGridView1.Columns[e.ColumnIndex];
        //    if (column.DataPropertyName.Contains("."))
        //    {
        //        object data = dataGridView1.Rows[e.RowIndex].DataBoundItem;
        //        string[] properties = column.DataPropertyName.Split('.');
        //        for (int i = 0; i < properties.Length && data != null; i++)
        //            data = data.GetType().GetProperty(properties[i]).GetValue(data);
        //        dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = data;
        //    }
        //}

        private void shoppingCartBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void labelPrice_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            CheckoutForm checkoutForm = new CheckoutForm(_shoppingCart);
            checkoutForm.Show();
            this.Hide();
        }
    }
}
