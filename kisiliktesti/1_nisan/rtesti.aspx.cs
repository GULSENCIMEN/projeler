using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace _1_nisan
{
    public partial class rtesti : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int[] dizi = new int[56];

            dizi[0] = Convert.ToInt32(DropDownList1.SelectedItem.Text);
            dizi[1] = Convert.ToInt32(DropDownList2.SelectedItem.Text);
            dizi[2] = Convert.ToInt32(DropDownList3.SelectedItem.Text);
            dizi[3] = Convert.ToInt32(DropDownList4.SelectedItem.Text);
            dizi[4] = Convert.ToInt32(DropDownList5.SelectedItem.Text);
            dizi[5] = Convert.ToInt32(DropDownList6.SelectedItem.Text);
            dizi[6] = Convert.ToInt32(DropDownList7.SelectedItem.Text);
            dizi[7] = Convert.ToInt32(DropDownList8.SelectedItem.Text);
            dizi[8] = Convert.ToInt32(DropDownList9.SelectedItem.Text);
            dizi[9] = Convert.ToInt32(DropDownList10.SelectedItem.Text);
            dizi[10] = Convert.ToInt32(DropDownList11.SelectedItem.Text);
            dizi[11] = Convert.ToInt32(DropDownList12.SelectedItem.Text);
            dizi[12] = Convert.ToInt32(DropDownList13.SelectedItem.Text);
            dizi[13] = Convert.ToInt32(DropDownList14.SelectedItem.Text);
            dizi[14] = Convert.ToInt32(DropDownList15.SelectedItem.Text);
            dizi[15] = Convert.ToInt32(DropDownList16.SelectedItem.Text);
            dizi[16] = Convert.ToInt32(DropDownList17.SelectedItem.Text);
            dizi[17] = Convert.ToInt32(DropDownList18.SelectedItem.Text);
            dizi[18] = Convert.ToInt32(DropDownList19.SelectedItem.Text);
            dizi[19] = Convert.ToInt32(DropDownList20.SelectedItem.Text);
            dizi[20] = Convert.ToInt32(DropDownList21.SelectedItem.Text);
            dizi[21] = Convert.ToInt32(DropDownList22.SelectedItem.Text);
            dizi[22] = Convert.ToInt32(DropDownList23.SelectedItem.Text);
            dizi[23] = Convert.ToInt32(DropDownList24.SelectedItem.Text);
            dizi[24] = Convert.ToInt32(DropDownList25.SelectedItem.Text);
            dizi[25] = Convert.ToInt32(DropDownList26.SelectedItem.Text);
            dizi[26] = Convert.ToInt32(DropDownList27.SelectedItem.Text);
            dizi[27] = Convert.ToInt32(DropDownList28.SelectedItem.Text);
            dizi[28] = Convert.ToInt32(DropDownList29.SelectedItem.Text);
            dizi[29] = Convert.ToInt32(DropDownList30.SelectedItem.Text);
            dizi[30] = Convert.ToInt32(DropDownList31.SelectedItem.Text);
            dizi[31] = Convert.ToInt32(DropDownList32.SelectedItem.Text);
            dizi[32] = Convert.ToInt32(DropDownList33.SelectedItem.Text);
            dizi[33] = Convert.ToInt32(DropDownList34.SelectedItem.Text);
            dizi[34] = Convert.ToInt32(DropDownList35.SelectedItem.Text);
            dizi[35] = Convert.ToInt32(DropDownList36.SelectedItem.Text);
            dizi[36] = Convert.ToInt32(DropDownList37.SelectedItem.Text);
            dizi[37] = Convert.ToInt32(DropDownList38.SelectedItem.Text);
            dizi[38] = Convert.ToInt32(DropDownList39.SelectedItem.Text);
            dizi[39] = Convert.ToInt32(DropDownList40.SelectedItem.Text);
            dizi[40] = Convert.ToInt32(DropDownList41.SelectedItem.Text);
            dizi[41] = Convert.ToInt32(DropDownList42.SelectedItem.Text);
            dizi[42] = Convert.ToInt32(DropDownList43.SelectedItem.Text);
            dizi[43] = Convert.ToInt32(DropDownList44.SelectedItem.Text);
            dizi[44] = Convert.ToInt32(DropDownList45.SelectedItem.Text);
            dizi[45] = Convert.ToInt32(DropDownList46.SelectedItem.Text);
            dizi[46] = Convert.ToInt32(DropDownList47.SelectedItem.Text);
            dizi[47] = Convert.ToInt32(DropDownList48.SelectedItem.Text);
            dizi[48] = Convert.ToInt32(DropDownList49.SelectedItem.Text);
            dizi[49] = Convert.ToInt32(DropDownList50.SelectedItem.Text);
            dizi[50] = Convert.ToInt32(DropDownList51.SelectedItem.Text);
            dizi[51] = Convert.ToInt32(DropDownList52.SelectedItem.Text);
            dizi[52] = Convert.ToInt32(DropDownList53.SelectedItem.Text);
            dizi[53] = Convert.ToInt32(DropDownList54.SelectedItem.Text);
            dizi[54] = Convert.ToInt32(DropDownList55.SelectedItem.Text);
            dizi[55] = Convert.ToInt32(DropDownList56.SelectedItem.Text);


            for (int i = 0; i < 56; i++)
            {
                TextBox1.Text += dizi[i];
            }

            SqlConnection baglanti = new SqlConnection("Data Source =YAGMUR; Initial Catalog=yazilim; User Id=sa; Password=123;");
            //SqlConnection baglanti = new SqlConnection("Data Source = GLSN; Initial Catalog=yazilim; User Id=sa; Password=nesluG-1339;");
            baglanti.Open();


            SqlCommand ekle = new SqlCommand("update kisiler set rtesti=@rtesti where ad='" + Session["ad"] + "'", baglanti);
            //SqlCommand cmd = new SqlCommand(ekle, baglanti);
            //ekle.Parameters.AddWithValue("@ad", Session["ad"]);
            ekle.Parameters.AddWithValue("@rtesti", TextBox1.Text);
            ekle.ExecuteNonQuery();
            baglanti.Close();

            Response.Redirect("ptesti.aspx");
        }
    }
}