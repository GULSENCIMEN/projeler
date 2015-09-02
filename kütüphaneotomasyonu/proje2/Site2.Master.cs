using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace proje2
{
    public partial class Site2 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = "Hosgeldiniz "+ Session["üye_adi"].ToString();
        }
    }
}