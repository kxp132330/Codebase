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
    /// Summary description for SearchLostFound
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class SearchLostFound : System.Web.Services.WebService
    {

        [WebMethod]
        public DataTable GetLostandFound(string Type, int Location, int Category,DateTime date,string keyword)
        {

            string cs = ConfigurationManager.ConnectionStrings["LostandFoundConnection"].ConnectionString;
            SqlCommand cmdLostandFound = new SqlCommand();
            SqlDataAdapter LostandFoundAdp = new SqlDataAdapter();
           
            using (SqlConnection con = new SqlConnection(cs))
            {
                DataTable dt = new DataTable("searchtable");
                cmdLostandFound = new SqlCommand("Search_LostandFound", con);
                cmdLostandFound.Parameters.Add(new SqlParameter("@Type",Type));
                cmdLostandFound.Parameters.Add(new SqlParameter("@Location",Location));
                cmdLostandFound.Parameters.Add(new SqlParameter("@Category",Category));
                cmdLostandFound.Parameters.Add(new SqlParameter("@Keyword",keyword));
                SqlParameter parameter = new SqlParameter("@Date", SqlDbType.DateTime);
                parameter.Value = date;
                cmdLostandFound.Parameters.Add(parameter);
                cmdLostandFound.CommandType = CommandType.StoredProcedure;
                LostandFoundAdp.SelectCommand = cmdLostandFound;
                LostandFoundAdp.Fill(dt);
                return dt;
            }
        }
    }
}
