using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Web.Security;

namespace WEBSOA.Register
{
    public partial class register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["WEBSOA"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd=new SqlCommand("proregusr",con);
                cmd.CommandType=CommandType.StoredProcedure;
                string EncryptedPassword = FormsAuthentication.HashPasswordForStoringInConfigFile(pwd.Text, "SHA1");
                SqlParameter usarname=new SqlParameter("@username",usrname.Text);
                SqlParameter psword = new SqlParameter("@password", EncryptedPassword);
                SqlParameter unique=new SqlParameter("@uniqueid",unid.Text);
                SqlParameter emlid=new SqlParameter("@email",email.Text);

                cmd.Parameters.Add(usarname);
                cmd.Parameters.Add(psword);
                cmd.Parameters.Add(unique);
                cmd.Parameters.Add(emlid);
                con.Open();

                int ReturnCode = (int)cmd.ExecuteScalar(); 
                if (ReturnCode == -1)
                {
                    lblwarn.Text = "User name already exists,please try another one";
                }
                else
                {
                    Response.Redirect("~/login.aspx");
                }


            }
        }

        protected void pwd_TextChanged(object sender, EventArgs e)
        {

        }
    }
}