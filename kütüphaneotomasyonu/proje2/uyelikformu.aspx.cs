using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Text;

namespace proje2
{
    public partial class uyelikformu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label11.Visible = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source = YAGMUR; Initial Catalog=LBRY1; User Id=sa; Password=123;");
            baglanti.Open();
            // string sorgu = "INSERT INTO üye(tc,üye_adi,üye_soyadi,e_mail,üye_telefon,üye_adres,üye_meslek,üye_dogum_trh,üye_dogum_yeri,üye_sifre)   values  (@tc,@ad,@soyad,@mail,@tel,@adres,@meslek,@dtarihi,@dyeri,@sifre)";
            SqlCommand ekle = new SqlCommand("INSERT INTO üye(tc,üye_adi,üye_soyadi,e_mail,üye_telefon,üye_adres,üye_meslek,üye_dogum_trh,üye_dogum_yeri,üye_sifre)   values  (@tc,@üye_adi,@üye_soyadi,@e_mail,@üye_telefon,@üye_adres,@üye_meslek,@üye_dogum_trh,@üye_dogum_yeri,@üye_sifre)", baglanti);

            ekle.Parameters.AddWithValue("@tc", TextBox1.Text);
            ekle.Parameters.AddWithValue("@üye_adi", TextBox2.Text);
            ekle.Parameters.AddWithValue("@üye_soyadi", TextBox3.Text);
            ekle.Parameters.AddWithValue("@e_mail", TextBox4.Text);
            ekle.Parameters.AddWithValue("@üye_telefon", TextBox5.Text);
            ekle.Parameters.AddWithValue("@üye_adres", TextBox6.Text);
            ekle.Parameters.AddWithValue("@üye_meslek", TextBox7.Text);
            ekle.Parameters.AddWithValue("@üye_dogum_trh", TextBox8.Text);
            ekle.Parameters.AddWithValue("@üye_dogum_yeri", TextBox9.Text);
            ekle.Parameters.AddWithValue("@üye_sifre", TextBox10.Text);

            ekle.ExecuteNonQuery();

            Label11.Visible = true;
            Label11.Text = "KAYIT EKLENDİ";
            baglanti.Close();


        }
    }
}