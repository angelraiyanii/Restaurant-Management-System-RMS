using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RMS
{
    public partial class AdminMainfrom : Form
    {
        public AdminMainfrom()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are You sure YOu want To Sign Out ..?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                Login l = new Login();
                this.Hide();
                l.Show();
            }
        }

        private void adminAddUser1_Load(object sender, EventArgs e)
        {
        }

        private void addminAddProduct1_Load(object sender, EventArgs e)
        {

        }

        private void btn_dashBord_Click(object sender, EventArgs e)
        {
            adminDashbord1.Visible = true;
            adminAddUser1.Visible = false;
            addminAddProduct1.Visible = false;

        }

        private void btn_customer_Click(object sender, EventArgs e)
        {
            adminDashbord1.Visible = false;
            adminAddUser1.Visible = true;
            addminAddProduct1.Visible = false;
        }

        private void btn_products_Click(object sender, EventArgs e)
        {
            adminDashbord1.Visible = false;
            adminAddUser1.Visible = false;
            addminAddProduct1.Visible = true;
        }
    }
}
