using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace proje2
{
    public partial class adminekle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label3.Visible = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source = CEMRE; Initial Catalog=LBRY1; User Id=sa; Password=123;");
            SqlCommand sorgu = new SqlCommand();


            baglanti.Open();
            sorgu.Connection = baglanti;
            sorgu.CommandType = CommandType.StoredProcedure;

            sorgu.CommandText = "AdminEkle";


            sorgu.Parameters.AddWithValue("@kullanici_adi", TextBox1.Text);
            sorgu.Parameters.AddWithValue("@kullanici_sifre", TextBox2.Text);
            sorgu.ExecuteNonQuery();
            Label3.Visible = true;
            baglanti.Close();
        }
    }
}