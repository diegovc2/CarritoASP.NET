using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.html.simpleparser;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.home
{
    public partial class pagocompleto : System.Web.UI.Page
    {
        string s;
        string t;
        string[] fila = new string[6];

        int tot = 0;
        protected void Page_Load(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[7] { new DataColumn("product_name"), new DataColumn("product_desc"), new DataColumn("product_price"), new DataColumn("product_qty"), new DataColumn("product_img"), new DataColumn("id"), new DataColumn("product_id") });

            if (Request.Cookies["carrito"].Value != "")
            {
                s = Convert.ToString(Request.Cookies["carrito"].Value);

                string[] strArr = s.Split('|');
                for (int i = 0; i < strArr.Length; i++)
                {
                    if (strArr[i] != "")
                    {
                        t = Convert.ToString(strArr[i].ToString());
                        string[] strArr1 = t.Split(',');
                        for (int j = 0; j < strArr1.Length; j++)
                        {
                            fila[j] = strArr1[j].ToString();

                        }


                        dt.Rows.Add(fila[0].ToString(), fila[1].ToString(), fila[2].ToString(), fila[3].ToString(), fila[4].ToString(), i.ToString(), fila[5].ToString());

                        tot = tot + (Convert.ToInt32(fila[2].ToString()) * Convert.ToInt32(fila[3].ToString()));
                    }
                }

                d2.DataSource = dt;
                d2.DataBind();
            

                l1.Text = "$" + tot.ToString();
                l2.Text = Request.QueryString["tipo"].ToString();
              //  Request.Cookies["carrito"].Value = "";
               // Response.Cookies["carrito"].Expires = DateTime.Now.AddDays(-1);

            }
            else Response.Redirect("./prod_desc.aspx");

        }

        protected void btnPrint_Click(object sender, EventArgs e)
        {
            Response.ContentType = "application/pdf";
            Response.AddHeader("content-disposition", "attachment;filename-print.pdf");
            Response.Cache.SetCacheability(HttpCacheability.NoCache);

            StringWriter sw = new StringWriter();
            HtmlTextWriter hw = new HtmlTextWriter(sw);

            panelPDF.RenderControl(hw);
            StringReader sr = new StringReader(sw.ToString());
            Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 100f, 10f);
            HTMLWorker htmlParser = new HTMLWorker(pdfDoc);
            PdfWriter.GetInstance(pdfDoc, Response.OutputStream);

            pdfDoc.Open();
            htmlParser.Parse(sr);
            pdfDoc.Close();

            Response.Write(pdfDoc);
            Response.End();

        }

        public override void VerifyRenderingInServerForm(Control control)
        {
            return;
        }
    }

}
    
