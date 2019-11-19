<%@ Page Title="Total Movimientos" Language="C#" MasterPageFile="~/Pages/ConsultasMovimientos.Master" AutoEventWireup="true" CodeBehind="Total_Movimientos.aspx.cs" Inherits="WApp.Pages.Total_Movimientos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Contenido" runat="server">
    <h1>Muestra el total de los movimientos:</h1>
    <p>
        <asp:GridView ID="Grd_TotalMovimientos" runat="server">
        </asp:GridView>
    </p>
    
</asp:Content>
