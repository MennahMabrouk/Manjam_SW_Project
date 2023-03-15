<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Signup.aspx.cs" Inherits="webProject.Signup" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="login.css" rel="stylesheet" />
</head>
<body>
    <header class="header">
        <div class="icon-logo">
            <a href="#">Manjam</a>
        </div>
    </header>
    <br />
    <form id="form1" runat="server">
         <br />
         <h1 class="para">Sign Up</h1> <br />
        <h4 class="para">If you already have an account <asp:LinkButton runat="server" ID="login_redirect" OnClick="login_redirect_Click">LOGIN</asp:LinkButton></h4> <br />
    <p class="para">Username:<asp:TextBox runat="server" ID="usernamee"></asp:TextBox></p><asp:Label ID="errorLabel1" runat="server"></asp:Label> <br />
    <p class="para">Password:<asp:TextBox runat="server" ID="passwordd" TextMode="Password"></asp:TextBox></p><asp:Label ID="errorLabel2" runat="server"></asp:Label> <br />
    <p class="para">Re-Enter Password:<asp:TextBox runat="server" ID="repeatt" TextMode="Password"></asp:TextBox></p><br /><asp:Label ID="errorLabel3" runat="server"></asp:Label> <br />
        <asp:Button runat="server" ID="button_signup" Text="Signup" OnClick="Signup_Click"></asp:Button> <br />

        <div>
        </div>
    </form>
</body>
</html>
