using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace _1_nisan
{
    public partial class p_sonuc : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


            SqlConnection baglanti = new SqlConnection("Data Source =YAGMUR; Initial Catalog=yazilim; User Id=sa; Password=123;");
            baglanti.Open();
            SqlCommand ekle = new SqlCommand("select *from kisiler where ad='" + Session["ad"] + "'", baglanti);
            SqlDataReader oku = ekle.ExecuteReader();
            if (oku.Read())
            {
                Label1.Text = oku["p_gk"].ToString();
                Label4.Text = oku["p_mm"].ToString();
                Label7.Text = oku["p_bs"].ToString();
                Label10.Text = oku["p_po"].ToString();
                Label2.Text = oku["p1_gk"].ToString();
                Label5.Text = oku["p1_mm"].ToString();
                Label8.Text = oku["p1_bs"].ToString();
                Label11.Text = oku["p1_po"].ToString();
            }

          Label3.Text = Convert.ToString(Convert.ToInt32(Label1.Text) +  Convert.ToInt32(Label2.Text)) ;
          Label6.Text = Convert.ToString(Convert.ToInt32(Label4.Text) + Convert.ToInt32(Label5.Text));
          Label9.Text = Convert.ToString(Convert.ToInt32(Label7.Text) + Convert.ToInt32(Label8.Text));
          Label12.Text = Convert.ToString(Convert.ToInt32(Label10.Text) + Convert.ToInt32(Label11.Text));
            baglanti.Close();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("sonuc_goruntule.aspx");
        }

    }
}