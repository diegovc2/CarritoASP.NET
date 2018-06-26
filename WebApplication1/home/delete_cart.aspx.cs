using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.home
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\diego\source\repos\WebApplication1\WebApplication1\App_Data\shopping.mdf;Integrated Security=True");
        int carroid;
        string s, t;
        string[] fila =new string[6];
        string product_name, product_desc, product_price, product_qty, product_img;
        private int count;
        int product_id, qty;
        protected void Page_Load(object sender, EventArgs e)
        {
            carroid = Convert.ToInt32(Request.QueryString["id"].ToString());
            DataTable dt = new DataTable();
            dt.Rows.Clear();
            dt.Columns.AddRange(new DataColumn[7] { new DataColumn("product_name"), new DataColumn("product_desc"), new DataColumn("product_price"), new DataColumn("product_qty"), new DataColumn("product_img"), new DataColumn("id"), new DataColumn("product_id") });


            if (Request.Cookies["carrito"] != null)
            {
                s = Convert.ToString(Request.Cookies["carrito"].Value);

                string[] strArr = s.Split('|');
                for (int i = 0; i < strArr.Length; i++)
                {
                    t = Convert.ToString(strArr[i].ToString());
                    string[] strArr1 = t.Split(',');
                    for (int j = 0; j < strArr1.Length; j++)
                    {
                        fila[j] = strArr1[j].ToString();

                    }

                    dt.Rows.Add(fila[0].ToString(), fila[1].ToString(), fila[2].ToString(), fila[3].ToString(), fila[4].ToString(), i.ToString(), fila[5].ToString());

                }

            }

            count = 0;
            foreach(DataRow dr in dt.Rows)
            {
                if(count==carroid)
                {
                    product_id = Convert.ToInt32(dr["product_id"].ToString());
                    qty = Convert.ToInt32(dr["product_qty"].ToString());
                }
                count = count + 1;
            }

            count = 0;
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update products set qty=qty+ " + qty + " where id=" + product_id;
            cmd.ExecuteNonQuery();
            con.Close();


            dt.Rows.RemoveAt(carroid);

            Response.Cookies["carrito"].Value = "";


            foreach (DataRow dr in dt.Rows)
            {
                product_name = dr["product_name"].ToString();
                product_desc = dr["product_desc"].ToString();
                product_price = dr["product_price"].ToString();
                product_qty = dr["product_qty"].ToString();
                product_img = dr["product_img"].ToString();
                product_id = Convert.ToInt32(dr["product_id"].ToString());


                if (count >= 1)
                {
                    Response.Cookies["carrito"].Value = Response.Cookies["carrito"].Value + "|" + product_name + "," + product_desc + "," + product_price + "," + product_qty + "," + product_img + "," + product_id;

                }
                else
                {
                    Response.Cookies["carrito"].Value = product_name + "," + product_desc + "," + product_price + "," + product_qty + "," + product_img + "," + product_id;
                }
                count++;

            }
            Response.Cookies["carrito"].Expires = DateTime.Now.AddDays(1);
            Response.Redirect("./ver_carrito.aspx");
        }
    }
}