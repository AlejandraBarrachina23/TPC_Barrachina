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

#formLogin {
    width: 20%;
    height: 500px;
    text-align: center;
    border: solid 1px black;
    margin: 0 auto;
    overflow:hidden;
}

#login-header-form {
    
    width: 100%;
    height: 150px;
    background-image: url('../img/background-candies.jpg');
    background-size: cover;
}

#login-content-form {
    font-family: 'Oswald', sans-serif;
    height: 100%;
    background-color: #F0ECCF;
    text-align:center;
    padding:10px;
}

.btn {
    
    font-family: 'Oswald', sans-serif;
    background-color: #1B7395;
    width: 150px;
    padding: 8px;
    border: 1px solid #1B7395;
    color: white;
}

#tboxNombreUsuario, #tboxContraseniaUsuario {
   
    font-family: 'Oswald', sans-serif;
    width: 200px;
    padding:5px;
    margin: 5px;
    text-align: center;
}

    </style>
    <form id="formLogin" runat="server">  
        <div id="login-content-form">
              <h1>INICIAR SESIÓN</h1>
              <label>Usuario</label><br />
              <asp:TextBox ID="tboxNombreUsuario" runat="server"></asp:TextBox><br />
              <label>Constraseña</label><br />
              <asp:TextBox ID="tboxContraseniaUsuario" runat="server" TextMode="Password"></asp:TextBox><br />
              <asp:Button ID="btnAceptar" CssClass="btn" runat="server" Text="INICIAR" OnClick="btnAceptar_Click" /><br />
            <asp:Label ID="lblAdvertencia" runat="server" Text="Label" Visible="False"></asp:Label>
          </div> 
    </form>
</body>
</html>
