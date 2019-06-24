<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FormularioUsuario.aspx.cs" Inherits="PresentacionWebForm.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
    <style>

        .FormularioUsuario {
            width:50%;

        }

    </style>

    <h1>Agregar Usuario</h1>
    <div class ="FormularioUsuario">
        <label>Codigo:</label>
        <asp:TextBox ID="tboxCodigo" runat="server" AutoPostBack="true" OnTextChanged="tboxCodigo_TextChanged"></asp:TextBox>
        <asp:Label ID="lblCodigo" runat="server" ForeColor="Red" Visible="False" />
        <br />   
        <label>Nombre Usuario:</label>
        <asp:TextBox ID="tboxNombre" runat="server"></asp:TextBox>
        
        <label id="prueba">Contraseña Usuario:</label>
        <asp:TextBox ID="tboxConstrasenia" runat="server"></asp:TextBox>

        <label>Sector:</label>
        <asp:DropDownList ID="DdlSectores" runat="server">
            <asp:ListItem>Compras</asp:ListItem>
            <asp:ListItem>Ventas</asp:ListItem>
            <asp:ListItem>Administración</asp:ListItem>
            <asp:ListItem>Depósito</asp:ListItem>
        </asp:DropDownList><br />
        
        <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" OnClientClick="if(!Advertencia()){return false;};"/>
    </div>

</asp:Content>
