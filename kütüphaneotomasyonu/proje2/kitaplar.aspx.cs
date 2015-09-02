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
    public partial class kitaplar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.LoadData();
        }
        public DataTable GetAll()
        {
           // string strConnectionString = "Data Source =YAGMUR ; Initial Catalog=LBRY1; User Id=sa; Password=123;";
            string strConnectionString = "Data Source =CEMRE ; Initial Catalog=LBRY1; User Id=sa; Password=123;";

            SqlConnection objConnection = new SqlConnection(strConnectionString);
            try
            {
                objConnection.Open();
                StringBuilder strQueryString = new StringBuilder();
                strQueryString.Append("SELECT adi,basim_yili,dil,tür  ");
                strQueryString.Append("FROM kitap ");
                
                SqlCommand objCommand = new SqlCommand(strQueryString.ToString(), objConnection);
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
                objConnection.Close();
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