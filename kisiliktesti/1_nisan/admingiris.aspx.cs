using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace _1_nisan
{
    public partial class admingiris : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source =YAGMUR; Initial Catalog=yazilim; User Id=sa; Password=123;");
            //SqlConnection baglanti = new SqlConnection("Data Source = GLSN; Initial Catalog=yazilim; User Id=sa; Password=nesluG-1339;");

            baglanti.Open();

            SqlCommand sorgu = new SqlCommand("select * from adminn Where ad='" + TextBox1.Text + "' and soyad='" + TextBox2.Text + "'", baglanti);



            Response.Redirect("admin.aspx");
        }
    }
}