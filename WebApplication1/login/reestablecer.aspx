<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="reestablecer.aspx.cs" Inherits="WebApplication1.login.WebForm1" %>

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
          <label>Usuario</label>
        <asp:TextBox  runat="server" ID="tusuario"  />
          <label>Contraseña Antigua</label>
        <asp:TextBox  runat="server" ID="tpassantigua"  />
          <label>Nueva Contraseña</label>
        <asp:TextBox  runat="server" ID="tpass2"  />     
          <label>Confirmar  Contraseña</label>
        <asp:TextBox  runat="server" ID="tpass3"  />
        <asp:Label id="l1" Text="" runat="server" />
  
        <asp:Button ID="bcomp" Text="Guardar" runat="server" OnClick="bcomp_click" BackColor="#669900" Font-Bold="True" ForeColor="White" />

    </form>
                </div>
            </div>
</body>
</html>
