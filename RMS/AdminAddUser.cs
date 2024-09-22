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
    public partial class AdminAddUser : UserControl
    {
        SqlCommand cmd;
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\MCA\ASP.NET\RMS\RMS\RMS.mdf;Integrated Security=True");

        public AdminAddUser()
        {
            InitializeComponent();
            DisplayAdminUser();
        }
        public void DisplayAdminUser() {
            AdminUser userData = new AdminUser();
            List<AdminUser> listdata = userData.userlistdata();

            dataGridView1.DataSource = listdata;
        }
        public bool emptyFile() {
            if (AddminAdd_user.Text == "" || AddminAdd_Password.Text == "" || AddminAdd_Role.Text == "" 
                || AddminAdd_Status.Text == "" || AddminAdd_PicView.Image==null)
            {
                return true;
            }
            else {
                return false;
            }
    
        }
        private void AddminAdd_addBtn_Click(object sender, EventArgs e)
        {
            if (emptyFile())
            {
                MessageBox.Show("All Filed Are Required..", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else {
                if (con.State == ConnectionState.Closed)
                {
                    try {
                        con.Open();
                        //check username if existing already
                     
                        string selectuser = "select *from [users] where username=@usern";
                        using (SqlCommand cmd = new SqlCommand(selectuser, con))
                        {
                            cmd.Parameters.AddWithValue("@usern", AddminAdd_user.Text.Trim()) ;
                            SqlDataAdapter da = new SqlDataAdapter(cmd);
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            if (dt.Rows.Count >= 1)
                            {

                                string usern = AddminAdd_user.Text.Substring(0, 1).ToUpper() + AddminAdd_user.Text.Substring(1);
                                MessageBox.Show(usern + "It is Already taken", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                            else {
                                string insertdata = "insert into [users] (username,password,Profile_image,role,status,date_reg)" +
                                    "values(@usern,@pass,@image,@role,@status,@date)";

                                DateTime today = DateTime.Today;

                                string path = Path.Combine(@"C:\MCA\ASP.NET\RMS\RMS\User_Directory\"+AddminAdd_user.Text.Trim()+".jpg");

                                string directorypath = Path.GetDirectoryName(path);
                                if (!Directory.Exists(directorypath))
                                {
                                    Directory.CreateDirectory(directorypath);
                                }
                                File.Copy(AddminAdd_PicView.ImageLocation, path, true);

                                using (SqlCommand cmdi = new SqlCommand(insertdata, con))
                                {
                                    cmdi.Parameters.AddWithValue("@usern",AddminAdd_user.Text.Trim());
                                    cmdi.Parameters.AddWithValue("@pass",AddminAdd_Password.Text.Trim());
                                    cmdi.Parameters.AddWithValue("@image",path);
                                    cmdi.Parameters.AddWithValue("@role", AddminAdd_Role.Text.Trim()); ;
                                    cmdi.Parameters.AddWithValue("@status",AddminAdd_Status.Text.Trim());
                                    cmdi.Parameters.AddWithValue("@date",today);

                                    cmdi.ExecuteNonQuery();
                                    clearFile();

                                    MessageBox.Show("Added successfully...😍","Information Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
                                    DisplayAdminUser();
                                }
                            }
                        }
                    }
                    catch (Exception ex) {
                        MessageBox.Show("Connection Not Connected.."+ex ,"Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally {
                        con.Close();
                    }
                }
                
            }
        }

        private void Addmin_importBtn_Click(object sender, EventArgs e)
        {
            try {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "All Files(*.jpg; *.PNG | *.jpg; *.PNG )";
                string imagePath = "";

                if (dialog.ShowDialog() == DialogResult.OK)
                {

                    imagePath = dialog.FileName;
                    AddminAdd_PicView.ImageLocation = imagePath;

                }
            }
            catch (Exception ex) {
                MessageBox.Show("Somthing Went Wrong...!");
            }
        }
        private int id = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            id = (int)row.Cells[0].Value;
            AddminAdd_user.Text = row.Cells[1].Value.ToString();
            AddminAdd_Password.Text = row.Cells[2].Value.ToString();
            AddminAdd_Role.Text = row.Cells[3].Value.ToString();
            AddminAdd_Status.Text = row.Cells[4].Value.ToString();

            string imagePath = row.Cells[5].Value.ToString();

            try
            {
                if (imagePath != null)
                {
                    AddminAdd_PicView.Image = Image.FromFile(imagePath);
                }
                else
                {
                    AddminAdd_PicView.Image = null;
                }
            }
            catch (Exception ex) {
                MessageBox.Show("No Image :","Error Message",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void AddminAdd_UpdateBtn_Click(object sender, EventArgs e)
        {
            if (emptyFile())
            {
                MessageBox.Show("All Fields are Requred..");
            }
            else {
                if (con.State != ConnectionState.Open)
                {
                    try {
                        con.Open();
                        string updatedata = "update users set username=@usern , password = @pass , role =@role,status =@statue where id =@id";
                        using (SqlCommand cmd = new SqlCommand(updatedata, con))
                        {
                            cmd.Parameters.AddWithValue("@usern",AddminAdd_user.Text.Trim());
                            cmd.Parameters.AddWithValue("@pass", AddminAdd_Password.Text.Trim());
                            cmd.Parameters.AddWithValue("@role", AddminAdd_Role.Text.Trim());
                            cmd.Parameters.AddWithValue("@statue", AddminAdd_Status.Text.Trim());
                            cmd.Parameters.AddWithValue("@id", id);
                            cmd.ExecuteNonQuery();
                            clearFile();
                            MessageBox.Show("Update Successfully..!");
                            DisplayAdminUser();
                        }
                    }
                    catch (Exception ex) {
                        MessageBox.Show("Connection Fail...! "+ex,"Error Message", MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                    finally { con.Close(); }
                }
            }
        }
        public void clearFile() {
            AddminAdd_user.Text = "";
            AddminAdd_Password.Text = "";
            AddminAdd_Role.SelectedIndex = -1;
            AddminAdd_Status.SelectedIndex = -1;
            AddminAdd_PicView.Image = null;
        }
        private void AddminAdd_ClearBtn_Click(object sender, EventArgs e)
        {
            clearFile();
        }

        private void AddminAdd_DeleteBtn_Click(object sender, EventArgs e)
        {
            if (emptyFile())
            {
                MessageBox.Show("All Fields are Requred..");
            }
            else
            {
                if (con.State != ConnectionState.Open)
                {
                    try
                    {
                        con.Open();
                        string deletedata = "delete from users where id =@id";
                        using (SqlCommand cmd = new SqlCommand(deletedata, con))
                        {
                           
                            cmd.Parameters.AddWithValue("@id", id);
                            cmd.ExecuteNonQuery();
                            clearFile();

                            MessageBox.Show("Delete Successfully..!");
                            DisplayAdminUser();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Connection Fail...! " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally { con.Close(); }
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
