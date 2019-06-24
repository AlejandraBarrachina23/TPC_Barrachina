<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Principal.aspx.cs" Inherits="PresentacionWebsForm._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
    <section>
        <h1>Bienvenido</h1>
    <p>Lorem Ipsum es simplemente un texto de relleno de la industria de impresión y tipografía. Lorem Ipsum ha sido el texto ficticio estándar de la industria desde la década de 1500, 
        cuando una impresora desconocida tomó una galera de tipos y la mezcló para hacer un libro de muestras tipo. Ha sobrevivido no solo cinco siglos, sino también el salto a la tipografía 
        electrónica, permaneciendo esencialmente sin cambios. Se popularizó en la década de 1960 con el lanzamiento de las hojas de Letraset que contenían pasajes de Lorem Ipsum, y más 
        recientemente con un software de edición de escritorio como Aldus PageMaker, que incluye versiones de Lorem Ipsum.</p>
    <div class="box-report">
        <asp:Label class="box-main-title" Text="TOTAL RECAUDACIÓN" runat="server" />
        <img src="img/cash.png" alt="Alternate Text" />
        <asp:Label ID="lblRedaudacionNumerico" Text="$20000" runat="server" />
    </div>
    <div class="box-report">
        <div id="panel1"></div>
         <asp:Label class="box-main-title" Text="TOTAL VENTAS" runat="server" />
         <img src="img/credit-card.png" alt="Alternate Text" />
        <asp:Label ID="lblCantidadVentas" Text="$20000" runat="server" />
    </div>
    <div class="box-report">
        <asp:Label class="box-main-title" Text="TOTAL GANANCIA" runat="server" /><br /> 
        <img src="img/folder.png" alt="Alternate Text" />
        <asp:Label ID="lblGananciaNumerica" Text="$20000" runat="server" />
    </div>
        </section>
</asp:Content>
