using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace _1_nisan
{
    public partial class uyeler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.LoadData();
           

        }
        public DataTable GetName()
        {

            SqlConnection baglanti = new SqlConnection("Data Source = YAGMUR; Initial Catalog=yazilim; User Id=sa; Password=123;");
            try
            {
                baglanti.Open();
                string sorgu = "select ad,soyad from kisiler ;";
                SqlCommand cmd1 = new SqlCommand("Select  Count(ad) as sayi From kisiler", baglanti);
                //Label1.Text = (Convert.ToInt32(cmd1)).ToString();
                SqlCommand cmd = new SqlCommand(sorgu, baglanti);

                //Label1.Text = Convert.ToString(cmd1);
                Label1.Text = cmd1.ExecuteScalar().ToString();

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
        protected void Button1_Click(object sender, EventArgs e)
        {
           // this.LoadData();
        }
    }
}