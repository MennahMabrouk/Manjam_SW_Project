using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace manjam_backend
{
    public partial class AddOpp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        string connectionString = "Data Source=DESKTOP-9R45IA9\\IBRAHIMGAMAL; Initial Catalog=Manjam; Integrated Security=True;";

        protected void add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(text_id.Text) || string.IsNullOrEmpty(text_title.Text) || fuImage.HasFile == false || string.IsNullOrEmpty(txtDetails.Text))

            {
                return;
            }

            // Convert ID to int
            int opportunityID = 0;
            if (!int.TryParse(text_id.Text, out opportunityID))
            {
                return;
            }
            // Read image into memory
            byte[] image = GetImageBytes(fuImage.PostedFile);

            byte[] imageData = null;
            using (BinaryReader br = new BinaryReader(fuImage.FileContent))
            {
                imageData = br.ReadBytes((int)fuImage.FileContent.Length);
            }

            // Create connection and command
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = connection.CreateCommand())
            {
                // Configure command
                command.CommandText = "INSERT INTO Opportunity (opportunity_id, title, image, details) VALUES (@opportunity_id, @title, @image, @details)";
                command.Parameters.Add("@opportunity_id", SqlDbType.Int).Value = opportunityID;
                command.Parameters.Add("@title", SqlDbType.VarChar, 100).Value = text_title.Text;
                command.Parameters.Add("@image", SqlDbType.VarBinary, -1).Value = imageData;
                command.Parameters.Add("@details", SqlDbType.Text).Value = txtDetails.Text;

                // Open connection, execute command, and close connection
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
        private byte[] GetImageBytes(HttpPostedFile file)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                file.InputStream.CopyTo(ms);
                return ms.ToArray();
            }
        }
    }
}