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
    public partial class WebForm2 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\diego\source\repos\WebApplication1\WebApplication1\App_Data\shopping.mdf;Integrated Security=True");
        int id;
        string prod_name, prod_desc, prod_price, product_qty,prod_img;
   

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["id"] == null)
            {
                id = 2;
            }
            else
            {
                id = Convert.ToInt32(Request.QueryString["id"].ToString());
            }
                con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from products where id="+id.ToString();
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            d1.DataSource = dt;
            d1.DataBind();
            con.Close();
        }

        protected void d1_ItemCommand(object source, RepeaterCommandEventArgs e)
        {

        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from products where id=" + id.ToString();
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                prod_name = dr["title"].ToString();
                prod_desc = dr["desc"].ToString();
                prod_price = dr["price"].ToString();
                product_qty = dr["qty"].ToString();
                prod_img = dr["img"].ToString();

            }

            if(Request.Cookies["carrito"]==null)
            {
                Response.Cookies["carrito"].Value = prod_name + "," + prod_desc + "," + prod_price + "," + product_qty + "," + prod_img + "|";
                Response.Cookies["carrito"].Expires = DateTime.Now.AddDays(1);

            }
            else
            {
                Response.Cookies["carrito"].Value=Request.Cookies["carrito"].Value + prod_name + "," + prod_desc + "," + prod_price + "," + product_qty + "," + prod_img + "|";
                Response.Cookies["carrito"].Expires = DateTime.Now.AddDays(1);
            }

            Response.Write(Response.Cookies["carrito"].Value);

        }
    }
}