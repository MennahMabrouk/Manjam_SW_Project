using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace manjam_backend
{
    public partial class EditAccount : System.Web.UI.Page
    {
        private const string connectionString = "Data Source=MyServer;Initial Catalog=MyDatabase;User ID=MyUsername;Password=MyPassword"
;
        protected void deleteButton_Click(object sender, EventArgs e)
        {
            // get the user's id from the session
            int userId = (int)Session["userId"];

            // create a connection to the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // create a command to delete the user's account
                string deleteSql = "DELETE FROM users WHERE id = @userId";
                using (SqlCommand deleteCommand = new SqlCommand(deleteSql, connection))
                {
                    // add the user's id as a parameter
                    deleteCommand.Parameters.AddWithValue("@userId", userId);

                    try
                    {
                        // open the connection and execute the delete command
                        connection.Open();
                        deleteCommand.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        // handle any SQL errors that may occur
                        Console.WriteLine(ex.Message);
                    }
                }
            }
        }
    }
}