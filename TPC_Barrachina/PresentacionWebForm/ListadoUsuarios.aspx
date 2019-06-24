<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListadoUsuarios.aspx.cs" Inherits="PresentacionWebForm.ListadoUsuarios" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>

    <script>
        function Ocultar() {

            document.getElementById("AgregarUsuario").style.display = "block";
            return false;
        }

    </script>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="dgvUsuarios" runat="server" OnRowDataBound="dgvUsuarios_RowDataBound" OnSelectedIndexChanged="dgvUsuarios_SelectedIndexChanged" OnSelectedIndexChanging="dgvUsuarios_SelectedIndexChanging" CellPadding="4" DataKeyNames="CodigoUsuario,Nombre,Constrasenia,SectorDesignado" ForeColor="#333333" GridLines="None" Width="340px">
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                <Columns>
                    <asp:CommandField ButtonType="Image" SelectImageUrl="~/img/click.png" ShowSelectButton="True" />
                </Columns>
                <EditRowStyle BackColor="#999999" />
                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#E9E7E2" />
                <SortedAscendingHeaderStyle BackColor="#506C8C" />
                <SortedDescendingCellStyle BackColor="#FFFDF8" />
                <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
            </asp:GridView>
        </div>
        <asp:Button ID="btnAgregar" runat="server" Text="Agregar"  OnClick="btnAgregar_Click" />
        <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" OnClick="btnEliminar_Click" />
        <asp:Button ID="btnModificar" runat="server" Text="Modificar" OnClick="btnModificar_Click" />
        <asp:Label ID="lblAdvertencia" Text="text" runat="server" />
       
        <asp:Panel ID="pnlAgregarUsuario" runat="server" Visible="False">
            <asp:Label ID="lblTitulo" Text="Agregar Usuario" runat="server" /><br />
                <label>Codigo:</label>
                <asp:TextBox ID="tboxCodigo" runat="server"></asp:TextBox>
                <br />
                     
                <label>Nombre Usuario:</label>
                <asp:TextBox ID="tboxNombre" runat="server"></asp:TextBox>
        
                <label id="prueba">Contraseña Usuario:</label>
                <asp:TextBox ID="tboxContrasenia" runat="server"></asp:TextBox>
                <asp:Panel ID="Panel1" runat="server"></asp:Panel>
                <label>Sector:</label>
                <asp:DropDownList ID="DdlSectores" runat="server">
                    <asp:ListItem>Compra</asp:ListItem>
                    <asp:ListItem>Ventas</asp:ListItem>
                    <asp:ListItem>Administración</asp:ListItem>
                    <asp:ListItem>Depósito</asp:ListItem>
                </asp:DropDownList><br />
        
                <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" OnClientClick="if(!Advertencia()){return false;};" OnClick="btnAceptar_Click"/>
          </asp:Panel>
      
    </form>
</body>
</html>
