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

namespace RMS
{
    public partial class Login : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\MCA\ASP.NET\RMS\RMS\RMS.mdf;Integrated Security=True");
        public Login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void login_signup_Click(object sender, EventArgs e)
        {
            Registor r = new Registor();
            this.Hide();
            r.Show();
        }

        private void login_showpass_CheckedChanged(object sender, EventArgs e)
        {

        }
        public bool emptyfilds() {
            if (login_username.Text == "" | login_pass.Text == "")
            {
                return true;
            }
            else {
                return false;
            }
        }

        private void Check_login_CheckedChanged(object sender, EventArgs e)
        {
            login_pass.PasswordChar = Check_login.Checked ? '\0' : '●';

        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            if (emptyfilds())
            {
                MessageBox.Show("All Fildes Are Requried", "Error Message", MessageBoxButtons.OK);
            }
            else {
                if (con.State == ConnectionState.Closed)
                {
                    try
                    { con.Open();
                        string queyl = "select COUNT(*) from [users] where username=@usern AND password =@pass AND status=@status";
                        using (SqlCommand insertCmd = new SqlCommand(queyl, con))
                        {
                            insertCmd.Parameters.AddWithValue("@usern", login_username.Text.Trim());
                            insertCmd.Parameters.AddWithValue("@pass", login_pass.Text.Trim());
                            insertCmd.Parameters.AddWithValue("@status", "Active");


                            int rowCount = (int)insertCmd.ExecuteScalar();
                            if (rowCount > 0)
                            {
                                string selectRole = "Select role from [users] where username=@usern AND password=@pass";
                                using (SqlCommand cmd1 = new SqlCommand(selectRole, con))
                                {
                                    cmd1.Parameters.AddWithValue("@usern", login_username.Text.Trim());
                                    cmd1.Parameters.AddWithValue("@pass", login_pass.Text.Trim());

                                    string UserRole = cmd1.ExecuteScalar()as string;
                                    MessageBox.Show("User Login successfully...😍", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                
                                    if (UserRole == "Admin")
                                    {
                                        AdminMainfrom ad = new AdminMainfrom();
                                        this.Hide();
                                        ad.Show();
                                    }
                                    else if (UserRole == "Cashier")
                                    {
                                        cashierMainForm cm = new cashierMainForm();
                                        this.Hide();
                                        cm.Show();
                                    }
                                }
                               
                            }
                            else
                            {
                                MessageBox.Show("Invalid Username / Password there is no Admin Approval");

                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Connection Failed");
                    }
                    finally {
                        con.Close();
                    }
                }
              
            }
        }
    }
}
