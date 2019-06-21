<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PresentacionWebForm._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <style>


        #FormularioLogin{

            width:100%;
            text-align:center;
            left:50%;
            top:50%;

        }

    </style>

      <div id="FormularioLogin">    

          <div>
              <h1>Iniciar Sesión</h1>
              <label>Usuario</label><br />
              <asp:TextBox ID="tboxNombre" runat="server"></asp:TextBox><br />
              <label>Constraseña</label><br />
              <asp:TextBox ID="tboxContrasenia" runat="server"></asp:TextBox><br />
              <asp:Button ID="btnAceptar" runat="server" Text="Iniciar" OnClick="btnAceptar_Click" />
          </div> 

  </div>

</asp:Content>
