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
    public partial class Delete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            // Connection string to connect to the database
            string connectionString = ConfigurationManager.ConnectionStrings["YourDbConnectionString"].ConnectionString;

            // SQL query to delete data from the table
            string deleteSql = "DELETE FROM Opportunity WHERE opportunity_id = @id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(deleteSql, connection))
                {
                    command.Parameters.AddWithValue("@id", txtId.Text);
                    connection.Open();
                    command.Execute
		            command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }
    }
}

