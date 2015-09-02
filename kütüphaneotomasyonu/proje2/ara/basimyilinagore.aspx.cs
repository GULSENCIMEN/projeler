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
    public partial class basimyilinagore : System.Web.UI.Page
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

                StringBuilder strQueryString = new StringBuilder();
                strQueryString.Append("select kitap.adi,kitap.kitap_no,kitap.tür,kitap.basim_yili,yazar.yazar_adi,yazar.yazar_soyadi from yazar    ");
                strQueryString.Append("inner join kitap_yazar on kitap_yazar.yazar_no=yazar.yazar_no ");
                strQueryString.Append("inner join kitap on kitap.kitap_no=kitap_yazar.kitap_no ");
                strQueryString.Append("where kitap.basim_yili=@basmyili");


                SqlCommand objCommand = new SqlCommand(strQueryString.ToString(), baglanti);

                objCommand.Parameters.AddWithValue("@basmyili", TextBox1.Text);

                SqlDataAdapter objAdapter = new SqlDataAdapter(objCommand);
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