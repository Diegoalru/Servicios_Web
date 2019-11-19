<%@ Page Title="Ingresa Movimiento" Language="C#" MasterPageFile="~/Pages/ConsultasMovimientos.Master" AutoEventWireup="true" CodeBehind="Ingresa_Movimiento.aspx.cs" Inherits="WApp.Pages.Ingresa_Movimiento" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Contenido" runat="server">
<table>
<tr><td>
<asp:Label ID="lblNombre" runat="server" Font-Names="Arial" Font-Size="10pt"
Text="Nombre"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtNombre" runat="server" Width="205px"></asp:TextBox>
</td>
</tr>
<tr><td>
<asp:Label ID="lblApellido" runat="server" Font-Names="Arial" Font-Size="10pt"
Text="Apellido"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtApellido" runat="server" Width="205px"></asp:TextBox>
</td>
</tr>
<tr><td>
<asp:Label ID="lblEdad" runat="server" Font-Names="Arial" Font-Size="10pt"
Text="Edad"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtEdad" runat="server" Width="40px"></asp:TextBox>
</td>
</tr>
<tr><td>
&amp;nbsp;</td>
<td>
<asp:Label ID="lblMensajes" runat="server" Font-Bold="True" Font-Names="Arial"
Font-Size="10pt" ForeColor="Red"></asp:Label>
</td>
</tr>
</table>
<asp:Button ID="btnGuardar" runat="server"
Text="Guardar" />
<br />
</asp:Content>
