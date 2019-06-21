<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListadoUsuarios.aspx.cs" Inherits="PresentacionWebForm.ListadoUsuarios" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="dgvUsuarios" runat="server" OnRowDataBound="dgvUsuarios_RowDataBound" OnSelectedIndexChanged="dgvUsuarios_SelectedIndexChanged">
                <Columns>
                    <asp:CommandField EditText="Seleccionar" ShowSelectButton="True" />
                </Columns>
            </asp:GridView>
        </div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Agregar" />
        <asp:Button ID="Button2" runat="server" Text="Eliminar" />
        <asp:Button ID="Button3" runat="server" Text="Modificar" />
    </form>
</body>
</html>
