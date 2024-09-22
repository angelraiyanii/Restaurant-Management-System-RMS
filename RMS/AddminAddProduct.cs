using System;
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
using System.IO;

namespace RMS
{
    public partial class AddminAddProduct : UserControl
    {
        SqlCommand cmd;
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\MCA\ASP.NET\RMS\RMS\RMS.mdf;Integrated Security=True");

        public AddminAddProduct()
        {
            InitializeComponent();
            Displaydata();
        }
        public bool emptyFiles()
        {
            if (AdminAddPro_Id.Text == "" || AdminAddPro_Name.Text == "" || AdminAddPro_Price.Text == "" || AdminAddPro_Status.SelectedIndex == -1 || AdminAddPro_Stock.Text == "" || AdminAddPro_Type.SelectedIndex == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Displaydata()
        {
            AdminAddProData proData = new AdminAddProData();
            List<AdminAddProData> lisData = proData.ProductListData();

            dataGridView1.DataSource = lisData;
        }
        private void AddminAddProduct_Load(object sender, EventArgs e)
        {

        }

        private void AdminAddPro_Addbtn_Click(object sender, EventArgs e)
        {
            if (emptyFiles())
            {
                MessageBox.Show("All Field Are Requred...!");
            }
            else
            {
                if (con.State == ConnectionState.Closed)
                {
                    try
                    {
                        con.Open();
                        // chack product id is existing already
                        string selectproId = "select * from products where p_id=@pro_id";
                        using (SqlCommand cmd1 = new SqlCommand(selectproId, con))
                        {
                            cmd1.Parameters.AddWithValue("@pro_id", AdminAddPro_Id.Text.Trim());
                            SqlDataAdapter da = new SqlDataAdapter(cmd1);
                            DataTable dt = new DataTable();
                            da.Fill(dt);

                            if (dt.Rows.Count >= 1)
                            {
                                MessageBox.Show("Product Id: " + AdminAddPro_Id.Text.Trim() + "is take Already");
                            }
                            else
                            {
                                // insert product data
                                string insertdata = "insert into products (p_id,p_name,p_type,p_stock,p_price,p_status,p_image,data_insert)values(@pro_id,@pro_name,@pro_type,@pro_stock,@pro_price,@pro_status,@pro_image,@pro_datainsert)";

                                DateTime today = DateTime.Today;

                                string path = Path.Combine(@"C:\MCA\ASP.NET\RMS\RMS\Product_Directory\" + AdminAddPro_Id.Text.Trim() + ".jpg");
                                string directorypath = Path.GetDirectoryName(path);
                                if (!Directory.Exists(directorypath))
                                {
                                    Directory.CreateDirectory(directorypath);
                                }
                                File.Copy(AdminAddPro_image.ImageLocation, path, true);

                                using (SqlCommand cmd = new SqlCommand(insertdata, con))
                                {
                                    cmd.Parameters.AddWithValue("@pro_id", AdminAddPro_Id.Text.Trim());
                                    cmd.Parameters.AddWithValue("@pro_name", AdminAddPro_Name.Text.Trim());
                                    cmd.Parameters.AddWithValue("@pro_type", AdminAddPro_Type.Text.Trim());
                                    cmd.Parameters.AddWithValue("@pro_stock", AdminAddPro_Stock.Text.Trim());
                                    cmd.Parameters.AddWithValue("@pro_price", AdminAddPro_Price.Text.Trim());
                                    cmd.Parameters.AddWithValue("@pro_status", AdminAddPro_Status.Text.Trim());
                                    cmd.Parameters.AddWithValue("@pro_image", path);
                                    cmd.Parameters.AddWithValue("@pro_datainsert", today);

                                    cmd.ExecuteNonQuery();
                                    clearFile();
                                    MessageBox.Show("Added successfully...😍", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    Displaydata();
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Connection Not Connected.." + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        con.Close();
                    }
                }
            }
        }

        private void AdminAddPro_importBtn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog fileDialog = new OpenFileDialog();
                fileDialog.Filter = "Image Files(*.jpg; *.png)| *.jpg; *.png";
                string imagePath = "";
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    imagePath = fileDialog.FileName;
                    AdminAddPro_image.ImageLocation = imagePath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);

            }
        }
        public void clearFile()
        {
            AdminAddPro_Id.Text = "";
            AdminAddPro_Name.Text = "";
            AdminAddPro_Type.SelectedIndex = -1;
            AdminAddPro_Stock.Text = "";
            AdminAddPro_Price.Text = "";
            AdminAddPro_Status.SelectedIndex = -1;
            AdminAddPro_image.Image = null;
        }

        private void AdminAddPro_clearBtn_Click(object sender, EventArgs e)
        {
            clearFile();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                AdminAddPro_Id.Text = row.Cells[1].Value.ToString();
                AdminAddPro_Name.Text = row.Cells[2].Value.ToString();
                AdminAddPro_Type.Text = row.Cells[3].Value.ToString();
                AdminAddPro_Stock.Text = row.Cells[4].Value.ToString();
                AdminAddPro_Price.Text = row.Cells[5].Value.ToString();
                AdminAddPro_Status.Text = row.Cells[6].Value.ToString();

                string imagepath = row.Cells[7].Value.ToString();

                try
                {
                    if (imagepath != null)
                    {
                        AdminAddPro_image.Image = Image.FromFile(imagepath);
                    }
                    else
                    {
                        AdminAddPro_image.Image = null;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Image" + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
        }

        private void AdminAddPro_Updatebtn_Click(object sender, EventArgs e)
        {
            if (emptyFiles())
            {

                MessageBox.Show("All Filed Are Requried...!");
            }
            else
            {
                DialogResult check = MessageBox.Show("Are You Sure To Update Product.. " + AdminAddPro_Id.Text.Trim() + " ?", "Comfrigration Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (check == DialogResult.Yes)
                {
                    if (con.State != ConnectionState.Open)
                    {
                        try { con.Open();
                            string updateData = "UPDATE products set p_name =@pname,p_type=@ptype,p_stock=@pstock,p_price=@pprice,p_status=" +
                                "@pstatus,data_update=@dataupdate where p_id =@proId";

                            DateTime today = DateTime.Today;
                            using (SqlCommand cmd1 = new SqlCommand(updateData, con))
                            {
                                
                                cmd1.Parameters.AddWithValue("@pname", AdminAddPro_Name.Text.Trim());
                                cmd1.Parameters.AddWithValue("@ptype", AdminAddPro_Type.Text.Trim());
                                cmd1.Parameters.AddWithValue("@pstock", AdminAddPro_Stock.Text.Trim());
                                cmd1.Parameters.AddWithValue("@pprice", AdminAddPro_Price.Text.Trim());
                                cmd1.Parameters.AddWithValue("@pstatus", AdminAddPro_Status.Text.Trim());
                                cmd1.Parameters.AddWithValue("@dataupdate", today);
                                cmd1.Parameters.AddWithValue("@proId", AdminAddPro_Id.Text.Trim());
                                cmd1.ExecuteNonQuery();
                                clearFile();
                                MessageBox.Show("Update successfully...😍", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Displaydata();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Connection Failed.." + ex);
                        }
                        finally { con.Close(); }
                    }
                }
                else { }
            }
        }

        private void AdminAddPro_Deletebtn_Click(object sender, EventArgs e)
        {
            if (emptyFiles())
            {

                MessageBox.Show("All Filed Are Requried...!");
            }
            else
            {
                DialogResult check = MessageBox.Show("Are You Sure To Delete Product.. " + AdminAddPro_Id.Text.Trim() + " ?", "Comfrigration Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (check == DialogResult.Yes)
                {
                    if (con.State != ConnectionState.Open)
                    {
                        try
                        {
                            con.Open();
                            string updateData = "UPDATE products set data_delete=@datadelete where p_id=@proId";

                            DateTime today = DateTime.Today;
                            using (SqlCommand delcmd = new SqlCommand(updateData, con))
                            {

                                delcmd.Parameters.AddWithValue("@datadelete", today);
                                delcmd.Parameters.AddWithValue("@proId", AdminAddPro_Id.Text.Trim());
                                delcmd.ExecuteNonQuery();
                                clearFile();
                                MessageBox.Show("Removed successfully...😍", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Displaydata();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Connection Failed.." + ex);
                        }
                        finally { con.Close(); }
                    }
                }
                else { }
            }
        }
    }
}
