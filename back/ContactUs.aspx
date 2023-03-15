<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ContactUs.aspx.cs" Inherits="manjam_backend.ContactUs" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
<form id="contactForm" runat="server">
  <div>
    <label for="email">Email:</label>
    <asp:TextBox ID="emailTextBox" runat="server" />
  </div>
  <div>
    <label for="name">Name:</label>
    <asp:TextBox ID="nameTextBox" runat="server" />
  </div>
  <div>
    <label for="address">Address:</label>
    <asp:TextBox ID="addressTextBox" runat="server" />
  </div>
  <div>
    <label for="message">Message:</label>
    <asp:TextBox ID="messageTextBox" TextMode="MultiLine" runat="server" />
  </div>
  <div>
    <asp:Button ID="submitButton" Text="Submit" OnClick="submitButton_Click" runat="server" />
  </div>
</form>


</body>
</html>
