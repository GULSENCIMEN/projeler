using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Web.UI.DataVisualization.Charting;

namespace _1_nisan
{
    public partial class rsonucgoruntule : System.Web.UI.Page
    {
        int gk=0;
        int po=0;
        int bs=0;
        int mm=0;
        protected void Page_Load(object sender, EventArgs e)
        {
                SqlConnection baglanti = new SqlConnection("Data Source =YAGMUR; Initial Catalog=yazilim; User Id=sa; Password=123;");
                baglanti.Open();

                

                SqlCommand ekle = new SqlCommand("select *from kisiler where ad='" + Session["ad"] + "'", baglanti);
                SqlDataReader oku = ekle.ExecuteReader();
                if (oku.Read())
                {
                    Label1.Text = oku["sc"].ToString();
                    Label2.Text = oku["bs"].ToString();
                    Label3.Text = oku["bc"].ToString();
                    Label4.Text = oku["yr"].ToString();
                    Label5.Text = oku["ka"].ToString();
                    Label6.Text = oku["dr"].ToString();
                    Label7.Text = oku["eu"].ToString();
                    Label8.Text = oku["ry"].ToString();
                    Label10.Text = oku["pratiklik"].ToString();
                    Label9.Text = oku["sorumluluk"].ToString();
                    Label11.Text = oku["atilganlik"].ToString();
                    Label12.Text = oku["risk"].ToString();
                    Label13.Text = oku["etkinlik"].ToString();
                    Label14.Text = oku["sosyal"].ToString();
                    Label15.Text = oku["tepkicilik"].ToString();
                    Label16.Text = oku["uzlasmazlik"].ToString();
                    Label17.Text = oku["ustunluk"].ToString();
                    Label18.Text = oku["kaygili"].ToString();
                    Label19.Text = oku["basari"].ToString();
                    Label20.Text = oku["bagimlilik"].ToString();
                    Label21.Text = oku["uzuntulu"].ToString();
                    Label22.Text = oku["takintili"].ToString();

                    TextBox1.Text = oku["p_gk"].ToString();
                    TextBox2.Text = oku["p_mm"].ToString();
                    TextBox3.Text = oku["p_bs"].ToString();
                    TextBox4.Text = oku["p_po"].ToString();
                    TextBox5.Text = oku["p1_gk"].ToString();
                    TextBox6.Text = oku["p1_mm"].ToString();
                    TextBox7.Text = oku["p1_bs"].ToString();
                    TextBox8.Text = oku["p1_po"].ToString();

                }


                baglanti.Close();
            }

        protected void Chart1_Load(object sender, EventArgs e)
        {

            gk = Convert.ToInt32(Convert.ToInt32(Label2.Text) + Convert.ToInt32(Label3.Text) + Convert.ToInt32(Label5.Text) + Convert.ToInt32(TextBox1.Text) + Convert.ToInt32(TextBox5.Text));
            mm = Convert.ToInt32(Convert.ToInt32(Label1.Text) + Convert.ToInt32(Label4.Text) + Convert.ToInt32(Label6.Text) + Convert.ToInt32(Label8.Text) + Convert.ToInt32(TextBox2.Text) + Convert.ToInt32(TextBox6.Text));
            po = Convert.ToInt32(Convert.ToInt32(Label2.Text) + Convert.ToInt32(Label5.Text) + Convert.ToInt32(Label7.Text) + Convert.ToInt32(TextBox4.Text) + Convert.ToInt32(TextBox8.Text));
            bs = Convert.ToInt32(Convert.ToInt32(Label6.Text) + Convert.ToInt32(TextBox3.Text) + Convert.ToInt32(TextBox7.Text));
            // Bölüm adlarını ve kontenjan bilgilerini diziye yazdık.
           
            string[] seriesBolumler = { "GK", "MM", "BS", "PO" };
            int[] seriesKontenjan = { gk, mm,bs,po};

            // Chart1 kontrolüne başlık atadık.
            this.Chart1.Titles.Add("KİŞİLİK PROFİLİ");

            //Series nesnesi oluşturarak bölüm adlarını ve kontenjan bilgilerini ekledik.
            for (int i = 0; i < seriesBolumler.Length; i++)
            {
                Series series = this.Chart1.Series.Add(seriesBolumler[i]);
                series.Points.Add(seriesKontenjan[i]);

            }
        }

        }
    }
