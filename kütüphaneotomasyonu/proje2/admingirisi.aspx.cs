using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace proje2
{
    public partial class admingirisi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }



        protected void Button1_Click(object sender, EventArgs e)
        {

        //SqlConnection baglanti = new SqlConnection( "Data Source = RAYBEK; Initial Catalog=LBRY1; User Id=sa; Password=raybek;");
        //SqlConnection baglanti = new SqlConnection("Data Source =YAGMUR; Initial Catalog=LBRY1; User Id=sa; Password=123;");
         SqlConnection baglanti = new SqlConnection("Data Source =CEMRE; Initial Catalog=LBRY1; User Id=sa; Password=123;");

            baglanti.Open();

            SqlCommand sorgu = new SqlCommand("select * from admin Where kullanici_adi='" + TextBox1.Text + "' and kullanici_sifre='" + TextBox2.Text + "'", baglanti);

            SqlDataReader oku = sorgu.ExecuteReader();
            if (oku.Read())
            {
                Session["kullanici_adi"] = oku["kullanici_adi"].ToString();
                Response.Redirect("admin.aspx");
            }
            else
            {
                Response.Redirect("index.aspx");
            }

        }

        
    }
}