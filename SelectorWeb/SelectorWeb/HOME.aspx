<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HOME.aspx.cs" Inherits="SelectorWeb.HOME" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>
            Localizar Datos
        </h1>
        <div>
            <label>Fecha Inicio:</label>
            <asp:TextBox runat="server" ID="Txt_FechaInicio"></asp:TextBox>
            <br />
            <label>Fecha Final:</label>
            <asp:TextBox runat="server" ID="Txt_FechaFinal"></asp:TextBox>
            <!-- Lista de Radio Buttons -->
            <asp:RadioButtonList ID="Rdb_Indicadores" runat="server">
                <asp:ListItem>US Venta</asp:ListItem>
                <asp:ListItem>US Compra</asp:ListItem>
                <asp:ListItem>Euro</asp:ListItem>
                <asp:ListItem>Yen</asp:ListItem>
                <asp:ListItem>Quetzal</asp:ListItem>
            </asp:RadioButtonList>
            <asp:Button ID="Btn_CargarDatos" runat="server" OnClick="CarcagrDatos_Click" Text="Cargar Datos" />
        </div>
        <br />
        <br />
        <asp:Label ID="Txt_Result" runat="server" Text="Resultado: "></asp:Label>
        <br />
        <asp:GridView ID="GridView1" runat="server"></asp:GridView>
    </form>
</body>
</html>
