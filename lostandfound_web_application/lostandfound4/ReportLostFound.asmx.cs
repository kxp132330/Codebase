using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace lostandfound4
{
    /// <summary>
    /// Summary description for ReportLostFound
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class ReportLostFound : System.Web.Services.WebService
    {
     [WebMethod]
     public string report_lost(string losf,DateTime datelosfou, int cat,int locdes,  string titl, string descr, string primcol, string sno, int cuid)
        {
            string message;
            string cs = ConfigurationManager.ConnectionStrings["LostandFoundConnection"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("ReportLostandFound", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter parameter = new SqlParameter("@date", datelosfou);
                SqlParameter parameter1 = new SqlParameter("@category", cat);
                SqlParameter parameter2 = new SqlParameter("@serailno", sno);
                SqlParameter parameter3 = new SqlParameter("@title", titl);
                SqlParameter parameter4 = new SqlParameter("@description", descr);
                SqlParameter parameter5 = new SqlParameter("@primarycolor", primcol);
                SqlParameter parameter6 = new SqlParameter("@lostorfound", losf);
                SqlParameter parameter7 = new SqlParameter("@locdesc", locdes);
                SqlParameter parameter8 = new SqlParameter("@custid", cuid);


                cmd.Parameters.Add(parameter);
                cmd.Parameters.Add(parameter1);
                cmd.Parameters.Add(parameter2);
                cmd.Parameters.Add(parameter3);
                cmd.Parameters.Add(parameter4);
                cmd.Parameters.Add(parameter5);
                cmd.Parameters.Add(parameter6);
                cmd.Parameters.Add(parameter7);
                cmd.Parameters.Add(parameter8);
                cmd.Parameters.Add("@ERROR", SqlDbType.Char, 500);
                cmd.Parameters["@ERROR"].Direction = ParameterDirection.Output;
                con.Open();
                cmd.ExecuteNonQuery();
                message = (string)cmd.Parameters["@ERROR"].Value;
                con.Close();
                return message;

            }
        }
    }
}
