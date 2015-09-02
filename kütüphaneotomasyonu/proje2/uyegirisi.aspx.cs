using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Text;
using System.Data;

namespace proje2
{
    public partial class uyegirisi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        
        protected void Button1_Click(object sender, EventArgs e)
        {
            //SqlConnection baglanti = new SqlConnection( "Data Source = RAYBEK; Initial Catalog=LBRY1; User Id=sa; Password=raybek;");
          //SqlConnection baglanti = new SqlConnection("Data Source = YAGMUR; Initial Catalog=LBRY1; User Id=sa; Password=123;");
            SqlConnection baglanti = new SqlConnection("Data Source = CEMRE; Initial Catalog=LBRY1; User Id=sa; Password=123;");
            baglanti.Open();
            SqlCommand sorgu = new SqlCommand("select üye_adi,tc from üye Where üye_adi='" + TextBox1.Text + "' and üye_sifre='" + TextBox2.Text + "'", baglanti);
           
            SqlDataReader oku = sorgu.ExecuteReader();
            if (oku.Read())
            {
                Session["üye_adi"] = oku["üye_adi"].ToString();
                Session["tc"]=oku["tc"].ToString();
                Response.Redirect("WebForm1.aspx");
            }
            else
            {
                Response.Redirect("index.aspx");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("index.aspx");
        }

      

        
    }
}