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
    public partial class yayınevinegore : System.Web.UI.Page
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
                string sorgu = "select kitap.kitap_no,kitap.adi,yayin_evi.yayinevi_no,yayin_evi.yayinevi_adi from kitap inner join yayin_evi on kitap.yayinevi_no=yayin_evi.yayinevi_no where yayin_evi.yayinevi_no=@yayinevi";
                SqlCommand cmd = new SqlCommand(sorgu, baglanti);
                cmd.Parameters.AddWithValue("@yayinevi", TextBox1.Text);
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