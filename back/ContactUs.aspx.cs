using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace manjam_backend
{
    public partial class ContactUs : System.Web.UI.Page
    {
        protected void submitButton_Click(object sender, EventArgs e)
        {
            string email = emailTextBox.Text;
            string name = nameTextBox.Text;
            string address = addressTextBox.Text;
            string message = messageTextBox.Text;

            string connectionString = ConfigurationManager.ConnectionStrings["YourConnectionString"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string queryString = "INSERT INTO ContactUS (email, name, address, message) VALUES (@email, @name, @address, @message)";
                using (SqlCommand command = new SqlCommand(queryString, connection))
                {
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@address", address);
                    command.Parameters.AddWithValue("@message", message);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}