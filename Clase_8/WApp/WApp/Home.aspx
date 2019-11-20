
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="WApp.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Inicio de sesión</title>
    <style type="text/css">
        * {
            margin: 0;
            padding: 0;
        }

        body, form {
            position: fixed;
            top: 50%;
            left: 50%;
            width: 50%;
            height: 200px;
            margin: -100px 0 0 -25%;
        }

        body{
            background-color: darkslategrey;
        }

        form {
            text-align: center;
            border: solid 1px black;
            border-radius: 10px;
            height: auto;
            background-color: #f1f1f1;
            padding: 2%;
        }

        td{
            width: 100%;
            padding: 3px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" method="post" style="position: absolute;" defaultfocus="Txt_Usuario">
        <%--
        <asp:GridView ID="Grd_Usuarios" runat="server">
        </asp:GridView>
        --%>
        <div>
            <table>
                <tr>
                    <td>
                        Usuario
                    </td>
                    <td>
                        <asp:TextBox ID="Txt_Usuario" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        Clave
                    </td>
                    <td>
                        <asp:TextBox ID="Txt_Clave" runat="server" TextMode="Password"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="2" style="text-align: center;">
                        <asp:Label ID="Lbl_Message" runat="server" Font-Bold="True" Font-Names="Arial"
                            Font-Size="10pt" ForeColor="Red"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td colspan="2" align="center">
                        <asp:Button ID="Btn_Login" runat="server" Text="Ingresar" OnClick="Btn_Login_Click" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
