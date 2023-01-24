using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebShopLibrary;

namespace MainForm
{
    public partial class AdminLoginForm : Form
    {
        public AdminLoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AdminLoginForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            bool validUser = false;
            foreach (User u in UserRepository.GetUsers())
            {
                if (u.Username == textBoxUsername.Text && u.Password == textBoxPassword.Text)
                {
                    validUser = true; break;
                }
            }
            if (validUser)
            {
                AdminDashboardForm form = new AdminDashboardForm();
                this.Hide();
                form.Show();
            }
            else
            {
                Label loginStatus = new Label();
                loginStatus.Text = "Login failed, invalid credentials";
                loginStatus.BackColor = Color.Red;
                loginStatus.ForeColor = Color.Black;
                loginStatus.Font = new Font("Nirmala UI", 10.75f, FontStyle.Bold);
                loginStatus.Location = new Point(340, 315);
                loginStatus.AutoSize = true;
                this.Controls.Add(loginStatus);

            }

        }
    }
}
