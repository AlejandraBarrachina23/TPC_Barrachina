<%@ Page Title="Listado Usuarios" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Usuarios.aspx.cs" Inherits="PresentacionWebsForm.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %></h2>
   <div id="form-list-users">

            <asp:GridView ID="dgvUsuarios" runat="server" OnSelectedIndexChanged="dgvUsuarios_SelectedIndexChanged" DataKeyNames="CodigoUsuario,Nombre,Constrasenia,SectorDesignado" 
                CssClass="grid-content" HeaderStyle-CssClass="grid-header" RowStyle-CssClass="rows" EditRowStyle-CssClass ="select-row">
                
                <Columns>
                    <asp:CommandField ButtonType="Image" SelectImageUrl="~/img/arrow.png" ShowSelectButton="True" HeaderText="Selección" />
                </Columns>

<EditRowStyle CssClass="select-row"></EditRowStyle>

<HeaderStyle CssClass="grid-header"></HeaderStyle>

<RowStyle CssClass="rows"></RowStyle>
            </asp:GridView>

        <asp:Label ID="lblAdvertencia" Text="" runat="server" />
        </div>

        <div id="buttons">
            <asp:Button ID="btnAgregar" class="boton"  runat="server" Text="AGREGAR"  OnClick="btnAgregar_Click" />
            <asp:Button ID="btnEliminar" class="boton" runat="server" Text="ELIMINAR" OnClick="btnEliminar_Click" />
            <asp:Button ID="btnModificar" class="boton" runat="server" Text="MODIFICAR" OnClick="btnModificar_Click" /><br />
        </div>

        <div id="form-users">
            <asp:Panel ID="pnlAgregarUsuario" runat="server" Visible="False"><br />
                <asp:Label ID="lblTitulo" Text="Agregar Usuario" runat="server" /><br />
                    <label>Codigo</label><br />
                    <asp:TextBox ID="tboxCodigo" runat="server" OnTextChanged="tboxCodigo_TextChanged" AutoPostBack="true"></asp:TextBox>
                    <br />
                    <label>Nombre</label><br />
                    <asp:TextBox ID="tboxNombre" img="img/checked.png" runat="server"></asp:TextBox><br />
                    <label>Contraseña</label><br />
                    <asp:TextBox ID="tboxContrasenia" runat="server"></asp:TextBox><br />
                    <label>Sector</label><br />
                    <asp:DropDownList ID="DdlSectores" runat="server">
                        <asp:ListItem>Compra</asp:ListItem>
                        <asp:ListItem>Ventas</asp:ListItem>
                        <asp:ListItem>Administración</asp:ListItem>
                        <asp:ListItem>Depósito</asp:ListItem>
                    </asp:DropDownList><br />
                    <asp:Button ID="btnAceptar" class="boton" runat="server" Text="ACEPTAR" OnClientClick="if(!Advertencia()){return false;};" OnClick="btnAceptar_Click"/>
              </asp:Panel>
      </div>
</asp:Content>
