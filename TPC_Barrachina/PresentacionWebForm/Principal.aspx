<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Principal.aspx.cs" Inherits="PresentacionWebForm.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
    <style>




    </style>




       <div class="nav">
      <div class="menu">
        <li class="item" id='profile'>
          <a href="#profile" class="btn"><i class="far fa-user"></i>Usuarios</a>
          <div class="smenu">
            <a href="#">Agregar</a>
            <a href="#">Borrar</a>
            <a href="#">Modificar</a>
             <a href="#">Listar</a>
          </div>
        </li>

        <li class="item" id="messages">
          <a href="#messages" class="btn"><i class="far fa-envelope"></i>Informes</a>
          <div class="smenu">
            <a href="#">Compra</a>
            <a href="#">Venta</a>
            <a href="#">Administración</a>
          </div>
        </li>

        <li class="item" id="settings">
          <a href="#settings" class="btn"><i class="fas fa-cog"></i>LogOut</a>
        </li>
      </div>
    </div>


    <section>
        <h1>Bienvenido</h1>
    <p>Lorem Ipsum es simplemente un texto de relleno de la industria de impresión y tipografía. Lorem Ipsum ha sido el texto ficticio estándar de la industria desde la década de 1500, 
        cuando una impresora desconocida tomó una galera de tipos y la mezcló para hacer un libro de muestras tipo. Ha sobrevivido no solo cinco siglos, sino también el salto a la tipografía 
        electrónica, permaneciendo esencialmente sin cambios. Se popularizó en la década de 1960 con el lanzamiento de las hojas de Letraset que contenían pasajes de Lorem Ipsum, y más 
        recientemente con un software de edición de escritorio como Aldus PageMaker, que incluye versiones de Lorem Ipsum.</p>
    <asp:Button Text="btnUsuario" runat="server" />
    <asp:Button Text="btnRegistros" runat="server" />
        </section>
</asp:Content>
