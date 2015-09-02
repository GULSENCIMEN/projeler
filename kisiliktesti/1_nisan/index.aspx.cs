using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Text.RegularExpressions;
using System.Text;

namespace _1_nisan
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source =YAGMUR; Initial Catalog=yazilim; User Id=sa; Password=123;");
            //SqlConnection baglanti = new SqlConnection("Data Source = GLSN; Initial Catalog=yazilim; User Id=sa; Password=nesluG-1339;");

            baglanti.Open();

            SqlCommand ekle = new SqlCommand("insert into kisiler(ad,soyad) values (@ad,@soyad)", baglanti);
            ekle.Parameters.AddWithValue("@ad", TextBox1.Text);
            ekle.Parameters.AddWithValue("@soyad", TextBox2.Text);

            ekle.ExecuteNonQuery();
           
            
            SqlCommand sorgu = new SqlCommand("select ad,soyad from kisiler Where ad='" + TextBox1.Text + "' and soyad='" + TextBox2.Text + "'", baglanti);
            SqlDataReader oku = sorgu.ExecuteReader();
            if (oku.Read())
            {// Session["ad"] = oku["ad"].ToString();
                Session["ad"] = TextBox1.Text;
                Session["soyad"] = TextBox2.Text;
                Response.Redirect("test1.aspx");
            }
            else
            {
                Response.Redirect("index.aspx");
            }
            baglanti.Close();
        }
    }
}