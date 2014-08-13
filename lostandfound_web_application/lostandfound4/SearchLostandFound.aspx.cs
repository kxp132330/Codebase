using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using lostandfound4.SearchLostandFoundp;

namespace lostandfound4
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string type = ddltype.SelectedValue;
            string reporteddate = txtdatepicker.Text;
            DateTime reportdate = Convert.ToDateTime(reporteddate);
            int category = Convert.ToInt32(ddlcategory.SelectedValue);
            int location = Convert.ToInt32(ddllocation.SelectedValue);
            string keyword = txtkeyword.Text;
            SearchLostandFoundp.SearchLostFoundSoapClient reportlostfound = new SearchLostandFoundp.SearchLostFoundSoapClient();
            GridView1.DataSource= reportlostfound.GetLostandFound(type,category,location,reportdate,keyword);
            GridView1.DataBind();


           
        }
    }
}