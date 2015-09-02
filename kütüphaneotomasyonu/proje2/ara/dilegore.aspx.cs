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
    public partial class dilegore : System.Web.UI.Page
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
                string sorgu = "select kitap.adi,kitap.dil,kitap_yazar.yazar_no from kitap inner join kitap_yazar on kitap.kitap_no=kitap_yazar.kitap_no where kitap.dil=@dil;";
                SqlCommand cmd = new SqlCommand(sorgu, baglanti);
                cmd.Parameters.AddWithValue("@dil", TextBox1.Text);
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