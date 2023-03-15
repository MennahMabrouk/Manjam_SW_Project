using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace webProject
{
    public partial class Signup : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        string connectionString = "Data Source=DESKTOP-9R45IA9\\IBRAHIMGAMAL; Initial Catalog=Manjam; Integrated Security=True;";
        protected void login_redirect_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }


        protected void Signup_Click(object sender, EventArgs e)
        {
            string username = Request.Form["usernamee"];
            string password = Request.Form["passwordd"];
            string repeat = Request.Form["repeatt"];

            //validate
            if (string.IsNullOrEmpty(username))
            {
                //errorLabel1.Text = "This field is required";
            }
            else if (string.IsNullOrEmpty(password))
            {
                //errorLabel2.Text = "This field is required";
            }
            else if (password.Length < 8)
            {
                //errorLabel2.Text = "Password must be at least 8 characters long";
            }
            else if (password != repeat)
            {
                //errorLabel3.Text = "Passwords do not match.";
            }
            else
            {
                //connect to the database
                string connectionString = "Data Source=DESKTOP-2GKUFKP\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    
                            //insert the new user into the database
                            string insertSql = "INSERT INTO users (username, password) VALUES (@username, @password)";
                            using (SqlCommand insertCommand = new SqlCommand(insertSql, conn))
                            {
                                insertCommand.Parameters.AddWithValue("@username", username);
                                insertCommand.Parameters.AddWithValue("@password", password);
                                insertCommand.ExecuteNonQuery();
                            }
                            //errorLabel1.Text = "";

                            // Redirect to the login page
                            Response.Redirect("Login.aspx");
                        }
                    }
                }
            }
        }

    

