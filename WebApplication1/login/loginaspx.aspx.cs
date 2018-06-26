using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication1.login
{
    public partial class loginaspx : System.Web.UI.Page
    {
        int i;
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\diego\source\repos\WebApplication1\WebApplication1\App_Data\shopping.mdf;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void b2_Click(object sender, EventArgs e)
        {
            i = 0;
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "select * from admin_login where username='"+TextBox1.Text+"' and password='"+TextBox2.Text+"'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            i = Convert.ToInt32(dt.Rows.Count.ToString());
            Response.Write(i);

            if (i==1)
            {
                if(Session["checkoutbutton"] == "yes")
                {
                    Session["user"] = TextBox1.Text;
                    Response.Redirect("../home/update_order_details.aspx");

                }
                else
                {
                    Session["user"] = TextBox1.Text;

                    Response.Redirect("../home/order_details.aspx");
                }

            }
            else
            {
                l1.Text = "Credenciales Invalidas";
            }
            con.Close();

        }
    }
}