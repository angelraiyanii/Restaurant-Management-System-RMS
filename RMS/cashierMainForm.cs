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
    public partial class cashierMainForm : Form
    {
        public cashierMainForm()
        {
            InitializeComponent();
        }

        private void logout_btnU_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are You sure YOu want To Sign Out ..?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                Login l = new Login();
                this.Hide();
                l.Show();
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    }

