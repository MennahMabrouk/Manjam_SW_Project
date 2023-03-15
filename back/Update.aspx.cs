using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;

namespace YourNameSpace
{
    public partial class Update : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            // Connection string to connect to the database
            string connectionString = ConfigurationManager.ConnectionStrings["YourDbConnectionString"].ConnectionString;

            // SQL query to update data in the table
            string updateSql = "UPDATE Opportunity SET title = @title, details = @details " +
                "WHERE opportunity_id = @id";
	    using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(updateSql, connection))
                {
                    command.Parameters.AddWithValue("@id", txtId.Text);
                    command.Parameters.AddWithValue("@title", txtTitle.Text);
                    command.Parameters.AddWithValue("@details", txtDetails.Text);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }
    }
}


