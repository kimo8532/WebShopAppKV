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
    public partial class AdminDashboardForm : Form
    {
        private BindingSource tableBindingSource = new BindingSource();
        public BindingSource TableBindingSource { get { return tableBindingSource; } set { tableBindingSource = value; } }
        public AdminDashboardForm()
        {
            InitializeComponent();
            comboBoxCategory.DataSource = ProductRepository.GetCategory();
            comboBoxCategoryUpdate.DataSource = ProductRepository.GetCategory();
            tableBindingSource.DataSource = ProductRepository.GetProductsDB();
            dataGridView1.DataSource = TableBindingSource;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.HotPink;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.DataSource = TableBindingSource;
            dataGridView2.ColumnHeadersDefaultCellStyle.BackColor = Color.HotPink;
            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView2.CellDoubleClick += new DataGridViewCellEventHandler(dataGridView2_CellClick);
            dataGridView3.AutoGenerateColumns = false;
            dataGridView3.DataSource = TableBindingSource;
            dataGridView3.ColumnHeadersDefaultCellStyle.BackColor = Color.HotPink;
            dataGridView3.EnableHeadersVisualStyles = false;
            dataGridView3.CellDoubleClick += new DataGridViewCellEventHandler(dataGridView3_CellClick);
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void labelProductName_Click(object sender, EventArgs e)
        {

        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            try
            {
                Product product = new Product()
                {
                    id = $"{ProductRepository.GetProductsDB().Count() + 1}",
                    title = textBoxProductName.Text,
                    price = float.Parse(textBoxPrice.Text),
                    description = richTextBoxProductDescription.Text,
                    category = comboBoxCategory.Text,
                    image = textBoxImageUrl.Text
                };
                ProductRepository.CreateProductDb(product);
            }
            catch (Exception ex)
            {

                Label CreationFailed = new Label();
                CreationFailed.Text = ex.Message;
                CreationFailed.BackColor = Color.Red;
                CreationFailed.ForeColor = Color.Black;
                CreationFailed.Font = new Font("Nirmala UI", 8f, FontStyle.Bold);
                CreationFailed.Location = new Point(85, 281);
                CreationFailed.AutoSize = true;
                tabControl1.TabPages[1].Controls.Add(CreationFailed);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            List<Product> products = ProductRepository.GetProductsDB();
            textBoxProductNameUpdate.Text = products[e.RowIndex].title;
            textBoxPriceUpdate.Text = $"{Convert.ToString(products[e.RowIndex].price)}€";
            textBoxImageUrlUpdate.Text = products[e.RowIndex].image;
            richTextBoxProductDescription.Text = products[e.RowIndex].description;
            labelID.Text= products[e.RowIndex].id;
        }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBoxImageUrlUpdate_TextChanged(object sender, EventArgs e)
        {
            pictureBoxProductImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxProductImage.Load(textBoxImageUrlUpdate.Text);
        }
        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            List<Product> products = ProductRepository.GetProductsDB();
            labelProductTitleDelete.Text = products[e.RowIndex].title;
            labelProductId.Text = products[e.RowIndex].id;
        }
        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Label DeleteAlert = new Label();
            DeleteAlert.BackColor = Color.Red;
            DeleteAlert.ForeColor = Color.Black;
            DeleteAlert.Font = new Font("Nirmala UI", 8f, FontStyle.Bold);
            DeleteAlert.Location = new Point(85, 281);
            DeleteAlert.AutoSize = true;
            tabControl1.TabPages[3].Controls.Add(DeleteAlert);
            if (!(labelProductId.Text == "ID"))
            {
                List<Product> products = ProductRepository.GetProductsDB();
                if (checkBoxCheckDelete.Checked)
                {
                    ProductRepository.DeleteProduct(labelProductId.Text);
                    DeleteAlert.Text = "You have successfully deleted a product!";
                    tableBindingSource.DataSource = ProductRepository.GetProductsDB();
                }
                else
                {
                    DeleteAlert.Text = "You haven't checked the checkbox";
                }
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            Label UpdateAlert = new Label();
            UpdateAlert.BackColor = Color.Red;
            UpdateAlert.ForeColor = Color.Black;
            UpdateAlert.Font = new Font("Nirmala UI", 8f, FontStyle.Bold);
            UpdateAlert.Location = new Point(85, 281);
            UpdateAlert.AutoSize = true;
            tabControl1.TabPages[2].Controls.Add(UpdateAlert);
            if (!(textBoxProductNameUpdate.Text == "") && !(textBoxPriceUpdate.Text == "") && !(richTextBoxDescriptionUpdate.Text == "") && !(comboBoxCategoryUpdate.Text == "") && !(textBoxImageUrlUpdate.Text == ""))
            {
                try
                {
                    ProductRepository.UpdateProduct(new Product()
                    {
                        id = labelID.Text,
                        title = textBoxProductNameUpdate.Text,
                        price = float.Parse(textBoxPriceUpdate.Text),
                        description = richTextBoxDescriptionUpdate.Text,
                        category = comboBoxCategoryUpdate.Text,
                        image = textBoxImageUrlUpdate.Text
                    });
                    UpdateAlert.Text = "You have successfully updated a product!";
                    tableBindingSource.DataSource = ProductRepository.GetProductsDB();
                }
                catch(Exception ex)
                {
                    UpdateAlert.Text= ex.Message;
                }
            }
            else
            {
                UpdateAlert.Text = "Please enter all the information";
            }
        }
    }
}
