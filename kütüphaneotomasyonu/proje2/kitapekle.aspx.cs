using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace proje2
{
    public partial class kitapekle : System.Web.UI.Page
    {
       
        //SqlConnection baglanti = new SqlConnection("Data Source = RAYBEK; Initial Catalog=LBRY1; User Id=sa; Password=raybek;");
          SqlConnection baglanti = new SqlConnection("Data Source = CEMRE; Initial Catalog=LBRY1; User Id=sa; Password=123;");
  
        protected void Button1_Click(object sender, EventArgs e)
            {
                baglanti.Open();

                SqlCommand ekle = new SqlCommand("insert into kitap(adi,dil,basim_yili,tür,yayinevi_no) values (@adi,@dil,@basim_yili,@tür,@yayinevi_no)", baglanti);
                ekle.Parameters.AddWithValue("@adi", TextBox1.Text);
                ekle.Parameters.AddWithValue("@dil", TextBox2.Text);
                ekle.Parameters.AddWithValue("@basim_yili", TextBox3.Text);
                ekle.Parameters.AddWithValue("@tür", TextBox4.Text);
                ekle.Parameters.AddWithValue("@yayinevi_no", TextBox5.Text);
                Label1.Visible = true;
                Label1.Text = "KİTAP EKLENDİ";
                
                ekle.ExecuteNonQuery();
                baglanti.Close();

            }

            protected void Button2_Click(object sender, EventArgs e)
            {
                baglanti.Open();
                string sorgu = "UPDATE kitap SET adi=@adi,dil=@dil,basim_yili=@basim_yili,tür=@tür,yayinevi_no=@yayinevi_no WHERE kitap_no=@kitap_no";
                SqlCommand guncelleme = new SqlCommand(sorgu, baglanti);

                guncelleme.Parameters.AddWithValue("@kitap_no", TextBox16.Text);
                guncelleme.Parameters.AddWithValue("@adi", TextBox6.Text);
                guncelleme.Parameters.AddWithValue("@dil", TextBox7.Text);
                guncelleme.Parameters.AddWithValue("@basim_yili", TextBox8.Text);
                guncelleme.Parameters.AddWithValue("@tür", TextBox9.Text);
                guncelleme.Parameters.AddWithValue("@yayinevi_no", TextBox10.Text);

                Label2.Visible = true;
                Label2.Text = "Bilgiler GÜNCELLENDİ";
                guncelleme.ExecuteNonQuery();
                baglanti.Close();


            }

            protected void Button3_Click(object sender, EventArgs e)
            {

                SqlCommand cmd = new SqlCommand("DELETE FROM kitap WHERE kitap_no =@kitapno AND adi = @kitapadi", baglanti);
                baglanti.Open();
                cmd.Parameters.AddWithValue("@kitapno", TextBox11.Text);
                cmd.Parameters.AddWithValue("@kitapadi", TextBox12.Text);

                cmd.ExecuteNonQuery();
                Label3.Visible = true;
                Label3.Text = "KİTAP SİLİNDİ";


                baglanti.Close();

            }


        }
    }
