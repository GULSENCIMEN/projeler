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
    public partial class test1_sonuc : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            {
                SqlConnection baglanti = new SqlConnection("Data Source =YAGMUR; Initial Catalog=yazilim; User Id=sa; Password=123;");
               // SqlConnection baglanti = new SqlConnection("Data Source =   GLSN; Initial Catalog=yazilim; User Id=sa; Password=nesluG-1339;");
                baglanti.Open();
                SqlDataAdapter adp = new SqlDataAdapter("SELECT * FROM kisiler where ad='" + Session["ad"] + "'", baglanti);
                DataTable table = new DataTable();
                adp.Fill(table);
                string[] array1 = new string[210];
                for (int i = 0; i < 210; i++)
                {
                    array1[i] = table.Rows[0]["test1"].ToString();
                    //TextBox1.Text=array1[i].ToString();
                }
                Label3.Text = array1[1].Substring(3, 1);
                Label4.Text = array1[2].Substring(4, 1);
                Label5.Text = array1[3].Substring(1, 1);
                Label6.Text = array1[4].Substring(151, 1);
                Label7.Text = array1[5].Substring(150, 1);
                Label8.Text = array1[6].Substring(0, 1);
                Label9.Text = array1[7].Substring(7, 1);

                Label10.Text = array1[8].Substring(8, 1);
                Label11.Text = array1[9].Substring(9, 1);
                Label12.Text = array1[10].Substring(6, 1);
                Label13.Text = array1[11].Substring(153, 1);
                Label14.Text = array1[12].Substring(152, 1);
                Label15.Text = array1[13].Substring(5, 1);
                Label16.Text = array1[14].Substring(12, 1);

                Label17.Text = array1[15].Substring(13, 1);
                Label18.Text = array1[16].Substring(14, 1);
                Label19.Text = array1[17].Substring(11, 1);
                Label20.Text = array1[18].Substring(157, 1);
                Label21.Text = array1[19].Substring(154, 1);
                Label22.Text = array1[20].Substring(15, 1);
                Label23.Text = array1[21].Substring(17, 1);

                Label24.Text = array1[22].Substring(18, 1);
                Label25.Text = array1[23].Substring(19, 1);
                Label26.Text = array1[24].Substring(21, 1);
                Label27.Text = array1[25].Substring(159, 1);
                Label28.Text = array1[26].Substring(156, 1);
                Label29.Text = array1[27].Substring(20, 1);
                Label30.Text = array1[28].Substring(27, 1);

                Label31.Text = array1[29].Substring(33, 1);
                Label32.Text = array1[30].Substring(24, 1);
                Label33.Text = array1[31].Substring(31, 1);
                Label34.Text = array1[32].Substring(161, 1);
                Label35.Text = array1[33].Substring(160, 1);
                Label36.Text = array1[34].Substring(30, 1);
                Label37.Text = array1[35].Substring(37, 1);

                Label38.Text = array1[36].Substring(38, 1);
                Label39.Text = array1[37].Substring(29, 1);
                Label40.Text = array1[38].Substring(36, 1);
                Label41.Text = array1[39].Substring(163, 1);
                Label42.Text = array1[40].Substring(162, 1);
                Label43.Text = array1[41].Substring(45, 1);
                Label44.Text = array1[42].Substring(47, 1);

                Label45.Text = array1[43].Substring(43, 1);
                Label46.Text = array1[44].Substring(34, 1);
                Label47.Text = array1[45].Substring(41, 1);
                Label48.Text = array1[46].Substring(155, 1);
                Label49.Text = array1[47].Substring(164, 1);
                Label50.Text = array1[48].Substring(10, 1);
                Label51.Text = array1[49].Substring(52, 1);

                Label52.Text = array1[50].Substring(48, 1);
                Label53.Text = array1[51].Substring(39, 1);
                Label54.Text = array1[52].Substring(16, 1);
                Label55.Text = array1[53].Substring(168, 1);
                Label56.Text = array1[54].Substring(158, 1);
                Label57.Text = array1[55].Substring(25, 1);
                Label58.Text = array1[56].Substring(2, 1);

                Label59.Text = array1[57].Substring(53, 1);
                Label60.Text = array1[58].Substring(44, 1);
                Label61.Text = array1[59].Substring(26, 1);
                Label62.Text = array1[60].Substring(172, 1);
                Label63.Text = array1[61].Substring(167, 1);
                Label64.Text = array1[62].Substring(35, 1);
                Label65.Text = array1[63].Substring(22, 1);


                Label66.Text = array1[64].Substring(23, 1);
                Label67.Text = array1[65].Substring(49, 1);
                Label68.Text = array1[66].Substring(46, 1);
                Label69.Text = array1[67].Substring(175, 1);
                Label70.Text = array1[68].Substring(168, 1);
                Label71.Text = array1[69].Substring(40, 1);
                Label72.Text = array1[70].Substring(32, 1);





                Label73.Text = array1[71].Substring(28, 1);
                Label74.Text = array1[72].Substring(54, 1);
                Label75.Text = array1[73].Substring(51, 1);
                Label76.Text = array1[74].Substring(185, 1);
                Label77.Text = array1[75].Substring(170, 1);
                Label78.Text = array1[76].Substring(50, 1);
                Label79.Text = array1[77].Substring(42, 1);

                Label80.Text = array1[78].Substring(58, 1);
                Label81.Text = array1[79].Substring(64, 1);
                Label82.Text = array1[80].Substring(61, 1);
                Label83.Text = array1[81].Substring(187, 1);
                Label84.Text = array1[82].Substring(172, 1);
                Label85.Text = array1[83].Substring(55, 1);
                Label86.Text = array1[84].Substring(57, 1);

                Label87.Text = array1[85].Substring(63, 1);
                Label88.Text = array1[86].Substring(74, 1);
                Label89.Text = array1[87].Substring(66, 1);
                Label90.Text = array1[88].Substring(193, 1);
                Label91.Text = array1[89].Substring(174, 1);
                Label92.Text = array1[90].Substring(60, 1);
                Label93.Text = array1[91].Substring(67, 1);

                Label94.Text = array1[92].Substring(68, 1);
                Label95.Text = array1[93].Substring(84, 1);
                Label96.Text = array1[94].Substring(71, 1);
                Label97.Text = array1[95].Substring(195, 1);
                Label98.Text = array1[96].Substring(176, 1);
                Label99.Text = array1[97].Substring(65, 1);
                Label100.Text = array1[98].Substring(72, 1);

                Label101.Text = array1[99].Substring(73, 1);
                Label102.Text = array1[100].Substring(94, 1);
                Label103.Text = array1[101].Substring(76, 1);
                Label104.Text = array1[102].Substring(165, 1);
                Label105.Text = array1[103].Substring(186, 1);
                Label106.Text = array1[104].Substring(70, 1);
                Label107.Text = array1[105].Substring(77, 1);

                Label108.Text = array1[106].Substring(155, 1);
                Label109.Text = array1[107].Substring(78, 1);
                Label110.Text = array1[108].Substring(99, 1);
                Label111.Text = array1[109].Substring(81, 1);
                Label112.Text = array1[110].Substring(169, 1);
                Label113.Text = array1[111].Substring(188, 1);
                Label114.Text = array1[112].Substring(95, 1);
                Label115.Text = array1[113].Substring(102, 1);

                Label116.Text = array1[114].Substring(83, 1);
                Label117.Text = array1[115].Substring(104, 1);
                Label118.Text = array1[116].Substring(86, 1);
                Label119.Text = array1[117].Substring(63, 1);
                Label120.Text = array1[118].Substring(192, 1);
                Label121.Text = array1[119].Substring(105, 1);
                Label122.Text = array1[120].Substring(107, 1);

                Label123.Text = array1[99].Substring(88, 1);
                Label124.Text = array1[100].Substring(59, 1);
                Label125.Text = array1[101].Substring(91, 1);
                Label126.Text = array1[102].Substring(177, 1);
                Label127.Text = array1[103].Substring(202, 1);
                Label128.Text = array1[104].Substring(75, 1);
                Label129.Text = array1[105].Substring(62, 1);

                Label130.Text = array1[106].Substring(93, 1);
                Label131.Text = array1[107].Substring(69, 1);
                Label132.Text = array1[108].Substring(101, 1);
                Label133.Text = array1[109].Substring(179, 1);
                Label134.Text = array1[110].Substring(204, 1);
                Label135.Text = array1[111].Substring(80, 1);
                Label136.Text = array1[112].Substring(82, 1);

                Label137.Text = array1[113].Substring(98, 1);
                Label138.Text = array1[114].Substring(79, 1);
                Label139.Text = array1[115].Substring(106, 1);
                Label140.Text = array1[116].Substring(181, 1);
                Label141.Text = array1[117].Substring(206, 1);
                Label142.Text = array1[118].Substring(85, 1);
                Label143.Text = array1[119].Substring(87, 1);

                Label144.Text = array1[92].Substring(103, 1);
                Label145.Text = array1[93].Substring(89, 1);
                Label146.Text = array1[94].Substring(56, 1);
                Label147.Text = array1[95].Substring(183, 1);
                Label148.Text = array1[96].Substring(208, 1);
                Label149.Text = array1[97].Substring(90, 1);
                Label150.Text = array1[98].Substring(92, 1);

                Label151.Text = array1[99].Substring(108, 1);
                Label152.Text = array1[100].Substring(109, 1);
                Label153.Text = array1[101].Substring(97, 1);
                Label154.Text = array1[102].Substring(189, 1);
                Label155.Text = array1[103].Substring(178, 1);
                Label156.Text = array1[104].Substring(100, 1);
                Label157.Text = array1[105].Substring(97, 1);

                Label158.Text = array1[106].Substring(113, 1);
                Label159.Text = array1[107].Substring(124, 1);
                Label160.Text = array1[108].Substring(111, 1);
                Label161.Text = array1[109].Substring(191, 1);
                Label162.Text = array1[110].Substring(180, 1);
                Label163.Text = array1[111].Substring(120, 1);
                Label164.Text = array1[112].Substring(117, 1);

                Label165.Text = array1[113].Substring(118, 1);
                Label166.Text = array1[114].Substring(129, 1);
                Label167.Text = array1[115].Substring(126, 1);
                Label168.Text = array1[116].Substring(197, 1);
                Label169.Text = array1[117].Substring(182, 1);
                Label170.Text = array1[118].Substring(125, 1);
                Label171.Text = array1[119].Substring(132, 1);

                Label172.Text = array1[120].Substring(123, 1);
                Label173.Text = array1[99].Substring(144, 1);
                Label174.Text = array1[100].Substring(136, 1);
                Label175.Text = array1[101].Substring(199, 1);
                Label176.Text = array1[102].Substring(184, 1);
                Label177.Text = array1[103].Substring(130, 1);
                Label178.Text = array1[104].Substring(137, 1);

                Label179.Text = array1[105].Substring(128, 1);
                Label180.Text = array1[106].Substring(114, 1);
                Label181.Text = array1[107].Substring(141, 1);
                Label182.Text = array1[108].Substring(201, 1);
                Label183.Text = array1[109].Substring(190, 1);
                Label184.Text = array1[110].Substring(135, 1);
                Label185.Text = array1[111].Substring(142, 1);

                Label186.Text = array1[112].Substring(133, 1);
                Label187.Text = array1[113].Substring(119, 1);
                Label188.Text = array1[114].Substring(146, 1);
                Label189.Text = array1[115].Substring(203, 1);
                Label190.Text = array1[116].Substring(194, 1);
                Label191.Text = array1[117].Substring(110, 1);
                Label192.Text = array1[118].Substring(147, 1);

                Label193.Text = array1[120].Substring(138, 1);
                Label194.Text = array1[99].Substring(134, 1);
                Label195.Text = array1[100].Substring(116, 1);
                Label196.Text = array1[101].Substring(205, 1);
                Label197.Text = array1[102].Substring(196, 1);
                Label198.Text = array1[103].Substring(115, 1);
                Label199.Text = array1[104].Substring(112, 1);

                Label200.Text = array1[105].Substring(143, 1);
                Label201.Text = array1[106].Substring(139, 1);
                Label202.Text = array1[107].Substring(121, 1);
                Label203.Text = array1[108].Substring(207, 1);
                Label204.Text = array1[109].Substring(198, 1);
                Label205.Text = array1[110].Substring(140, 1);
                Label206.Text = array1[111].Substring(122, 1);

                Label207.Text = array1[112].Substring(148, 1);
                Label208.Text = array1[113].Substring(149, 1);
                Label209.Text = array1[114].Substring(131, 1);
                Label210.Text = array1[115].Substring(209, 1);
                Label211.Text = array1[116].Substring(200, 1);
                Label212.Text = array1[117].Substring(145, 1);



                Label213.Text = Convert.ToString(Convert.ToInt32(Label3.Text) + Convert.ToInt32(Label10.Text) + Convert.ToInt32(Label17.Text) + Convert.ToInt32(Label24.Text) + Convert.ToInt32(Label31.Text) + Convert.ToInt32(Label38.Text) + Convert.ToInt32(Label45.Text) + Convert.ToInt32(Label52.Text) + Convert.ToInt32(Label59.Text) + Convert.ToInt32(Label66.Text) + Convert.ToInt32(Label73.Text) + Convert.ToInt32(Label80.Text) + Convert.ToInt32(Label87.Text) + Convert.ToInt32(Label94.Text) + Convert.ToInt32(Label101.Text) + Convert.ToInt32(Label108.Text) + Convert.ToInt32(Label115.Text) + Convert.ToInt32(Label122.Text) + Convert.ToInt32(Label129.Text) + Convert.ToInt32(Label136.Text) + Convert.ToInt32(Label143.Text) + Convert.ToInt32(Label150.Text) + Convert.ToInt32(Label157.Text) + Convert.ToInt32(Label164.Text) + Convert.ToInt32(Label171.Text) + Convert.ToInt32(Label178.Text) + Convert.ToInt32(Label185.Text) + Convert.ToInt32(Label192.Text) + Convert.ToInt32(Label199.Text) + Convert.ToInt32(Label206.Text));
                Label214.Text = Convert.ToString(Convert.ToInt32(Label4.Text) + Convert.ToInt32(Label11.Text) + Convert.ToInt32(Label18.Text) + Convert.ToInt32(Label25.Text) + Convert.ToInt32(Label32.Text) + Convert.ToInt32(Label39.Text) + Convert.ToInt32(Label46.Text) + Convert.ToInt32(Label53.Text) + Convert.ToInt32(Label60.Text) + Convert.ToInt32(Label67.Text) + Convert.ToInt32(Label74.Text) + Convert.ToInt32(Label81.Text) + Convert.ToInt32(Label88.Text) + Convert.ToInt32(Label95.Text) + Convert.ToInt32(Label102.Text) + Convert.ToInt32(Label109.Text) + Convert.ToInt32(Label116.Text) + Convert.ToInt32(Label123.Text) + Convert.ToInt32(Label130.Text) + Convert.ToInt32(Label137.Text) + Convert.ToInt32(Label144.Text) + Convert.ToInt32(Label151.Text) + Convert.ToInt32(Label158.Text) + Convert.ToInt32(Label165.Text) + Convert.ToInt32(Label172.Text) + Convert.ToInt32(Label179.Text) + Convert.ToInt32(Label186.Text) + Convert.ToInt32(Label193.Text) + Convert.ToInt32(Label200.Text) + Convert.ToInt32(Label207.Text));
                Label215.Text = Convert.ToString(Convert.ToInt32(Label5.Text) + Convert.ToInt32(Label12.Text) + Convert.ToInt32(Label19.Text) + Convert.ToInt32(Label26.Text) + Convert.ToInt32(Label33.Text) + Convert.ToInt32(Label40.Text) + Convert.ToInt32(Label47.Text) + Convert.ToInt32(Label54.Text) + Convert.ToInt32(Label61.Text) + Convert.ToInt32(Label68.Text) + Convert.ToInt32(Label75.Text) + Convert.ToInt32(Label82.Text) + Convert.ToInt32(Label89.Text) + Convert.ToInt32(Label96.Text) + Convert.ToInt32(Label103.Text) + Convert.ToInt32(Label110.Text) + Convert.ToInt32(Label117.Text) + Convert.ToInt32(Label124.Text) + Convert.ToInt32(Label131.Text) + Convert.ToInt32(Label138.Text) + Convert.ToInt32(Label145.Text) + Convert.ToInt32(Label152.Text) + Convert.ToInt32(Label159.Text) + Convert.ToInt32(Label166.Text) + Convert.ToInt32(Label173.Text) + Convert.ToInt32(Label180.Text) + Convert.ToInt32(Label187.Text) + Convert.ToInt32(Label194.Text) + Convert.ToInt32(Label201.Text) + Convert.ToInt32(Label208.Text));
                Label216.Text = Convert.ToString(Convert.ToInt32(Label6.Text) + Convert.ToInt32(Label13.Text) + Convert.ToInt32(Label20.Text) + Convert.ToInt32(Label27.Text) + Convert.ToInt32(Label34.Text) + Convert.ToInt32(Label41.Text) + Convert.ToInt32(Label48.Text) + Convert.ToInt32(Label55.Text) + Convert.ToInt32(Label62.Text) + Convert.ToInt32(Label69.Text) + Convert.ToInt32(Label76.Text) + Convert.ToInt32(Label83.Text) + Convert.ToInt32(Label90.Text) + Convert.ToInt32(Label97.Text) + Convert.ToInt32(Label104.Text) + Convert.ToInt32(Label111.Text) + Convert.ToInt32(Label118.Text) + Convert.ToInt32(Label125.Text) + Convert.ToInt32(Label132.Text) + Convert.ToInt32(Label139.Text) + Convert.ToInt32(Label146.Text) + Convert.ToInt32(Label153.Text) + Convert.ToInt32(Label160.Text) + Convert.ToInt32(Label167.Text) + Convert.ToInt32(Label174.Text) + Convert.ToInt32(Label181.Text) + Convert.ToInt32(Label188.Text) + Convert.ToInt32(Label195.Text) + Convert.ToInt32(Label202.Text) + Convert.ToInt32(Label209.Text));
                Label217.Text = Convert.ToString(Convert.ToInt32(Label7.Text) + Convert.ToInt32(Label14.Text) + Convert.ToInt32(Label21.Text) + Convert.ToInt32(Label28.Text) + Convert.ToInt32(Label35.Text) + Convert.ToInt32(Label42.Text) + Convert.ToInt32(Label49.Text) + Convert.ToInt32(Label56.Text) + Convert.ToInt32(Label63.Text) + Convert.ToInt32(Label70.Text) + Convert.ToInt32(Label77.Text) + Convert.ToInt32(Label84.Text) + Convert.ToInt32(Label91.Text) + Convert.ToInt32(Label98.Text) + Convert.ToInt32(Label105.Text) + Convert.ToInt32(Label112.Text) + Convert.ToInt32(Label119.Text) + Convert.ToInt32(Label126.Text) + Convert.ToInt32(Label133.Text) + Convert.ToInt32(Label140.Text) + Convert.ToInt32(Label147.Text) + Convert.ToInt32(Label154.Text) + Convert.ToInt32(Label161.Text) + Convert.ToInt32(Label168.Text) + Convert.ToInt32(Label175.Text) + Convert.ToInt32(Label182.Text) + Convert.ToInt32(Label189.Text) + Convert.ToInt32(Label196.Text) + Convert.ToInt32(Label203.Text) + Convert.ToInt32(Label210.Text));
                Label218.Text = Convert.ToString(Convert.ToInt32(Label8.Text) + Convert.ToInt32(Label15.Text) + Convert.ToInt32(Label22.Text) + Convert.ToInt32(Label29.Text) + Convert.ToInt32(Label36.Text) + Convert.ToInt32(Label43.Text) + Convert.ToInt32(Label50.Text) + Convert.ToInt32(Label57.Text) + Convert.ToInt32(Label64.Text) + Convert.ToInt32(Label71.Text) + Convert.ToInt32(Label78.Text) + Convert.ToInt32(Label85.Text) + Convert.ToInt32(Label92.Text) + Convert.ToInt32(Label99.Text) + Convert.ToInt32(Label106.Text) + Convert.ToInt32(Label113.Text) + Convert.ToInt32(Label120.Text) + Convert.ToInt32(Label127.Text) + Convert.ToInt32(Label134.Text) + Convert.ToInt32(Label141.Text) + Convert.ToInt32(Label148.Text) + Convert.ToInt32(Label155.Text) + Convert.ToInt32(Label162.Text) + Convert.ToInt32(Label169.Text) + Convert.ToInt32(Label176.Text) + Convert.ToInt32(Label183.Text) + Convert.ToInt32(Label190.Text) + Convert.ToInt32(Label197.Text) + Convert.ToInt32(Label204.Text) + Convert.ToInt32(Label211.Text));
                Label219.Text = Convert.ToString(Convert.ToInt32(Label9.Text) + Convert.ToInt32(Label16.Text) + Convert.ToInt32(Label23.Text) + Convert.ToInt32(Label30.Text) + Convert.ToInt32(Label37.Text) + Convert.ToInt32(Label44.Text) + Convert.ToInt32(Label51.Text) + Convert.ToInt32(Label58.Text) + Convert.ToInt32(Label65.Text) + Convert.ToInt32(Label72.Text) + Convert.ToInt32(Label79.Text) + Convert.ToInt32(Label86.Text) + Convert.ToInt32(Label93.Text) + Convert.ToInt32(Label100.Text) + Convert.ToInt32(Label107.Text) + Convert.ToInt32(Label114.Text) + Convert.ToInt32(Label121.Text) + Convert.ToInt32(Label128.Text) + Convert.ToInt32(Label135.Text) + Convert.ToInt32(Label142.Text) + Convert.ToInt32(Label149.Text) + Convert.ToInt32(Label156.Text) + Convert.ToInt32(Label163.Text) + Convert.ToInt32(Label170.Text) + Convert.ToInt32(Label177.Text) + Convert.ToInt32(Label184.Text) + Convert.ToInt32(Label191.Text) + Convert.ToInt32(Label198.Text) + Convert.ToInt32(Label205.Text) + Convert.ToInt32(Label212.Text));



                SqlCommand ekle = new SqlCommand("update kisiler set pratiklik=@pratiklik,sorumluluk=@sorumluluk, atilganlik=@atilganlik, risk=@risk ,etkinlik=@etkinlik ,sosyal=@sosyal ,tepkicilik=@tepkicilik where ad='" + Session["ad"] + "'", baglanti);
                ekle.Parameters.AddWithValue("@pratiklik", Label213.Text);
                ekle.Parameters.AddWithValue("@sorumluluk", Label214.Text);
                ekle.Parameters.AddWithValue("@atilganlik", Label215.Text);
                ekle.Parameters.AddWithValue("@risk", Label216.Text);
                ekle.Parameters.AddWithValue("@etkinlik", Label217.Text);
                ekle.Parameters.AddWithValue("@sosyal", Label218.Text);
                ekle.Parameters.AddWithValue("@tepkicilik", Label219.Text);
                ekle.ExecuteNonQuery();
                baglanti.Close();
                
            }

        }
       
        protected void Button1_Click1(object sender, EventArgs e)
        {
            Response.Redirect("sonuc_goruntule.aspx");
        }
    }
}