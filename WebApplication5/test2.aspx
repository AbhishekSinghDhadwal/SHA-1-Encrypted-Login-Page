<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="test2.aspx.cs" Inherits="WebApplication5.test2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-left: 280px;
        }
        .auto-style2 {
            margin-left: 360px;
        }
        .auto-style3 {
            width: 184px;
        }
        .auto-style4 {
            width: 202px;
        }
        .auto-style5 {
            width: 65%;
        }
        .auto-style6 {
            margin-left: 36px;
        }
    </style>
</head>
<body style="height: 45px">
    <form id="form1" runat="server">
        <div>
            <p class="auto-style1" style="font-family: 'Century Gothic'; font-size: xx-large; font-weight: 700; text-transform: capitalize;">
                Alliance Industries</p>
        </div>
        <p class="auto-style2">
            Login</p>
        <table class="auto-style5">
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style4">User ID:</td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server" Width="199px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style4">Password:</td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server" Width="197px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style4">
                    <asp:Label ID="Label1" runat="server" Text="Waiting for Input"></asp:Label>
                </td>
                <td>
                    <asp:Button ID="Button1" runat="server" CssClass="auto-style6" OnClick="Button1_Click" Text="Enter" Width="150px" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
