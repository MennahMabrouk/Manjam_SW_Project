<%@ Page Language="C#" AutoEventWireup="true" CodeFile="EditAccount.aspx.cs" Inherits="manjam_backend.EditAccount" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <title>Edit Account</title>
</head>
<body>
  <form id="form1" runat="server">
    <div>
      <asp:Button ID="deleteButton" runat="server" Text="Delete Account" OnClick="deleteButton_Click" />
      <asp:Button ID="updateButton" runat="server" Text="Update Account" OnClick="updateButton_Click" />
    </div>
  </form>
</body>
</html>
