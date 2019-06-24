<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InicioSesion.aspx.cs" Inherits="PresentacionWebsForm.InicioSesion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<link href="css/estilos.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <style>
        body {
            background-image: url(img\background-candies.jpg);
        }

    </style>
    <form id="formLogin" runat="server">  
        <div id="login-content-form">
              <h1>INICIAR SESIÓN</h1>
              <label>Usuario</label><br />
              <asp:TextBox ID="tboxNombre" runat="server"></asp:TextBox><br />
              <label>Constraseña</label><br />
              <asp:TextBox ID="tboxContrasenia" runat="server"></asp:TextBox><br />
              <asp:Button ID="btnAceptar" CssClass="btn" runat="server" Text="INICIAR" OnClick="btnAceptar_Click" />
          </div> 
    </form>
</body>
</html>
