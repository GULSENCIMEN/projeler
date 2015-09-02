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
    public partial class bilgigüncelle : System.Web.UI.Page
    {
       // SqlConnection baglanti = new SqlConnection( "Data Source = RAYBEK; Initial Catalog=LBRY1; User Id=sa; Password=raybek;");
       SqlConnection baglanti = new SqlConnection("Data Source = CEMRE; Initial Catalog=LBRY1; User Id=sa; Password=123;");

        protected void Page_Load(object sender, EventArgs e)
        {

            Label1.Visible = false;
            TextBox10.Text =Convert.ToString( Session["tc"]);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            StringBuilder komut = new StringBuilder();
            komut.Append("UPDATE üye SET tc=@tc,üye_adi=@adi,üye_soyadi=@soyadi,e_mail=@email,üye_telefon=@telefon,    ");
            komut.Append("üye_adres=@adres,üye_meslek=@meslek,üye_dogum_trh=@dogumtarihi,üye_dogum_yeri=@dogumyeri,üye_sifre=@sifre    ");
            komut.Append("WHERE tc=@tc");

            SqlCommand guncelleme = new SqlCommand(komut.ToString(), baglanti);

            guncelleme.Parameters.AddWithValue("@tc", Session["tc"]);
            guncelleme.Parameters.AddWithValue("@adi", TextBox1.Text);
            guncelleme.Parameters.AddWithValue("@soyadi", TextBox2.Text);
            guncelleme.Parameters.AddWithValue("@email", TextBox3.Text);
            guncelleme.Parameters.AddWithValue("@telefon", TextBox4.Text);
            guncelleme.Parameters.AddWithValue("@adres", TextBox5.Text);
            guncelleme.Parameters.AddWithValue("@meslek", TextBox6.Text);
            guncelleme.Parameters.AddWithValue("@dogumtarihi", TextBox7.Text);
            guncelleme.Parameters.AddWithValue("@dogumyeri", TextBox8.Text);
            guncelleme.Parameters.AddWithValue("@sifre", TextBox9.Text);

            guncelleme.ExecuteNonQuery();
            Label1.Visible = true;
            baglanti.Close();

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm1.aspx");
        }
    }
}