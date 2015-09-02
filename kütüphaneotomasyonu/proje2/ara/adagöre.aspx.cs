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


namespace proje2.ara
{
    public partial class adagöre : System.Web.UI.Page
    {
               protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            this.LoadData();

        }
    
        public DataTable GetName()
        {
           // SqlConnection baglanti = new SqlConnection("Data Source = RAYBEK; Initial Catalog=LBRY1; User Id=sa; Password=raybek;");
            SqlConnection baglanti = new SqlConnection("Data Source = CEMRE; Initial Catalog=LBRY1; User Id=sa; Password=123;");
            try
            {
                baglanti.Open();
                string sorgu = "select kitap_no,adi,dil,basim_yili,tür,yayinevi_no from kitap  where adi=@adi";
                SqlCommand cmd = new SqlCommand(sorgu, baglanti);
                cmd.Parameters.AddWithValue("@adi", TextBox1.Text);
                SqlDataAdapter objAdapter = new SqlDataAdapter(cmd);
                DataTable objDataTable = new DataTable();
                objAdapter.Fill(objDataTable);

                return objDataTable;
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally 
            {
                baglanti.Close();
            }
    }

        void LoadData()
        {
            try
            {
                DataTable dtTables = this.GetName();
                GridView1.DataSource = dtTables;
                GridView1.DataBind();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}