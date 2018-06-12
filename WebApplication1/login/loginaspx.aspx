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
    <form id="f1" class="register-form">
        <label>Name</label>
        <asp:TextBox runat="server" ID="name" runat="server"/>      
        <label>Password</label>
        <asp:TextBox runat="server" ID="password"/>
        <asp:Label Text="email" runat="server" />
        <asp:TextBox runat="server" ID="email" />
        <br />
        <asp:Button ID="b1" Text="Registrar" runat="server" />
        <br />
      <p class="message">Ya Registrado? <a href="#">Inicie Sesión</a></p>
    </form>
    <form id="f2" class="login-form">
      <input type="text" placeholder="username"/>
      <input type="password" placeholder="password"/>
      <button>Acceder</button>
      <p class="message">¿No Registrado? <a href="#">Cree una Cuenta</a></p>
    </form>
  </div>
</div>
    
  <script src='http://cdnjs.cloudflare.com/ajax/libs/jquery/2.1.3/jquery.min.js'></script>

  

    <script  src="js/index.js"></script>


</body>
</html>
