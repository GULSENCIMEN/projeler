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
    public partial class üye_liste : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.LoadData();
        }

        public DataTable GetAll()
        {
            //string strConnectionString = "Data Source = YAGMUR ; Initial Catalog=LBRY1; User Id=sa; Password=123;";
SqlConnection baglanti = new SqlConnection( "Data Source = CEMRE; Initial Catalog=LBRY1; User Id=sa; Password=123;");
           // SqlConnection objConnection = new SqlConnection(strConnectionString);
            try
            {
                baglanti.Open();
                StringBuilder strQueryString = new StringBuilder();
                strQueryString.Append("SELECT üye_adi,üye_soyadi,e_mail,üye_adres,üye_meslek    ");
                strQueryString.Append("FROM üye ");

                SqlCommand objCommand = new SqlCommand(strQueryString.ToString(), baglanti);
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
                DataTable dtTables = this.GetAll();
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