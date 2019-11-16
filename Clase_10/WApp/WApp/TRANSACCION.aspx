<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TRANSACCION.aspx.cs" Inherits="WApp.TRANSACCION" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            INCLUIR TRANSACCIÓN<br />
            <br />
            Cuenta&nbsp;
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            Movimiento&nbsp;
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            Monto&nbsp;
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text=" Salir " />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Aceptar" />
            <br />
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
