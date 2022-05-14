<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="TA_SBD_Persona5.LoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body background="https://wallpaperaccess.com/full/3720574.jpg">
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td style="color: white">Username :</td>
                    <td>
                        <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="color: white">Password :</td>
                    <td>
                        <asp:TextBox ID="txtPassword" TextMode="Password" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td>

                        <asp:Button ID="Login" runat="server"
                            Text="LOGIN" OnClick="Login_Click" />

                    </td>
                    <td>  
                        <asp:Label ID="Label1" runat="server"></asp:Label>  
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
