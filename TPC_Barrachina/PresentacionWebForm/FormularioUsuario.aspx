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
        <asp:TextBox ID="tboxCodigo" runat="server"></asp:TextBox>
        <br />
                     
        <label>Nombre Usuario:</label>
        <asp:TextBox ID="tboxNombre" runat="server"></asp:TextBox>
        
        <label id="prueba">Contraseña Usuario:</label>
        <input type="Text" name="name" value="" /><br />

        <label>Sector:</label>
        <asp:DropDownList ID="DdlSectores" runat="server"></asp:DropDownList><br />
        
        <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" OnClientClick="if(!Advertencia()){return false;};"/>
    </div>

</asp:Content>
