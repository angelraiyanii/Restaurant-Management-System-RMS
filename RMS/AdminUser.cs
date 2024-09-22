using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace RMS
{
    class AdminUser
    {
        SqlCommand cmd;
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\MCA\ASP.NET\RMS\RMS\RMS.mdf;Integrated Security=True");
        //user Part start
        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string Status { get; set; }
        public string Image { get; set; }
        public string DaraRegistor { get; set; }

        public List<AdminUser> userlistdata()
        {

            List<AdminUser> listdata = new List<AdminUser>();

            if (con.State != ConnectionState.Open)
            {
                try
                {
                    con.Open();
                    string selectdata = "select *from [users]";
                    using (SqlCommand cmd = new SqlCommand(selectdata, con))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            AdminUser userdata = new AdminUser();
                            userdata.ID = (int)reader["id"];
                            userdata.Username = reader["Username"].ToString();
                            userdata.Password = reader["password"].ToString();
                            userdata.Role = reader["role"].ToString();
                            userdata.Status = reader["status"].ToString();
                            userdata.Image = reader["Profile_image"].ToString();
                            userdata.DaraRegistor = reader["date_reg"].ToString();

                            listdata.Add(userdata);
                        }

                        //SqlDataAdapter da = new SqlDataAdapter(cmd);
                        //DataTable dt = new DataTable();
                        //da.Fill(dt);

                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Connection Fail.." + ex);
                }
                finally
                {
                    con.Close();
                }
            }
            return listdata;
        }
        //user Part end
    }
}
