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
    public partial class test1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            TextBox1.Visible = false;

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            {
                ArrayList list = new ArrayList();

                list.Add(Convert.ToInt32(CheckBox1.Checked));
                list.Add(Convert.ToInt32(CheckBox2.Checked));
                list.Add(Convert.ToInt32(CheckBox3.Checked == false));
                list.Add(Convert.ToInt32(CheckBox4.Checked));
                list.Add(Convert.ToInt32(CheckBox5.Checked));
                list.Add(Convert.ToInt32(CheckBox6.Checked));
                list.Add(Convert.ToInt32(CheckBox7.Checked));
                list.Add(Convert.ToInt32(CheckBox8.Checked));
                list.Add(Convert.ToInt32(CheckBox9.Checked));
                list.Add(Convert.ToInt32(CheckBox10.Checked));
                list.Add(Convert.ToInt32(CheckBox11.Checked == false));
                list.Add(Convert.ToInt32(CheckBox12.Checked));
                list.Add(Convert.ToInt32(CheckBox13.Checked));
                list.Add(Convert.ToInt32(CheckBox14.Checked));
                list.Add(Convert.ToInt32(CheckBox15.Checked));
                list.Add(Convert.ToInt32(CheckBox16.Checked));
                list.Add(Convert.ToInt32(CheckBox17.Checked == false));
                list.Add(Convert.ToInt32(CheckBox18.Checked));
                list.Add(Convert.ToInt32(CheckBox19.Checked));
                list.Add(Convert.ToInt32(CheckBox20.Checked));
                list.Add(Convert.ToInt32(CheckBox21.Checked));
                list.Add(Convert.ToInt32(CheckBox22.Checked));
                list.Add(Convert.ToInt32(CheckBox23.Checked == false));
                list.Add(Convert.ToInt32(CheckBox24.Checked == false));
                list.Add(Convert.ToInt32(CheckBox25.Checked == false));
                list.Add(Convert.ToInt32(CheckBox26.Checked == false));
                list.Add(Convert.ToInt32(CheckBox27.Checked == false));
                list.Add(Convert.ToInt32(CheckBox28.Checked));
                list.Add(Convert.ToInt32(CheckBox29.Checked == false));
                list.Add(Convert.ToInt32(CheckBox30.Checked == false));
                list.Add(Convert.ToInt32(CheckBox31.Checked));
                list.Add(Convert.ToInt32(CheckBox32.Checked));
                list.Add(Convert.ToInt32(CheckBox33.Checked == false));
                list.Add(Convert.ToInt32(CheckBox34.Checked));
                list.Add(Convert.ToInt32(CheckBox35.Checked == false));
                list.Add(Convert.ToInt32(CheckBox36.Checked == false));
                list.Add(Convert.ToInt32(CheckBox37.Checked));
                list.Add(Convert.ToInt32(CheckBox38.Checked));
                list.Add(Convert.ToInt32(CheckBox39.Checked));
                list.Add(Convert.ToInt32(CheckBox40.Checked == false));
                list.Add(Convert.ToInt32(CheckBox41.Checked == false));
                list.Add(Convert.ToInt32(CheckBox42.Checked));
                list.Add(Convert.ToInt32(CheckBox43.Checked == false));
                list.Add(Convert.ToInt32(CheckBox44.Checked));
                list.Add(Convert.ToInt32(CheckBox45.Checked == false));
                list.Add(Convert.ToInt32(CheckBox46.Checked));
                list.Add(Convert.ToInt32(CheckBox47.Checked == false));
                list.Add(Convert.ToInt32(CheckBox48.Checked));
                list.Add(Convert.ToInt32(CheckBox49.Checked));
                list.Add(Convert.ToInt32(CheckBox50.Checked == false));
                list.Add(Convert.ToInt32(CheckBox51.Checked == false));
                list.Add(Convert.ToInt32(CheckBox52.Checked == false));
                list.Add(Convert.ToInt32(CheckBox53.Checked));
                list.Add(Convert.ToInt32(CheckBox54.Checked));
                list.Add(Convert.ToInt32(CheckBox55.Checked == false));
                list.Add(Convert.ToInt32(CheckBox56.Checked));
                list.Add(Convert.ToInt32(CheckBox57.Checked == false));
                list.Add(Convert.ToInt32(CheckBox58.Checked));
                list.Add(Convert.ToInt32(CheckBox59.Checked));
                list.Add(Convert.ToInt32(CheckBox60.Checked == false));
                list.Add(Convert.ToInt32(CheckBox61.Checked));
                list.Add(Convert.ToInt32(CheckBox62.Checked));
                list.Add(Convert.ToInt32(CheckBox63.Checked == false));
                list.Add(Convert.ToInt32(CheckBox64.Checked));
                list.Add(Convert.ToInt32(CheckBox65.Checked));
                list.Add(Convert.ToInt32(CheckBox66.Checked));
                list.Add(Convert.ToInt32(CheckBox67.Checked));
                list.Add(Convert.ToInt32(CheckBox68.Checked));
                list.Add(Convert.ToInt32(CheckBox69.Checked));
                list.Add(Convert.ToInt32(CheckBox70.Checked == false));
                list.Add(Convert.ToInt32(CheckBox71.Checked));
                list.Add(Convert.ToInt32(CheckBox72.Checked));
                list.Add(Convert.ToInt32(CheckBox73.Checked));
                list.Add(Convert.ToInt32(CheckBox74.Checked));
                list.Add(Convert.ToInt32(CheckBox75.Checked));
                list.Add(Convert.ToInt32(CheckBox76.Checked == false));
                list.Add(Convert.ToInt32(CheckBox77.Checked));
                list.Add(Convert.ToInt32(CheckBox78.Checked));
                list.Add(Convert.ToInt32(CheckBox79.Checked));
                list.Add(Convert.ToInt32(CheckBox80.Checked == false));
                list.Add(Convert.ToInt32(CheckBox81.Checked));
                list.Add(Convert.ToInt32(CheckBox82.Checked));
                list.Add(Convert.ToInt32(CheckBox83.Checked == false));
                list.Add(Convert.ToInt32(CheckBox84.Checked));
                list.Add(Convert.ToInt32(CheckBox85.Checked));
                list.Add(Convert.ToInt32(CheckBox86.Checked == false));
                list.Add(Convert.ToInt32(CheckBox87.Checked));
                list.Add(Convert.ToInt32(CheckBox88.Checked == false));
                list.Add(Convert.ToInt32(CheckBox89.Checked));
                list.Add(Convert.ToInt32(CheckBox90.Checked == false));
                list.Add(Convert.ToInt32(CheckBox91.Checked == false));
                list.Add(Convert.ToInt32(CheckBox92.Checked));
                list.Add(Convert.ToInt32(CheckBox93.Checked == false));
                list.Add(Convert.ToInt32(CheckBox94.Checked));
                list.Add(Convert.ToInt32(CheckBox95.Checked));
                list.Add(Convert.ToInt32(CheckBox96.Checked));
                list.Add(Convert.ToInt32(CheckBox97.Checked));
                list.Add(Convert.ToInt32(CheckBox98.Checked == false));
                list.Add(Convert.ToInt32(CheckBox99.Checked));
                list.Add(Convert.ToInt32(CheckBox100.Checked));
                list.Add(Convert.ToInt32(CheckBox101.Checked == false));
                list.Add(Convert.ToInt32(CheckBox102.Checked));
                list.Add(Convert.ToInt32(CheckBox103.Checked));
                list.Add(Convert.ToInt32(CheckBox104.Checked));
                list.Add(Convert.ToInt32(CheckBox105.Checked));
                list.Add(Convert.ToInt32(CheckBox106.Checked));
                list.Add(Convert.ToInt32(CheckBox107.Checked));
                list.Add(Convert.ToInt32(CheckBox108.Checked));
                list.Add(Convert.ToInt32(CheckBox109.Checked == false));
                list.Add(Convert.ToInt32(CheckBox110.Checked == false));
                list.Add(Convert.ToInt32(CheckBox111.Checked == false));
                list.Add(Convert.ToInt32(CheckBox112.Checked));
                list.Add(Convert.ToInt32(CheckBox113.Checked == false));
                list.Add(Convert.ToInt32(CheckBox114.Checked == false));
                list.Add(Convert.ToInt32(CheckBox115.Checked == false));
                list.Add(Convert.ToInt32(CheckBox116.Checked == false));
                list.Add(Convert.ToInt32(CheckBox117.Checked == false));
                list.Add(Convert.ToInt32(CheckBox118.Checked));
                list.Add(Convert.ToInt32(CheckBox119.Checked == false));
                list.Add(Convert.ToInt32(CheckBox120.Checked == false));
                list.Add(Convert.ToInt32(CheckBox121.Checked));
                list.Add(Convert.ToInt32(CheckBox122.Checked == false));
                list.Add(Convert.ToInt32(CheckBox123.Checked == false));
                list.Add(Convert.ToInt32(CheckBox124.Checked == false));
                list.Add(Convert.ToInt32(CheckBox125.Checked));
                list.Add(Convert.ToInt32(CheckBox126.Checked));
                list.Add(Convert.ToInt32(CheckBox127.Checked));
                list.Add(Convert.ToInt32(CheckBox128.Checked == false));
                list.Add(Convert.ToInt32(CheckBox129.Checked == false));
                list.Add(Convert.ToInt32(CheckBox130.Checked));
                list.Add(Convert.ToInt32(CheckBox131.Checked));
                list.Add(Convert.ToInt32(CheckBox132.Checked == false));
                list.Add(Convert.ToInt32(CheckBox133.Checked));
                list.Add(Convert.ToInt32(CheckBox134.Checked == false));
                list.Add(Convert.ToInt32(CheckBox135.Checked == false));
                list.Add(Convert.ToInt32(CheckBox136.Checked));
                list.Add(Convert.ToInt32(CheckBox137.Checked));
                list.Add(Convert.ToInt32(CheckBox138.Checked));
                list.Add(Convert.ToInt32(CheckBox139.Checked == false));
                list.Add(Convert.ToInt32(CheckBox140.Checked == false));
                list.Add(Convert.ToInt32(CheckBox141.Checked == false));
                list.Add(Convert.ToInt32(CheckBox142.Checked));
                list.Add(Convert.ToInt32(CheckBox143.Checked));
                list.Add(Convert.ToInt32(CheckBox144.Checked == false));
                list.Add(Convert.ToInt32(CheckBox145.Checked));
                list.Add(Convert.ToInt32(CheckBox146.Checked == false));
                list.Add(Convert.ToInt32(CheckBox147.Checked));
                list.Add(Convert.ToInt32(CheckBox148.Checked));
                list.Add(Convert.ToInt32(CheckBox149.Checked == false));
                list.Add(Convert.ToInt32(CheckBox150.Checked == false));
                list.Add(Convert.ToInt32(CheckBox151.Checked));
                list.Add(Convert.ToInt32(CheckBox152.Checked));
                list.Add(Convert.ToInt32(CheckBox153.Checked));
                list.Add(Convert.ToInt32(CheckBox154.Checked));
                list.Add(Convert.ToInt32(CheckBox155.Checked));
                list.Add(Convert.ToInt32(CheckBox156.Checked == false));
                list.Add(Convert.ToInt32(CheckBox157.Checked));
                list.Add(Convert.ToInt32(CheckBox158.Checked));
                list.Add(Convert.ToInt32(CheckBox159.Checked == false));
                list.Add(Convert.ToInt32(CheckBox160.Checked));
                list.Add(Convert.ToInt32(CheckBox161.Checked));
                list.Add(Convert.ToInt32(CheckBox162.Checked));
                list.Add(Convert.ToInt32(CheckBox163.Checked));
                list.Add(Convert.ToInt32(CheckBox164.Checked));
                list.Add(Convert.ToInt32(CheckBox165.Checked));
                list.Add(Convert.ToInt32(CheckBox166.Checked == false));
                list.Add(Convert.ToInt32(CheckBox167.Checked));
                list.Add(Convert.ToInt32(CheckBox168.Checked));
                list.Add(Convert.ToInt32(CheckBox169.Checked));
                list.Add(Convert.ToInt32(CheckBox170.Checked == false));
                list.Add(Convert.ToInt32(CheckBox171.Checked));
                list.Add(Convert.ToInt32(CheckBox172.Checked));
                list.Add(Convert.ToInt32(CheckBox173.Checked));
                list.Add(Convert.ToInt32(CheckBox174.Checked == false));
                list.Add(Convert.ToInt32(CheckBox175.Checked));
                list.Add(Convert.ToInt32(CheckBox176.Checked));
                list.Add(Convert.ToInt32(CheckBox177.Checked));
                list.Add(Convert.ToInt32(CheckBox178.Checked == false));
                list.Add(Convert.ToInt32(CheckBox179.Checked == false));
                list.Add(Convert.ToInt32(CheckBox180.Checked == false));
                list.Add(Convert.ToInt32(CheckBox181.Checked == false));
                list.Add(Convert.ToInt32(CheckBox182.Checked == false));
                list.Add(Convert.ToInt32(CheckBox183.Checked == false));
                list.Add(Convert.ToInt32(CheckBox184.Checked == false));
                list.Add(Convert.ToInt32(CheckBox185.Checked == false));
                list.Add(Convert.ToInt32(CheckBox186.Checked));
                list.Add(Convert.ToInt32(CheckBox187.Checked));
                list.Add(Convert.ToInt32(CheckBox188.Checked));
                list.Add(Convert.ToInt32(CheckBox189.Checked));
                list.Add(Convert.ToInt32(CheckBox190.Checked == false));
                list.Add(Convert.ToInt32(CheckBox191.Checked == false));
                list.Add(Convert.ToInt32(CheckBox192.Checked == false));
                list.Add(Convert.ToInt32(CheckBox193.Checked));
                list.Add(Convert.ToInt32(CheckBox194.Checked));
                list.Add(Convert.ToInt32(CheckBox195.Checked == false));
                list.Add(Convert.ToInt32(CheckBox196.Checked));
                list.Add(Convert.ToInt32(CheckBox197.Checked == false));
                list.Add(Convert.ToInt32(CheckBox198.Checked == false));
                list.Add(Convert.ToInt32(CheckBox199.Checked == false));
                list.Add(Convert.ToInt32(CheckBox200.Checked == false));
                list.Add(Convert.ToInt32(CheckBox201.Checked == false));
                list.Add(Convert.ToInt32(CheckBox202.Checked == false));
                list.Add(Convert.ToInt32(CheckBox203.Checked));
                list.Add(Convert.ToInt32(CheckBox204.Checked == false));
                list.Add(Convert.ToInt32(CheckBox205.Checked));
                list.Add(Convert.ToInt32(CheckBox206.Checked == false));
                list.Add(Convert.ToInt32(CheckBox207.Checked));
                list.Add(Convert.ToInt32(CheckBox208.Checked == false));
                list.Add(Convert.ToInt32(CheckBox209.Checked));
                list.Add(Convert.ToInt32(CheckBox210.Checked == false));


                TextBox1.Visible = true;

                foreach (int deger in list)
                {

                    TextBox1.Text += deger;

                }
                TextBox1.Visible = false;
                SqlConnection baglanti = new SqlConnection("Data Source =YAGMUR; Initial Catalog=yazilim; User Id=sa; Password=123;");
                //SqlConnection baglanti = new SqlConnection("Data Source = GLSN; Initial Catalog=yazilim; User Id=sa; Password=nesluG-1339;");
                baglanti.Open();


                SqlCommand ekle = new SqlCommand("update kisiler set test1=@test1 where ad='" + Session["ad"] + "'", baglanti);
                //SqlCommand cmd = new SqlCommand(ekle, baglanti);
                //ekle.Parameters.AddWithValue("@ad", Session["ad"]);
                ekle.Parameters.AddWithValue("@test1", TextBox1.Text);
                ekle.ExecuteNonQuery();
                baglanti.Close();


            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("test2.aspx");
        }
    }
}