using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace WebApplication1.home
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        string username;
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\diego\source\repos\WebApplication1\WebApplication1\App_Data\shopping.mdf;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {
            if(IsPostBack)
            {
                return;
            }

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from admin_login where username='" + Session["user"].ToString() + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                t1.Text = dr["nombre"].ToString();
                t2.Text = dr["rut"].ToString();
                t3.Text = dr["email"].ToString();
                t4.Text = dr["telefono"].ToString();
                t5.Text = dr["direccion"].ToString();
                t6.Text = dr["codigopostal"].ToString();
                username = dr["username"].ToString();
            }
            con.Close();
        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update admin_login set nombre='" + t1.Text + "', rut='" + t2.Text + "', email='" + t3.Text + "', telefono='" + t4.Text +
                "', direccion='" + t5.Text + "', codigopostal='" + t6.Text + "' where username ='" + Session["user"].ToString() + "'";
            cmd.ExecuteNonQuery();
            con.Close();

            Response.Redirect("payment_gateway.aspx");
        }
    }
}