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
        int qty;
        string prod_id,prod_name, prod_desc, prod_price, product_qty,prod_img;
   

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

            qty = get_qty(id);
            if(qty==0)
            {
                l2.Visible = false;
                t1.Visible = false;
                b1.Visible = false;
                l1.Text = "No queda stock de este producto";
            }



        }

        protected void d1_ItemCommand(object source, RepeaterCommandEventArgs e)
        {

        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            if(con.State==ConnectionState.Open)
            {
                con.Close();
            }
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
                prod_id = dr["Id"].ToString();
            }

            if (Convert.ToInt32(t1.Text) > Convert.ToInt32(product_qty))
            {
                l1.Text="Elija una cantidad menor o igual que la disponible";
            }
            else
            {

                l1.Text = "";


                if (Request.Cookies["carrito"] == null)
                {
                    Response.Cookies["carrito"].Value = prod_name + "," + prod_desc + "," + prod_price + ","+t1.Text +"," + prod_img + "," + id.ToString();
                    Response.Cookies["carrito"].Expires = DateTime.Now.AddDays(1);

                }
                else
                {
                    Response.Cookies["carrito"].Value = Request.Cookies["carrito"].Value + "|" + prod_name.ToString() + "," + prod_desc.ToString() + "," + prod_price.ToString() + ","+t1.Text + "," + prod_img.ToString() + "," +id.ToString();
                    Response.Cookies["carrito"].Expires = DateTime.Now.AddDays(1);
                }


                SqlCommand cmd1 = con.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "update products set qty=qty-"+t1.Text+" where Id="+id.ToString();
                cmd1.ExecuteNonQuery();
                con.Close();
                Response.Redirect("prod_desc.aspx?id=" + id.ToString());

            }

            Response.Write(Response.Cookies["carrito"].Value);

        }


        public int get_qty(int qty)
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
                qty = Convert.ToInt32(dr["qty"].ToString());
            }

            return qty;
            }


    }
}