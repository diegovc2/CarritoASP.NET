<%@ Page Language="C#" AutoEventWireup="True" CodeBehind="registrar.aspx.cs" Inherits="WebApplication1.login.registrar" %>

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
        <asp:TextBox runat="server" ID="tusuario" required="true"/>      
        <label>Password</label>
        <asp:TextBox  runat="server" ID="tpass"  required="true" TextMode="Password" />
      <label>RUT</label>
        <asp:TextBox  runat="server" ID="trut"  />
       <label>Nombre Completo</label>
        <asp:TextBox  runat="server" ID="tnombre"  />
  <label>Email</label>
                <asp:TextBox  runat="server" ID="temail"  />

  <label>Dirección</label>
        <asp:TextBox  runat="server" ID="tdirección"  />
          <label>Teléfono</label>
        <asp:TextBox  runat="server" ID="ttelefono"  />
<label>Código Postal</label>
        <asp:TextBox  runat="server" ID="tcodigo"  />

          <br />
        <asp:Label id="l1" Text="" runat="server" />
  
        <asp:Button ID="b3" Text="Registrar" runat="server" OnClick="b2_Click" BackColor="#669900" Font-Bold="True" ForeColor="White" />

    </form>
                </div>
            </div>
</body>
</html>
