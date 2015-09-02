using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace _1_nisan
{
    public partial class r_sonuc : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source =YAGMUR; Initial Catalog=yazilim; User Id=sa; Password=123;");
            // SqlConnection baglanti = new SqlConnection("Data Source =   GLSN; Initial Catalog=yazilim; User Id=sa; Password=nesluG-1339;");
            baglanti.Open();
            SqlDataAdapter adp = new SqlDataAdapter("SELECT * FROM kisiler where ad='" + Session["ad"] + "'", baglanti);
            DataTable table = new DataTable();
            adp.Fill(table);
            string[] array1 = new string[56];
            for (int i = 0; i < 56; i++)
            {
                array1[i] = table.Rows[0]["rtesti"].ToString();
                //TextBox1.Text=array1[i].ToString();
            }
            Label2.Text = array1[1].Substring(0, 1);
            Label3.Text = array1[2].Substring(1, 1);
            Label4.Text = array1[3].Substring(2, 1);
            Label5.Text = array1[4].Substring(3, 1);
            Label6.Text = array1[5].Substring(4, 1);
            Label7.Text = array1[6].Substring(5, 1);
            Label8.Text = array1[7].Substring(6, 1);
            Label9.Text = array1[8].Substring(7, 1);
            Label10.Text = array1[9].Substring(8, 1);
            Label11.Text = array1[10].Substring(9, 1);
            Label12.Text = array1[11].Substring(10, 1);
            Label13.Text = array1[12].Substring(11, 1);
            Label14.Text = array1[13].Substring(12, 1);
            Label15.Text = array1[14].Substring(13, 1);
            Label16.Text = array1[15].Substring(14, 1);
            Label17.Text = array1[16].Substring(15, 1);
            Label18.Text = array1[17].Substring(16, 1);
            Label19.Text = array1[18].Substring(17, 1);
            Label20.Text = array1[19].Substring(18, 1);
            Label21.Text = array1[20].Substring(19, 1);
            Label22.Text = array1[21].Substring(20, 1);
            Label23.Text = array1[22].Substring(21, 1);
            Label24.Text = array1[23].Substring(22, 1);
            Label25.Text = array1[24].Substring(23, 1);
            Label26.Text = array1[25].Substring(24, 1);
            Label27.Text = array1[26].Substring(25, 1);
            Label28.Text = array1[27].Substring(26, 1);
            Label29.Text = array1[28].Substring(27, 1);
            Label30.Text = array1[29].Substring(28, 1);
            Label31.Text = array1[30].Substring(29, 1);
            Label32.Text = array1[31].Substring(30, 1);
            Label33.Text = array1[32].Substring(31, 1);
            Label34.Text = array1[33].Substring(32, 1);
            Label36.Text = array1[34].Substring(33, 1);
            Label35.Text = array1[35].Substring(34, 1);
            Label37.Text = array1[36].Substring(35, 1);
            Label41.Text = array1[37].Substring(36, 1);
            Label40.Text = array1[38].Substring(37, 1);
            Label39.Text = array1[39].Substring(38, 1);
            Label38.Text = array1[40].Substring(39, 1);
            Label42.Text = array1[41].Substring(40, 1);
            Label43.Text = array1[42].Substring(41, 1);
            Label44.Text = array1[43].Substring(42, 1);
            Label45.Text = array1[44].Substring(43, 1);
            Label46.Text = array1[45].Substring(44, 1);
            Label47.Text = array1[46].Substring(45, 1);
            Label48.Text = array1[47].Substring(46, 1);
            Label49.Text = array1[48].Substring(47, 1);
            Label57.Text = array1[49].Substring(48, 1);
            Label56.Text = array1[50].Substring(49, 1);
            Label55.Text = array1[51].Substring(50, 1);
            Label54.Text = array1[52].Substring(51, 1);
            Label53.Text = array1[53].Substring(52, 1);
            Label52.Text = array1[54].Substring(53, 1);
            Label51.Text = array1[55].Substring(54, 1);
            Label50.Text = array1[0].Substring(55, 1);




            Label58.Text = Label8.Text;
            Label59.Text = Label5.Text;
            Label60.Text = Label7.Text;
            Label61.Text = Label4.Text;
            Label62.Text = Label2.Text;
            Label63.Text = Label9.Text;
            Label64.Text = Label3.Text;
            Label65.Text = Label6.Text;

            Label66.Text = Label10.Text;
            Label67.Text = Label11.Text;
            Label68.Text = Label14.Text;
            Label69.Text = Label16.Text;
            Label70.Text = Label12.Text;
            Label71.Text = Label13.Text;
            Label72.Text = Label15.Text;
            Label73.Text = Label17.Text;

            Label74.Text = Label25.Text;
            Label75.Text = Label18.Text;
            Label76.Text = Label20.Text;
            Label77.Text = Label21.Text;
            Label78.Text = Label23.Text;
            Label79.Text = Label24.Text;
            Label80.Text = Label22.Text;
            Label81.Text = Label19.Text;

            Label82.Text = Label29.Text;
            Label83.Text = Label33.Text;
            Label84.Text = Label27.Text;
            Label85.Text = Label30.Text;
            Label86.Text = Label32.Text;
            Label87.Text = Label28.Text;
            Label88.Text = Label26.Text;
            Label89.Text = Label31.Text;

            Label90.Text = Label35.Text;
            Label91.Text = Label39.Text;
            Label92.Text = Label37.Text;
            Label93.Text = Label41.Text;
            Label94.Text = Label38.Text;
            Label95.Text = Label34.Text;
            Label96.Text = Label36.Text;
            Label97.Text = Label40.Text;

            Label98.Text = Label47.Text;
            Label99.Text = Label44.Text;
            Label100.Text = Label48.Text;
            Label101.Text = Label42.Text;
            Label102.Text = Label49.Text;
            Label103.Text = Label46.Text;
            Label104.Text = Label43.Text;
            Label105.Text = Label45.Text;

            Label106.Text = Label54.Text;
            Label107.Text = Label56.Text;
            Label108.Text = Label50.Text;
            Label109.Text = Label55.Text;
            Label110.Text = Label53.Text;
            Label111.Text = Label51.Text;
            Label112.Text = Label57.Text;
            Label113.Text = Label52.Text;


            Label115.Text = Convert.ToString(Convert.ToInt32(Label58.Text) + Convert.ToInt32(Label66.Text) + Convert.ToInt32(Label74.Text) + Convert.ToInt32(Label82.Text) + Convert.ToInt32(Label90.Text) + Convert.ToInt32(Label98.Text) + Convert.ToInt32(Label106.Text));
            Label116.Text = Convert.ToString(Convert.ToInt32(Label59.Text) + Convert.ToInt32(Label67.Text) + Convert.ToInt32(Label75.Text) + Convert.ToInt32(Label83.Text) + Convert.ToInt32(Label91.Text) + Convert.ToInt32(Label99.Text) + Convert.ToInt32(Label107.Text));
            Label117.Text = Convert.ToString(Convert.ToInt32(Label60.Text) + Convert.ToInt32(Label68.Text) + Convert.ToInt32(Label76.Text) + Convert.ToInt32(Label84.Text) + Convert.ToInt32(Label92.Text) + Convert.ToInt32(Label100.Text) + Convert.ToInt32(Label108.Text));
            Label118.Text = Convert.ToString(Convert.ToInt32(Label61.Text) + Convert.ToInt32(Label69.Text) + Convert.ToInt32(Label77.Text) + Convert.ToInt32(Label85.Text) + Convert.ToInt32(Label93.Text) + Convert.ToInt32(Label101.Text) + Convert.ToInt32(Label109.Text));
            Label119.Text = Convert.ToString(Convert.ToInt32(Label62.Text) + Convert.ToInt32(Label70.Text) + Convert.ToInt32(Label78.Text) + Convert.ToInt32(Label86.Text) + Convert.ToInt32(Label94.Text) + Convert.ToInt32(Label102.Text) + Convert.ToInt32(Label110.Text));
            Label120.Text = Convert.ToString(Convert.ToInt32(Label63.Text) + Convert.ToInt32(Label71.Text) + Convert.ToInt32(Label79.Text) + Convert.ToInt32(Label87.Text) + Convert.ToInt32(Label95.Text) + Convert.ToInt32(Label103.Text) + Convert.ToInt32(Label111.Text));
            Label121.Text = Convert.ToString(Convert.ToInt32(Label64.Text) + Convert.ToInt32(Label72.Text) + Convert.ToInt32(Label80.Text) + Convert.ToInt32(Label88.Text) + Convert.ToInt32(Label96.Text) + Convert.ToInt32(Label104.Text) + Convert.ToInt32(Label112.Text));
            Label122.Text = Convert.ToString(Convert.ToInt32(Label65.Text) + Convert.ToInt32(Label73.Text) + Convert.ToInt32(Label81.Text) + Convert.ToInt32(Label89.Text) + Convert.ToInt32(Label97.Text) + Convert.ToInt32(Label105.Text) + Convert.ToInt32(Label113.Text));



            //SqlCommand ekle = new SqlCommand("update sonuc set sc=@sc where ad='" + Session["ad"] + "'", baglanti);
            //ekle.Parameters.AddWithValue("@sc", Label115.Text);
            //ekle.ExecuteNonQuery();
            //baglanti.Close();

            SqlCommand ekle = new SqlCommand("update kisiler set sc=@sc, bs=@bs,bc=@bc, yr=@yr,ka=@ka,dr=@dr,eu=@eu,ry=@ry where ad='" + Session["ad"] + "'", baglanti);
            ekle.Parameters.AddWithValue("@sc", Label115.Text);

            ekle.Parameters.AddWithValue("@bs", Label116.Text);

            ekle.Parameters.AddWithValue("@bc", Label117.Text);

            ekle.Parameters.AddWithValue("@yr", Label118.Text);

            ekle.Parameters.AddWithValue("@ka", Label119.Text);

            ekle.Parameters.AddWithValue("@dr", Label120.Text);

            ekle.Parameters.AddWithValue("@eu", Label121.Text);

            ekle.Parameters.AddWithValue("@ry", Label122.Text);
            ekle.ExecuteNonQuery();
            baglanti.Close();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("sonuc_goruntule.aspx");
        }

    }
}