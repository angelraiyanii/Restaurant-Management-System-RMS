﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace RMS
{
    public partial class CashierOrder : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\MCA\ASP.NET\RMS\RMS\RMS.mdf;Integrated Security=True");

        public CashierOrder()
        {
            InitializeComponent();
            DisplayAvailableprods();
        }
        public void DisplayAvailableprods() {
            AdminAddProData allpro = new AdminAddProData();

            List<AdminAddProData> listData = allpro.availableProductsData();
            cashierOrder_menuTable.DataSource = listData;
        } 

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
