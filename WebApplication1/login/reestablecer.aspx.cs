using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.login
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        int i;
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\diego\source\repos\WebApplication1\WebApplication1\App_Data\shopping.mdf;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void bcomp_click(object sender, EventArgs e)
        {

            i = 0;
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "select * from admin_login where username='" + tusuario.Text + "' and password='"+tpassantigua.Text+"'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            i = Convert.ToInt32(dt.Rows.Count.ToString());
            Response.Write(i);

            if (i == 1)
            {
                if (tpass2.Text == tpass3.Text)
                {
                    cmd.CommandText = " UPDATE admin_login " +
     "SET password = '" + tpass2.Text + "'" +
    "WHERE username='" + tusuario.Text + "'";
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    l1.Text = "Las Contraseñas nuevas son Distintas, deben quedar iguales";
                }
            }
            else
            {
                l1.Text = "Error Ingresando Contraseñas, intente de nuevo";
            }

            con.Close();
        }
    }
}