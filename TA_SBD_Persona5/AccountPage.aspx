<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AccountPage.aspx.cs" Inherits="TA_SBD_Persona5.AccountPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
        <style type="text/css">
            #header {
                background-color: black;
            }

            .auto-style1 {
                width: 500px;
            }

            body, html {
                margin: 0;
            }
        </style>
    </head>
<body runat="server" style="background-color : maroon">
    <form id="form1" runat="server">
        <div id="header">
            <center>
                <h1 style="color: whitesmoke; height: 51px;">Developer Deleted Data</h1>
            </center>
            <a style="color:aliceblue" href ="AdminPage.aspx">Home</a>
        </div>
        <div>
            <table style="background-color:white">
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server"></asp:Label>
                    </td>
                    <td>
                        <asp:Button ID="Logout" runat="server"
                            Text="LOGOUT" OnClick="Logout_Click" />
                    </td>
                </tr>
            </table>
        </div>
        <div>
            <center>
                <h2 style="color : white">User</h2>
                <asp:GridView ID="GridViewUser" runat="server" style="color : white">
                </asp:GridView>
                <h2> </h2>
                <table>
                    <tr>
                        <td style="color : white">Id UserLogin :</td>
                        <td>
                            <asp:TextBox ID="txtUserLogin" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td style="color : white">Password :</td>
                        <td>
                            <asp:TextBox ID="txtpasswd" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td></td>
                        <td>

                            <asp:Button ID="btnPasswordUpdate" runat="server"
                                Text="Update" OnClick="btnPasswordUpdate_Click" />
                            <asp:Button ID="btnAccountDelete" runat="server"
                                Text="Delete" OnClick="btnAccountDelete_Click" />

                        </td>
                    </tr>
                </table>
                <h2> </h2>
            </center>
        </div>
    </form>
</body>
</html>
