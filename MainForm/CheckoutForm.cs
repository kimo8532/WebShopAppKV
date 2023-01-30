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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace MainForm
{
    public partial class CheckoutForm : Form
    {
        public ShoppingCart shoppingCart { get; set; }
        public CheckoutForm(ShoppingCart shoppingCart)
        {
            InitializeComponent();
            this.shoppingCart = shoppingCart;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void buttonPay_Click(object sender, EventArgs e)
        {
            try
            {
                string Name = textBoxName.Text;
                string Address = textBoxAddress.Text;
                string City = textBoxCity.Text;
                string Surname = textBoxSurname.Text;
                string PostalCode = textBoxPostalCode.Text;
                string PhoneNumber = textBoxPhoneNumber.Text;
                string CreditCardNumber = textBoxCreditCardNumber.Text;
                string ExpirationDate = textBoxExpirationDate.Text;
                if(checkBoxCreditCard.Checked)
                {
                    if(textBoxCreditCardNumber.Text == "" || textBoxExpirationDate.Text == "")
                    {
                        throw new Exception("Fill out your credit card details to proceed to checkout");
                    }
                    else if(textBoxName.Text == "" || textBoxAddress.Text == "" || textBoxCity.Text == "" || textBoxSurname.Text == "" || textBoxPostalCode.Text == "" || textBoxPhoneNumber.Text == "")
                    {
                        throw new Exception("Fill out your personal details");
                    }
                    Invoice invoice = new Invoice
                    {
                        paymentmethod = "Credit Card",
                        address = Address,
                        name = Name,
                        surname = Surname,
                        phonenumber = PhoneNumber,
                        city = City,
                        postalcode = PostalCode,
                        creditCardNumber = CreditCardNumber,
                        expirationDate = ExpirationDate,
                        shoppingCart = shoppingCart
                    };
                    InvoiceRepository.CreateInvoice(invoice);
                }
                else if(checkBoxCash.Checked)
                {
                    if (textBoxName.Text == "" || textBoxAddress.Text == "" || textBoxCity.Text == "" || textBoxSurname.Text == "" || textBoxPostalCode.Text == "" || textBoxPhoneNumber.Text == "")
                    {
                        throw new Exception("Fill out your personal details");
                    }
                    Invoice invoice = new Invoice
                    {
                        paymentmethod = "Cash",
                        address = Address,
                        name = Name,
                        surname = Surname,
                        phonenumber = PhoneNumber,
                        city = City,
                        postalcode = PostalCode,
                        creditCardNumber = null,
                        expirationDate = null,
                        shoppingCart = shoppingCart
                    };
                    InvoiceRepository.CreateInvoice(invoice);
                }
                else
                {
                    throw new Exception("Choose your method of paying");
                }
                this.Hide();
            }
            catch(Exception ex)
            {
                Label Alert = new Label();
                Alert.BackColor = Color.Red;
                Alert.ForeColor = Color.Black;
                Alert.Font = new Font("Nirmala UI", 8f, FontStyle.Bold);
                Alert.Location = new Point(85, 281);
                Alert.AutoSize = true;
                Alert.Text = ex.Message;
                this.Controls.Add(Alert);
            }
        }

        private void checkBoxCash_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxCash.Checked)
            {
                checkBoxCreditCard.Checked = false;
            }
        }

        private void checkBoxCreditCard_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxCreditCard.Checked)
            {
                checkBoxCash.Checked= false;
            }
        }

        private void CheckoutForm_Load(object sender, EventArgs e)
        {

        }
    }
}
