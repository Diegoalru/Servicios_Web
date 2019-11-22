<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/ConsultasMovimientos.Master" AutoEventWireup="true" CodeBehind="Borra_Movimiento.aspx.cs" Inherits="WApp.Pages.Borra_Movimiento" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Contenido" runat="server">
    <table>
        <tr>
            <td>
                <asp:Label ID="Lbl_Movimiento" runat="server" Font-Names="Arial" Font-Size="10pt" Text="ID Movimiento"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="Txt_Movimiento" runat="server" TextMode="Number"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2" style="text-align: center;">
                <asp:Label ID="Lbl_Mensaje" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="10pt"></asp:Label>
            </td>
        </tr>
    </table>
    <asp:Button ID="Btn_Borrar" runat="server" Text="Borrar" OnClick="Btn_Borrar_Click" />
</asp:Content>
