<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="TA_SBD_Persona5.HomePage" %>

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
<body runat="server" background="https://cutewallpaper.org/21/persona-5-take-your-heart-wallpaper/Take-your-heart-by-Saupernova13-on-DeviantArt.png">
    <form id="form1" runat="server">
        <div id="header">
            <center>
                <h1 style="color: whitesmoke; height: 51px;">Metaverse Navigator</h1>
            </center>
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
                <table>
                    <tr>
                        <td style="color : white">Search Demon :</td>
                        <td>
                            <asp:TextBox ID="txtMomon" runat="server"></asp:TextBox>
                        </td>
                        <td>
                            <asp:Button ID="btnSearch" runat="server"
                                Text="SEARCH" OnClick="btnSearch_Click" />
                        </td>
                    </tr>
                    <tr>
                        <td style="color : white">Sort by :</td>
                        <td>
                            <asp:Button ID="btnSortRace" runat="server"
                                Text="RACE" OnClick="btnSortRace_Click" />

                            <asp:Button ID="btnSortLevel" runat="server"
                                Text="LEVEL" OnClick="btnSortLevel_Click" />

                            <asp:Button ID="btnSortName" runat="server"
                                Text="NAME" OnClick="btnSortName_Click" />

                            <asp:Button ID="btnSortReset" runat="server"
                                Text="RESET" OnClick="btnSortReset_Click" />
                        </td>
                    </tr>
                </table>
                <h2 style="color : white">Persona 5 Royal Demon List</h2>
                <asp:GridView ID="GridViewJoin" runat="server" style="color : white">
                </asp:GridView>
                <h2> </h2>
            </center>
        </div>
    </form>
</body>
</html>
