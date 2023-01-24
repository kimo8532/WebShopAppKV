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
using System.Diagnostics;

namespace MainForm
{
    public partial class Form1 : Form
    {
        private BindingSource tableBindingSource = new BindingSource();
        public BindingSource TableBindingSource { get { return tableBindingSource; } set { tableBindingSource = value; } }
        public ShoppingCart shoppingCart = new ShoppingCart();

        public Form1()
        {
            InitializeComponent();
            tableBindingSource.DataSource = ProductRepository.GetProducts();
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.HotPink;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.CellDoubleClick += new DataGridViewCellEventHandler(dataGridView1_CellClick);
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            AddProductForm form = new AddProductForm((Product)tableBindingSource.List[e.RowIndex], ref shoppingCart);
            form.Show();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxFilter.DataSource = ProductRepository.GetCategory();
            dataGridView1.DataSource = TableBindingSource;
        }

        private void comboBoxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            TableBindingSource.DataSource = ProductRepository.Filter(comboBoxFilter.Text);
            dataGridView1.DataSource = TableBindingSource.DataSource;
        }

        private void buttonCheckShoppingCart_Click(object sender, EventArgs e)
        {
            //Debug.Write($"{shoppingCart.Products[0]} {shoppingCart.ProductQuantity[0]}");
            ShoppingCartForm form = new ShoppingCartForm(shoppingCart);
            form.Show();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            AdminLoginForm adminLoginForm = new AdminLoginForm();
            adminLoginForm.Show();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            UpdateDataSource(checkBox1, checkBox2, ProductRepository.GetProducts(), ProductRepository.GetProductsDB());
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            UpdateDataSource(checkBox2, checkBox1, ProductRepository.GetProductsDB(), ProductRepository.GetProducts());
        }
        private void UpdateDataSource(CheckBox checkbox1, CheckBox checkbox2, object dataSource1, object dataSource2)
        {
            if (checkbox1.Checked)
            {
                tableBindingSource.DataSource = dataSource1;
                checkbox2.Checked = false;
            }
            else
            {
                tableBindingSource.DataSource = dataSource2;
                checkbox2.Checked = true;
            }
            dataGridView1.DataSource = tableBindingSource;
        }
    }
}
