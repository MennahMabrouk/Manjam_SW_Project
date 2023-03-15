
<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="webProject.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="login.css" />
    <style>

      .form-container {
        background-color: #ccc;
        margin: 0 auto;
        width: 50%;
         padding: 20px;
      }

      button {
        border-radius: 5px;
        background-color: red;
        color: white;
      }

      button:hover {
        background-color: darkred;
       }

      body {
        background-color: #2cccc4;
      }

    /* CSS */
    .button-1 {
      background-color: #EA4C89;
      border-radius: 8px;
      border-style: none;
      box-sizing: border-box;
      color: #FFFFFF;
      cursor: pointer;
      display: inline-block;
      font-family: "Haas Grot Text R Web", "Helvetica Neue", Helvetica, Arial, sans-serif;
      font-size: 14px;
      font-weight: 500;
      height: 40px;
      line-height: 20px;
      list-style: none;
      margin: 0;
      outline: none;
      padding: 10px 16px;
      position: relative;
      text-align: center;
      text-decoration: none;
      transition: color 100ms;
      vertical-align: baseline;
      user-select: none;
      -webkit-user-select: none;
      touch-action: manipulation;
    }

    .button-1:hover,
    .button-1:focus {
      background-color: #F082AC;
    }

    </style>
</head>
<body>
    <header class="header">
        <div class="icon-logo">
            <a href="#">Manjam</a>
        </div>
    </header>
        <div class="form-container">
  
            <form id="form1" runat="server"> 
                <br />
                <h1 class="para">Login</h1> <br />
            <h4 class="para">If you don't have an account <asp:LinkButton runat="server" ID="signup_redirect" OnClick="signup_redirect_Click">SIGNUP</asp:LinkButton></h4> <br />
                <p class="para">Username:<asp:TextBox ID="username" runat="server"></asp:TextBox></p><br />
                <p class="para">Password:<asp:TextBox ID="password" TextMode="Password" runat="server"></asp:TextBox></p> <br />
                <asp:Button runat="server" class="button-1" role="button" ID="button_login" Text="Login" OnClick="Login_Click"></asp:Button><br />
                <asp:Label ID="userNotFound" runat="server"></asp:Label>
        </div>

        <div>
        </div>
    </form>
</body>
</html>
