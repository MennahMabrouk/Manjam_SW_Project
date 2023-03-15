<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddOpp.aspx.cs" Inherits="manjam_backend.AddOpp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    
    
    <form id="form1" runat="server" enctype="multipart/form-data">
        <div>
            <asp:Label runat="server" Text="ID"></asp:Label>
            <asp:TextBox ID="text_id" runat="server"></asp:TextBox><br />
            <asp:Label runat="server" Text="Title"></asp:Label>
            <asp:TextBox ID="text_title" runat="server"></asp:TextBox><br />
            <asp:Label runat="server" Text="fuImage"></asp:Label>
            <asp:FileUpload ID="fuImage" runat="server"></asp:FileUpload><br />
            <asp:Label runat="server" Text="Title"></asp:Label>
            <asp:TextBox ID="txtDetails" TextMode="MultiLine" runat="server"></asp:TextBox>
            <asp:Button runat="server" ID="add" Text="Add" OnClick="add_Click"></asp:Button>
        </div>
    </form>
</body>
</html>
