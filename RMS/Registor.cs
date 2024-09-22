using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RMS
{
    public partial class Registor : Form
    {
        SqlCommand cmd;
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\MCA\ASP.NET\RMS\RMS\RMS.mdf;Integrated Security=True");

        public Registor()
        {
            InitializeComponent();
        }

        public bool EmantyFields()
        {
            if (Rusername.Text == "" || PasswordR.Text == "" || Rpassword.Text == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        
        private void reg_signin_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            this.Hide();
            l.Show();
        }

       
        private void reg_btn_Click_1(object sender, EventArgs e)
        {
            if (EmantyFields())
            {
                MessageBox.Show("All Fields Are Required...!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (con.State == ConnectionState.Closed)
                {
                    try
                    {
                        con.Open();
                        string userq = "select * from users where username = @usern";
                        using (SqlCommand cmd = new SqlCommand(userq, con))
                        {
                            cmd.Parameters.AddWithValue("@usern", Rusername.Text.Trim());

                            SqlDataAdapter da = new SqlDataAdapter(cmd);
                            DataTable dt = new DataTable();
                            da.Fill(dt);

                            if (dt.Rows.Count >= 1)
                            {
                                string usern = Rusername.Text.Substring(0, 1).ToUpper() + Rusername.Text.Substring(1);
                                MessageBox.Show(usern + " is already taken", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else if (Rpassword.Text != PasswordR.Text)
                            {
                                MessageBox.Show("Password does not match", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertQ = "insert into users (username, password, Profile_image, role, status, date_reg) " +
                                                 "values (@usern, @pass, @image, @role, @status, @date)";
                                DateTime today = DateTime.Today;

                                using (SqlCommand insertCmd = new SqlCommand(insertQ, con))
                                {
                                    insertCmd.Parameters.AddWithValue("@usern", Rusername.Text.Trim());
                                    insertCmd.Parameters.AddWithValue("@pass", Rpassword.Text.Trim());
                                    insertCmd.Parameters.AddWithValue("@image", "");
                                    insertCmd.Parameters.AddWithValue("@role", "Cashier");
                                    insertCmd.Parameters.AddWithValue("@status", "Approval");
                                    insertCmd.Parameters.AddWithValue("@date", today);

                                    insertCmd.ExecuteNonQuery();

                                    MessageBox.Show("User registered successfully...😍", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    Login l = new Login();
                                    this.Hide();
                                    l.Show();
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Connection failed: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        con.Close();
                    }
                }
            }
        }

        private void reg_showpass_CheckedChanged(object sender, EventArgs e)
        {
            Rpassword.PasswordChar = reg_showpass.Checked ? '\0' : '●';
            PasswordR.PasswordChar = reg_showpass.Checked ? '\0' : '●';
        }
    }
}
