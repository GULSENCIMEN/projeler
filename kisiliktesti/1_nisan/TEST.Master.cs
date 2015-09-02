using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _1_nisan
{
    public partial class TEST : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LabelT1.Text = Session["ad"].ToString();
            LabelT2.Text = Session["soyad"].ToString();
        }
       
    }
}