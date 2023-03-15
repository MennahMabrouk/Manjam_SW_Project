using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Web.Security;

namespace webProject
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        string connectionString = "Data Source=DESKTOP-9R45IA9\\IBRAHIMGAMAL; Initial Catalog=Manjam; Integrated Security=True;";
        protected void signup_redirect_Click(object sender, EventArgs e)
        {
            Response.Redirect("Signup.aspx");
        }

        protected void Login_Click(object sender, EventArgs e)
        {
            Response.Redirect("../front-end/Home.html");
            /*
            string username = Request.Form["username"];
            string password = Request.Form["password"];
            string connectionString = "Data Source=DESKTOP-2GKUFKP\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True";

            //connect to the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sqlSelect = "SELECT COUNT(*) FROM users WHERE username = @username AND password = @password";
                SqlCommand cmd = new SqlCommand(sqlSelect, connection) ;
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                if (count == 1)
                {

                    Response.Redirect("../fron-end/Home.html");
                    FormsAuthentication.SetAuthCookie(username, true);
                    Response.Redirect("Home.aspx");
                }
                else
                {
                    //userNotFound.Text = "Invalid username or password.";
                }
            
            }*/
        }
    
        }
    }
