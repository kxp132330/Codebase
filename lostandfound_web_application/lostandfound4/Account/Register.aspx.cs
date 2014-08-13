using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Linq;
using System.Web;
using System.Web.UI;
using lostandfound4.Models;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Web.Security;
using System.Security.Cryptography;
using System.Text;

namespace lostandfound4.Account
{
    public partial class Register : Page
    {
        protected void CreateUser_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                string cs = ConfigurationManager.ConnectionStrings["LostandFoundConnection"].ConnectionString;
                using (SqlConnection con = new SqlConnection(cs))
                {
                    SqlCommand cmd = new SqlCommand("Register_User", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    string EncryptedPassword = CalculateSha1(Password.Text, Encoding.Default);
                    SqlParameter c_FirstName = new SqlParameter("@FirstName", FirstName.Text);
                    SqlParameter c_LastName = new SqlParameter("@LastName", LastName.Text);
                    SqlParameter c_Emailid = new SqlParameter("@Emailid", Emailid.Text);
                    SqlParameter c_Password = new SqlParameter("@Password", EncryptedPassword);
                    SqlParameter i_MobileNumber = new SqlParameter("@MobileNumber", MobileNumber.Text);

                    cmd.Parameters.Add(c_FirstName);
                    cmd.Parameters.Add(c_LastName);
                    cmd.Parameters.Add(i_MobileNumber);
                    cmd.Parameters.Add(c_Emailid);
                    cmd.Parameters.Add(c_Password);

                    con.Open();

                    Int32 ReturnCode = (Int32)cmd.ExecuteScalar();
                    if (ReturnCode == -1)
                    {
                        ErrorMessage.Text = "User name already exists,please try another one";
                    }
                    else
                    {
                        Response.Redirect("login.aspx");
                    }
                }
            }
        }

        public static string CalculateSha1(string text, Encoding enc)
        {
            byte[] buffer = enc.GetBytes(text);
            SHA1CryptoServiceProvider cryptoTransformSha1 =
            new SHA1CryptoServiceProvider();
            string hash = BitConverter.ToString(
                cryptoTransformSha1.ComputeHash(buffer)).Replace("-", "");

            return hash;
        }
    }
}
