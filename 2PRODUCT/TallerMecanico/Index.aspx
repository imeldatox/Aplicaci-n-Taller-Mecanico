<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="TallerMecanico.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style2 {
            width: 296px;
        }
        .auto-style4 {
            width: 327px;
        }
        .auto-style9 {
            width: 100%;
            height: 149px;
        }
        .auto-style10 {
            width: 296px;
            height: 55px;
        }
        .auto-style11 {
            width: 327px;
            height: 55px;
        }
        .auto-style12 {
            height: 55px;
        }
        .auto-style13 {
            width: 296px;
            height: 47px;
        }
        .auto-style14 {
            width: 327px;
            height: 47px;
        }
        .auto-style15 {
            height: 47px;
        }
        .auto-style16 {
            height: 259px;
        }
        </style>
</head>
<body background ="Imagenes/Fondo1.jpg" background-repeat: no-repeat;>
    <form id="form1" runat="server" class="auto-style16">
    <div>
    
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Italic="True" Font-Names="Aclonica" Font-Overline="False" Font-Size="XX-Large" Font-Strikeout="False" Text="Taller Mecanico" BackColor="White" Height="36px" Width="217px"></asp:Label>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
    
    </div>
        <table class="auto-style9">
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style4">
                    <asp:Label ID="Label2" runat="server" Text="Usuario:" BackColor="White"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    </td>
                <td>
                    <asp:TextBox ID="txtUsuario" runat="server" Width="248px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style10"></td>
                <td class="auto-style11">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <br />
                    <asp:Label ID="Label3" runat="server" Text="Numero de Celular:" BackColor="White"></asp:Label>
&nbsp;&nbsp;
                    </td>
                <td class="auto-style12">
                    <asp:TextBox ID="txtContraseña" runat="server" Width="256px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style13"></td>
                <td class="auto-style14">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="height: 26px" Text="Ingresar" />
                    </td>
                <td class="auto-style15"></td>
            </tr>
        </table>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <p>
            <asp:TextBox ID="TextBox4" runat="server" Width="953px"></asp:TextBox>
        </p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    </form>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        @Taller Mecanico</p>
</body>
</html>
