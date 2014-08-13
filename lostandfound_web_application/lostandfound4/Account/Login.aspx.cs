using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using System;
using System.Linq;
using System.Web;
using System.Web.UI;
using lostandfound4.Models;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Text;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Web.Security;

namespace lostandfound4.Account
{
    public partial class Login : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            RegisterHyperLink.NavigateUrl = "Register";
            OpenAuthLogin.ReturnUrl = Request.QueryString["ReturnUrl"];
            var returnUrl = HttpUtility.UrlEncode(Request.QueryString["ReturnUrl"]);
            if (!String.IsNullOrEmpty(returnUrl))
            {
                RegisterHyperLink.NavigateUrl += "?ReturnUrl=" + returnUrl;
            }
        }

        protected void LogIn(object sender, EventArgs e)
        {
            if (IsValid)
            {
                if (AuthenticateUser(UserName.Text, Password.Text))
                {
                   
                    FormsAuthentication.RedirectFromLoginPage(UserName.Text, true);
                }
                else
                {
                    FailureText.Text = "Invalid username or password.";
                    ErrorMessage.Visible = true;
                }
            }
        }

        public bool AuthenticateUser(string username, string password)
        {
            bool ReturnCode;
            string cs = ConfigurationManager.ConnectionStrings["LostandFoundConnection"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                
                SqlCommand cmd = new SqlCommand("Authenticate_User", con);
                cmd.CommandType = CommandType.StoredProcedure;

                string encryptedpassword = lostandfound4.Account.Register.CalculateSha1(Password.Text, Encoding.Default);
                SqlParameter c_UserName = new SqlParameter("@Emailid", UserName.Text);
                SqlParameter c_Password = new SqlParameter("@Password", encryptedpassword);
                cmd.Parameters.Add("@cid", SqlDbType.Int,100);
                cmd.Parameters["@cid"].Direction = ParameterDirection.Output;
                cmd.Parameters.Add(c_UserName);
                cmd.Parameters.Add(c_Password);
                con.Open();
                cmd.ExecuteNonQuery();
                int cid = (int) cmd.Parameters["@cid"].Value;
                Session["UserID"] = cid;
                if (cid == 0)
                { 
                    return ReturnCode = false; 
                }
                else
                    return ReturnCode = true;
                
           }
       }

    }
}