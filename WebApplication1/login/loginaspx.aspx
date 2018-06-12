<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="loginaspx.aspx.cs" Inherits="WebApplication1.login.loginaspx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Registro y Acceso</title>

   <link rel="stylesheet" href="css/style.css">

</head>
<body>
    <div class="login-page">
  <div class="form">
    <form id="f1" runat="server" class="login-form">
        <label>Usuario</label>
        <asp:TextBox runat="server" ID="TextBox1" runat="server"/>      
        
        <label>Password</label>
        <asp:TextBox runat="server" ID="TextBox2" runat="server" />
      <asp:Button ID="b2" Text="Iniciar Sesión" runat="server" OnClick="b2_Click" BackColor="#33CC33" Font-Bold="True" ForeColor="White" />

        <br />
        <asp:Label id="l1" runat="server" ForeColor="Red" />
      <p class="message">¿No Registrado? <a href="./registrar.aspx">Cree una Cuenta</a></p>
        
      <p class="message">¿Olvidó la Contraseña? <a href="./reestablecer.aspx">Reestablecer Contraseña</a></p>
       
    </form>
  </div>
</div>
    
  <script src='http://cdnjs.cloudflare.com/ajax/libs/jquery/2.1.3/jquery.min.js'></script>

  

    <script  src="js/index.js"></script>


</body>
</html>
