﻿<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Principal.aspx.cs" Inherits="PresentacionWebsForm._Default" %>

<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <section>
        <asp:Label class="main-title" Text="REDAUDACIÓN HOY" runat="server" />
    <div id="box-containder">
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
         <div class="box-report">
            <asp:Label class="box-main-title" Text="TOTAL GANANCIA CIGARRILLOS" runat="server" /><br /> 
            <img src="img/smoking.png" alt="Alternate Text" />
            <asp:Label ID="lblRecaudacionCigarillos" Text="$20000" runat="server" />
        </div>
         <div class="box-report">
            <asp:Label class="box-main-title" Text="TOTAL GANANCIA VARIOS" runat="server" /><br /> 
            <img src="img/candy-jar.png" alt="Alternate Text" />
            <asp:Label ID="lblRecaudacionVarios" Text="$20000" runat="server" />
        </div>
         <div class="box-report">
            <asp:Label class="box-main-title" Text="TOTAL GANANCIA RECARGAS" runat="server" /><br /> 
            <img src="img/transfer.png" alt="Alternate Text" />
            <asp:Label ID="lblRecaudacionTarjetas" Text="$20000" runat="server" />
        </div>
    </div>
        </section>

    </asp:Content>
