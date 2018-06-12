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
    public partial class registrar : System.Web.UI.Page
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
            cmd.CommandText = "select * from admin_login where username='" + tusuario.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            i = Convert.ToInt32(dt.Rows.Count.ToString());
            Response.Write(i);

            if (i == 1)
            {
                l1.Text = "USUARIO YA EXISTENTE, DEBE CAMBIAR EL USUARIO";
            }
            else
            {
                SqlCommand cmd2 = con.CreateCommand();
                cmd2.CommandText = "Insert INTO admin_login (username, password, nombre, rut, email, telefono, direccion, codigopostal) Values (@val1, @val2, @val3, @val4, @val5, @val6, @val7, @val8)";
                cmd2.Parameters.AddWithValue("@val1", tusuario.Text);
                cmd2.Parameters.AddWithValue("@val2", tpass.Text);
                cmd2.Parameters.AddWithValue("@val3", tnombre.Text);
                cmd2.Parameters.AddWithValue("@val4", trut.Text);
            
                cmd2.Parameters.AddWithValue("@val5", temail.Text);
                cmd2.Parameters.AddWithValue("@val6", ttelefono.Text);
                cmd2.Parameters.AddWithValue("@val7", tdirección.Text);
                cmd2.Parameters.AddWithValue("@val8", tcodigo.Text);
                cmd2.ExecuteNonQuery();
                DataTable dt2 = new DataTable();
                SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
                da.Fill(dt2);
                i = Convert.ToInt32(dt2.Rows.Count.ToString());
                Response.Redirect("./completo.aspx");
            }
            con.Close();
        }
        
    }
}