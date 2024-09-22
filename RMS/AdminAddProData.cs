using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace RMS
{
    class AdminAddProData
    {
        SqlCommand cmd;
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\MCA\ASP.NET\RMS\RMS\RMS.mdf;Integrated Security=True");


        //Admin  Product Part Start
        public int ID1 { set; get; } //index [0]
        public string ProductID { set; get; } //index [2] sem all..
        public string ProductName { set; get; }
        public string Type { set; get; }
        public string Stock { set; get; }
        public string Price { set; get; }
        public string Status { set; get; }
        public string proImage { set; get; }
        public string DataInsert { set; get; }
        public string DataUpdate { set; get; }

        public List<AdminAddProData> ProductListData()
        {
            List<AdminAddProData> listData = new List<AdminAddProData>();
            if (con.State == ConnectionState.Closed)
            {
                try
                {
                    con.Open();
                    string selectData = "select *from products where data_delete IS NULL";
                    using (SqlCommand cmd1 = new SqlCommand(selectData, con))
                    {
                        SqlDataReader reader1 = cmd1.ExecuteReader();
                        while (reader1.Read())
                        {
                            AdminAddProData ad = new AdminAddProData();
                            ad.ID1 = (int)reader1["id"];
                            ad.ProductID = reader1["P_id"].ToString();
                            ad.ProductName = reader1["p_name"].ToString();
                            ad.Type = reader1["p_type"].ToString();
                            ad.Stock = reader1["p_stock"].ToString();
                            ad.Price = reader1["p_price"].ToString();
                            ad.Status = reader1["p_status"].ToString();
                            ad.proImage = reader1["p_image"].ToString();
                            ad.DataInsert = reader1["data_insert"].ToString();
                            ad.DataUpdate = reader1["data_update"].ToString();

                            listData.Add(ad);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Messages.."+ex);
                }
                finally
                {
                    con.Close();
                }
            }

            return listData;
        }
        public List<AdminAddProData> availableProductsData() {
            List<AdminAddProData> listdata = new List<AdminAddProData>();
            if (con.State==ConnectionState.Closed) {
                try
                {
                    con.Open();
                    string selectData = "select *from products where status =@status";
                    using (SqlCommand cmd = new SqlCommand(selectData, con))
                    {
                        cmd.Parameters.AddWithValue("@status", "Available");

                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            AdminAddProData ad = new AdminAddProData();
                            ad.ID1 = (int)reader["id"];
                            ad.ProductID = reader["P_id"].ToString();
                            ad.ProductName = reader["p_name"].ToString();
                            ad.Type = reader["p_type"].ToString();
                            ad.Stock = reader["p_stock"].ToString();
                            ad.Price = reader["p_price"].ToString();
                          

                            listdata.Add(ad);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Connection Failed...!"+ex);
                }
                finally 
                {
                    con.Close();
                }
            }
            return listdata; 
        }
    }
}
