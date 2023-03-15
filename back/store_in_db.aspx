protected void submitButton_Click(object sender, EventArgs e)
{
  string email = email.Text;
  string name = name.Text;
  string address = address.Text;
  string message = message.Text;

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
