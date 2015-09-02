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
    public partial class okuduklarım : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.LoadData();
        }

        public DataTable GetName()
        {
           // SqlConnection baglanti = new SqlConnection("Data Source = RAYBEK; Initial Catalog=LBRY1; User Id=sa; Password=raybek;");
            SqlConnection baglanti = new SqlConnection("Data Source = CEMRE; Initial Catalog=LBRY1; User Id=sa; Password=123;");

            try
            {


                StringBuilder strQueryString = new StringBuilder();
                strQueryString.Append("select kitap.kitap_no,kitap.adi,kitap.tür from kitap    ");
                strQueryString.Append("inner join odunc   ");
                strQueryString.Append("on kitap.kitap_no=odunc.kitap_no  ");
                strQueryString.Append("inner join üye  ");
                strQueryString.Append("on üye.tc=odunc.tc   ");
                strQueryString.Append("where üye.tc=@tc ");

                SqlCommand objCommand = new SqlCommand(strQueryString.ToString(), baglanti);

                //objCommand.Parameters.AddWithValue("@tc", TextBox1.Text);
                objCommand.Parameters.AddWithValue("@tc", Session["tc"]);

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