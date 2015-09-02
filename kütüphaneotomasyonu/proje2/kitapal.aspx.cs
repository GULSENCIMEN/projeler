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
    public partial class kitapal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label2.Visible = false;   

        }

        
        protected void Button1_Click1(object sender, EventArgs e)
        {
            string tarih = DateTime.Today.AddDays(15).ToShortDateString();
            //string strConnectionString = "Data Source = RAYBEK; Initial Catalog=LBRY1; User Id=sa; Password=raybek;";
            string strConnectionString = "Data Source = CEMRE; Initial Catalog=LBRY1; User Id=sa; Password=123;";
            SqlConnection objConnection = new SqlConnection(strConnectionString);
            objConnection.Open();

            SqlCommand ekle = new SqlCommand("insert into iade(iade_tarihi,kitap_no,tc) values (@iade_trh,@kitap_no,@tc)", objConnection);
           
            ekle.Parameters.AddWithValue("@iade_trh", tarih);
            ekle.Parameters.AddWithValue("@kitap_no", TextBox1.Text);
            ekle.Parameters.AddWithValue("@tc", Session["tc"]);
            ekle.ExecuteNonQuery();
            objConnection.Close();
            Label2.Visible = true;
            Label2.Text = "Kitap Eklendi.Üzerimdekilere tıklayarak görebilirsiniz.";
        }

    


       
    }
}