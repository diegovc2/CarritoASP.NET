<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="completo.aspx.cs" Inherits="WebApplication1.login.completo" %>

<!DOCTYPE html>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
              <link rel="stylesheet" href="css/style.css"/>

</head>
<body>

        <div class="login-page">
            <div class="form">
    <form id="f2" runat="server" class="login-form">
        
        <asp:Label id="l1" Text="Registro Completo" runat="server" />
  
        <asp:Button ID="bcomp" Text="Volver a Login" runat="server" OnClick="bcomp_click" BackColor="#669900" Font-Bold="True" ForeColor="White" />

    </form>
                </div>
            </div>
</body>
</html>

