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
using System.Collections;


namespace _1_nisan
{
    public partial class ptesti : System.Web.UI.Page
    {

        int sayac1 = 0;
        int sayac2 = 0;
        int sayac3 = 0;
        int sayac4 = 0;
        int sayac5 = 0;
        int sayac6 = 0;
        int sayac7 = 0;
        int sayac8 = 0;
        protected void Page_Load(object sender, EventArgs e)
        {


        }

        protected void Button1_Click(object sender, EventArgs e)
        {


            Response.Redirect("sonuc_goruntule.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {


        }

        protected void Button2_Click1(object sender, EventArgs e)
        {


            string selectedValue1 = RadioButtonList1.SelectedValue;
            if (selectedValue1 == "1") sayac1++;
            if (selectedValue1 == "2") sayac3++;
            if (selectedValue1 == "3") sayac4++;
            if (selectedValue1 == "4") sayac2++;

            string selectedValue2 = RadioButtonList2.SelectedValue;
            if (selectedValue2 == "1") sayac2++;
            if (selectedValue2 == "2") sayac4++;
            if (selectedValue2 == "3") sayac1++;
            if (selectedValue2 == "4") sayac3++;

            string selectedValue3 = RadioButtonList3.SelectedValue;
            if (selectedValue3 == "1") sayac3++;
            if (selectedValue3 == "2") sayac2++;
            if (selectedValue3 == "3") sayac4++;
            if (selectedValue3 == "4") sayac1++;

            string selectedValue4 = RadioButtonList4.SelectedValue;
            if (selectedValue4 == "1") sayac2++;
            if (selectedValue4 == "2") sayac3++;
            if (selectedValue4 == "3") sayac1++;
            if (selectedValue4 == "4") sayac4++;

            string selectedValue5 = RadioButtonList5.SelectedValue;
            if (selectedValue5 == "1") sayac4++;
            if (selectedValue5 == "2") sayac2++;
            if (selectedValue5 == "3") sayac3++;
            if (selectedValue5 == "4") sayac1++;

            string selectedValue6 = RadioButtonList6.SelectedValue;
            if (selectedValue6 == " 1") sayac3++;
            if (selectedValue6 == "2") sayac2++;
            if (selectedValue6 == "3") sayac1++;
            if (selectedValue6 == "4") sayac4++;

            string selectedValue7 = RadioButtonList7.SelectedValue;
            if (selectedValue7 == "1") sayac2++;
            if (selectedValue7 == "2") sayac3++;
            if (selectedValue7 == "3") sayac1++;
            if (selectedValue7 == "4") sayac4++;

            string selectedValue8 = RadioButtonList8.SelectedValue;
            if (selectedValue8 == "1") sayac1++;
            if (selectedValue8 == "2") sayac4++;
            if (selectedValue8 == "3") sayac2++;
            if (selectedValue8 == "4") sayac3++;

            string selectedValue9 = RadioButtonList9.SelectedValue;
            if (selectedValue9 == "1") sayac2++;
            if (selectedValue9 == "2") sayac3++;
            if (selectedValue9 == "3") sayac1++;
            if (selectedValue9 == "4") sayac4++;

            string selectedValue10 = RadioButtonList10.SelectedValue;
            if (selectedValue10 == "1") sayac3++;
            if (selectedValue10 == "2") sayac2++;
            if (selectedValue10 == "3") sayac4++;
            if (selectedValue10 == "4") sayac1++;

            string selectedValue11 = RadioButtonList11.SelectedValue;
            if (selectedValue11 == " 1") sayac1++;
            if (selectedValue11 == "2") sayac4++;
            if (selectedValue11 == "3") sayac3++;
            if (selectedValue11 == "4") sayac2++;

            string selectedValue12 = RadioButtonList12.SelectedValue;
            if (selectedValue12 == "1") sayac4++;
            if (selectedValue12 == "2") sayac3++;
            if (selectedValue12 == "3") sayac2++;
            if (selectedValue12 == "4") sayac1++;

            string selectedValue13 = RadioButtonList13.SelectedValue;
            if (selectedValue13 == "1") sayac2++;
            if (selectedValue13 == "2") sayac1++;
            if (selectedValue13 == "3") sayac3++;
            if (selectedValue13 == "4") sayac4++;

            string selectedValue14 = RadioButtonList14.SelectedValue;
            if (selectedValue14 == "1") sayac4++;
            if (selectedValue14 == "2") sayac1++;
            if (selectedValue14 == "3") sayac3++;
            if (selectedValue14 == "4") sayac2++;

            string selectedValue15 = RadioButtonList15.SelectedValue;
            if (selectedValue15 == "1") sayac3++;
            if (selectedValue15 == "2") sayac2++;
            if (selectedValue15 == "3") sayac1++;
            if (selectedValue15 == "4") sayac4++;

            string selectedValue16 = RadioButtonList16.SelectedValue;
            if (selectedValue16 == "1") sayac2++;
            if (selectedValue16 == "2") sayac1++;
            if (selectedValue16 == "3") sayac4++;
            if (selectedValue16 == "4") sayac3++;

            string selectedValue17 = RadioButtonList17.SelectedValue;
            if (selectedValue17 == "1") sayac3++;
            if (selectedValue17 == "2") sayac2++;
            if (selectedValue17 == "3") sayac1++;
            if (selectedValue17 == "4") sayac4++;

            string selectedValue18 = RadioButtonList18.SelectedValue;
            if (selectedValue18 == "1") sayac3++;
            if (selectedValue18 == "2") sayac1++;
            if (selectedValue18 == "3") sayac2++;
            if (selectedValue18 == "4") sayac4++;

            string selectedValue19 = RadioButtonList19.SelectedValue;
            if (selectedValue19 == "1") sayac2++;
            if (selectedValue19 == "2") sayac3++;
            if (selectedValue19 == "3") sayac1++;
            if (selectedValue19 == "4") sayac4++;

            string selectedValue20 = RadioButtonList20.SelectedValue;
            if (selectedValue20 == "1") sayac4++;
            if (selectedValue20 == "2") sayac1++;
            if (selectedValue20 == "3") sayac2++;
            if (selectedValue20 == "4") sayac3++;

            string selectedValue21 = RadioButtonList21.SelectedValue;
            if (selectedValue21 == "1") sayac7++;
            if (selectedValue21 == "2") sayac6++;
            if (selectedValue21 == "3") sayac8++;
            if (selectedValue21 == "4") sayac5++;

            string selectedValue22 = RadioButtonList22.SelectedValue;
            if (selectedValue22 == "1") sayac8++;
            if (selectedValue22 == "2") sayac5++;
            if (selectedValue22 == "3") sayac7++;
            if (selectedValue22 == "4") sayac6++;

            string selectedValue23 = RadioButtonList23.SelectedValue;
            if (selectedValue23 == "1") sayac7++;
            if (selectedValue23 == "2") sayac6++;
            if (selectedValue23 == "3") sayac5++;
            if (selectedValue23 == "4") sayac8++;

            string selectedValue24 = RadioButtonList24.SelectedValue;
            if (selectedValue24 == "1") sayac6++;
            if (selectedValue24 == "2") sayac7++;
            if (selectedValue24 == "3") sayac8++;
            if (selectedValue24 == "4") sayac5++;

            string selectedValue25 = RadioButtonList25.SelectedValue;
            if (selectedValue25 == "1") sayac5++;
            if (selectedValue25 == "2") sayac6++;
            if (selectedValue25 == "3") sayac7++;
            if (selectedValue25 == "4") sayac8++;

            string selectedValue26 = RadioButtonList26.SelectedValue;
            if (selectedValue26 == "1") sayac6++;
            if (selectedValue26 == "2") { }
            if (selectedValue26 == "3") sayac8++;
            if (selectedValue26 == "4") sayac5++;

            string selectedValue27 = RadioButtonList27.SelectedValue;
            if (selectedValue27 == "1") sayac5++;
            if (selectedValue27 == "2") sayac8++;
            if (selectedValue27 == "3") sayac6++;
            if (selectedValue27 == "4") sayac7++;

            string selectedValue28 = RadioButtonList28.SelectedValue;
            if (selectedValue28 == "1") sayac7++;
            if (selectedValue28 == "2") sayac6++;
            if (selectedValue28 == "3") sayac5++;
            if (selectedValue28 == "4") sayac8++;

            string selectedValue29 = RadioButtonList29.SelectedValue;
            if (selectedValue29 == "1") sayac8++;
            if (selectedValue29 == "2") sayac7++;
            if (selectedValue29 == "3") sayac5++;
            if (selectedValue29 == "4") sayac6++;

            string selectedValue30 = RadioButtonList30.SelectedValue;
            if (selectedValue30 == "1") sayac8++;
            if (selectedValue30 == "2") sayac6++;
            if (selectedValue30 == "3") sayac5++;
            if (selectedValue30 == "4") sayac7++;

            string selectedValue31 = RadioButtonList31.SelectedValue;
            if (selectedValue31 == "1") sayac7++;
            if (selectedValue31 == "2") sayac6++;
            if (selectedValue31 == "3") sayac5++;
            if (selectedValue31 == "4") sayac8++;

            string selectedValue32 = RadioButtonList32.SelectedValue;
            if (selectedValue32 == "1") sayac6++;
            if (selectedValue32 == "2") sayac5++;
            if (selectedValue32 == "3") sayac7++;
            if (selectedValue32 == "4") sayac8++;

            string selectedValue33 = RadioButtonList33.SelectedValue;
            if (selectedValue33 == "1") sayac7++;
            if (selectedValue33 == "2") sayac8++;
            if (selectedValue33 == "3") sayac5++;
            if (selectedValue33 == "4") sayac6++;

            string selectedValue34 = RadioButtonList34.SelectedValue;
            if (selectedValue34 == "1") sayac8++;
            if (selectedValue34 == "2") sayac6++;
            if (selectedValue34 == "3") sayac5++;
            if (selectedValue34 == "4") sayac7++;

            string selectedValue35 = RadioButtonList35.SelectedValue;
            if (selectedValue35 == "1") sayac8++;
            if (selectedValue35 == "2") sayac5++;
            if (selectedValue35 == "3") sayac6++;
            if (selectedValue35 == "4") sayac7++;

            string selectedValue36 = RadioButtonList36.SelectedValue;
            if (selectedValue36 == "1") sayac7++;
            if (selectedValue36 == "2") sayac5++;
            if (selectedValue36 == "3") sayac8++;
            if (selectedValue36 == "4") sayac6++;

            string selectedValue37 = RadioButtonList37.SelectedValue;
            if (selectedValue37 == "1") sayac6++;
            if (selectedValue37 == "2") sayac5++;
            if (selectedValue37 == "3") sayac7++;
            if (selectedValue37 == "4") sayac8++;

            string selectedValue38 = RadioButtonList38.SelectedValue;
            if (selectedValue38 == "1") sayac7++;
            if (selectedValue38 == "2") sayac6++;
            if (selectedValue38 == "3") sayac5++;
            if (selectedValue38 == "4") sayac8++;

            string selectedValue39 = RadioButtonList39.SelectedValue;
            if (selectedValue39 == "1") sayac6++;
            if (selectedValue39 == "2") sayac8++;
            if (selectedValue39 == "3") sayac7++;
            if (selectedValue39 == "4") sayac5++;

            string selectedValue40 = RadioButtonList40.SelectedValue;
            if (selectedValue40 == "1") sayac7++;
            if (selectedValue40 == "2") sayac6++;
            if (selectedValue40 == "3") sayac5++;
            if (selectedValue40 == "4") sayac8++;


            TextBox2.Text = sayac1.ToString();
            TextBox10.Text = sayac2.ToString();
            TextBox6.Text = sayac3.ToString();
            TextBox14.Text = sayac4.ToString();
            TextBox18.Text = sayac5.ToString();
            TextBox26.Text = sayac6.ToString();
            TextBox22.Text = sayac7.ToString();
            TextBox30.Text = sayac8.ToString();
            SqlConnection baglanti = new SqlConnection("Data Source =YAGMUR; Initial Catalog=yazilim; User Id=sa; Password=123;");
            //SqlConnection baglanti = new SqlConnection("Data Source = GLSN; Initial Catalog=yazilim; User Id=sa; Password=nesluG-1339;");
            baglanti.Open();

            //  ekle.Parameters.AddWithValue("@ptesti", TextBox2.Text + TextBox10.Text + TextBox6.Text + TextBox14.Text + TextBox18.Text + TextBox26.Text + TextBox22.Text + TextBox30.Text);



            SqlCommand ekle = new SqlCommand("update kisiler set p_gk=@p_gk, p_mm=@p_mm,p_bs=@p_bs, p_po=@p_po,p1_gk=@p1_gk, p1_mm=@p1_mm,p1_bs=@p1_bs, p1_po=@p1_po where ad='" + Session["ad"] + "'", baglanti);
            ekle.Parameters.AddWithValue("@p_gk", TextBox2.Text);

            ekle.Parameters.AddWithValue("@p_mm", TextBox10.Text);

            ekle.Parameters.AddWithValue("@p_bs", TextBox6.Text);

            ekle.Parameters.AddWithValue("@p_po", TextBox14.Text);

            ekle.Parameters.AddWithValue("@p1_gk", TextBox18.Text);

            ekle.Parameters.AddWithValue("@p1_mm", TextBox26.Text);

            ekle.Parameters.AddWithValue("@p1_bs", TextBox22.Text);

            ekle.Parameters.AddWithValue("@p1_po", TextBox30.Text);
            ekle.ExecuteNonQuery();
            baglanti.Close();





            baglanti.Close();




        }
    }
}
