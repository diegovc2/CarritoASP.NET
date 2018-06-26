using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.home
{
    public partial class payment_gateway2 : System.Web.UI.Page
    {
        int tot = 0;
        string s;
        string t;
        string[] a = new string[6];
        string order_no;

        protected void Page_Load(object sender, EventArgs e)
        {
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
                        a[j] = strArr1[j].ToString();
                    }
                    tot = tot + (Convert.ToInt32(a[2].ToString()) * Convert.ToInt32(a[3].ToString()));
                }

                Session["tot"] = tot.ToString();


            }

            l1.Text = tot.ToString();
        }

        protected void b1_Click(object sender, EventArgs e)
        {
            Response.Redirect("pagocompleto.aspx?tipo="+tipo.Text);
        }
    }
}