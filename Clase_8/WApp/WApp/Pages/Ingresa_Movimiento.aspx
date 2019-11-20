<%@ Page Title="Ingresa Movimiento" Language="C#" MasterPageFile="~/Pages/ConsultasMovimientos.Master" AutoEventWireup="true" CodeBehind="Ingresa_Movimiento.aspx.cs" Inherits="WApp.Pages.Ingresa_Movimiento" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Contenido" runat="server">
    <table>
        <tr>
            <td>
                <asp:Label ID="Lbl_Cuenta" runat="server" Font-Names="Arial" Font-Size="10pt" Text="ID Cuenta"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="Txt_Cuenta" runat="server" TextMode="Number"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Lbl_Movimiento" runat="server" Font-Names="Arial" Font-Size="10pt" Text="ID Movimiento"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="Txt_Movimiento" runat="server" TextMode="Number"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Lbl_Monto" runat="server" Font-Names="Arial" Font-Size="10pt" Text="Monto"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="Txt_Monto" runat="server" TextMode="Number"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2" style="text-align: center;">
                <asp:Label ID="Lbl_Mensaje" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="10pt" ForeColor="Red"></asp:Label>
            </td>
        </tr>
    </table>
    <asp:Button ID="Btn_Insertar" runat="server" Text="Insertar" OnClick="Btn_Insertar_Click" />
    <br />
</asp:Content>
