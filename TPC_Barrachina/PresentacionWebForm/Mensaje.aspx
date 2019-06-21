<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Mensaje.aspx.cs" Inherits="PresentacionWebForm.Mensaje" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
            <div class="mensaje">
            <asp:Label ID="lblMensajeError" class="texto" runat="server" Text="MensajeError"></asp:Label>
            <asp:Label ID="lblRedireccion" runat="server" Text="SERAS REDICCIONADOR AL INICIO."></asp:Label>
        </div>
    </form>
</body>
</html>
