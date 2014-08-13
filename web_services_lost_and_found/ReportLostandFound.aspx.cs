using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using lostandfound4.ReportLostFoundp;

namespace lostandfound4
{
    public partial class About : Page
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
            string title = txttitle.Text;
            string desc = txtdesc.Text;
            string primary = txtprimary.Text;
            string serialno = txtserialnumber.Text;
            int cid=(int)(Session["userID"]);
            ReportLostFoundp.ReportLostFoundSoapClient reportlostfound = new ReportLostFoundp.ReportLostFoundSoapClient();
            string message=reportlostfound.report_lost(type,reportdate,category,location,title,desc,primary,serialno,cid);
           
            lblsucess.Text = message;
            lblsucess.Visible = true;
         

        }
    }
}