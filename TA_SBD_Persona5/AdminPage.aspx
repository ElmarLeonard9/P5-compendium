<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminPage.aspx.cs" Inherits="TA_SBD_Persona5.AdminPage" %>

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
                <h1 style="color: whitesmoke; height: 51px;">Developer Data</h1>
            </center>
            <a style="color:aliceblue" href ="DeletePage.aspx">Deleted</a>
            <a style="color:aliceblue" href ="AccountPage.aspx">Account</a>
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
                <h2 style="color : white">Demon Table</h2>
                <asp:GridView ID="GridViewDemon" runat="server" style="color : white">
                </asp:GridView>
                <h2 style="color : white">Stat Table</h2>
                <asp:GridView ID="GridViewStat" runat="server" style="color : white">
                </asp:GridView>
                <h2 style="color : white">Res Table</h2>
                <asp:GridView ID="GridViewRes" runat="server" style="color : white">
                </asp:GridView>
                <h2> </h2>
            </center>
        </div>
        <center>
            <table style="background-color: dimgray">
                <tr>
                    <td>
                        <div class="auto-style1" style="background-color: dimgray">
                            <center>
                                <h2>Demon Table Control</h2>
                                <table style="background-color: dimgray">
                                    <tr>
                                        <td>Id_Demon :</td>
                                        <td>
                                            <asp:TextBox ID="txtIdDemon" runat="server"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>Race :</td>
                                        <td>
                                            <asp:TextBox ID="txtRace" runat="server"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>Level :</td>
                                        <td>
                                            <asp:TextBox ID="txtLvl" runat="server"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>Demon Name :</td>
                                        <td>
                                            <asp:TextBox ID="txtNama" runat="server"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>Id_Stat :</td>
                                        <td>
                                            <asp:TextBox ID="txtIdStat" runat="server"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>Id_Resistance :</td>
                                        <td>
                                            <asp:TextBox ID="txtIdRes" runat="server"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td></td>
                                        <td>

                                            <asp:Button ID="btnAdd" runat="server"
                                                Text="ADD" OnClick="btnAddDemon_Click" />

                                            <asp:Button ID="btnDelete" runat="server"
                                                Text="DELETE" OnClick="btnDeleteDemon_Click" />

                                            <asp:Button ID="btnUpdate" runat="server"
                                                Text="UPDATE" OnClick="btnUpdateDemon_Click" />

                                        </td>
                                    </tr>
                                </table>
                            </center>
                        </div>
                    </td>
                    <td>
                        <div class="auto-style1" style="background-color: dimgray">
                            <center>
                                <h2>Stat Table Control</h2>
                                <table style="background-color: dimgray">
                                    <tr>
                                        <td>Id_Stat :</td>
                                        <td>
                                            <asp:TextBox ID="txtIdStats" runat="server"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>St :</td>
                                        <td>
                                            <asp:TextBox ID="txtSt" runat="server"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>Ma :</td>
                                        <td>
                                            <asp:TextBox ID="txtMa" runat="server"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>En :</td>
                                        <td>
                                            <asp:TextBox ID="txtEn" runat="server"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>Ag :</td>
                                        <td>
                                            <asp:TextBox ID="txtAg" runat="server"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>Lu :</td>
                                        <td>
                                            <asp:TextBox ID="txtLu" runat="server"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td></td>
                                        <td>

                                            <asp:Button ID="btnAddStat" runat="server"
                                                Text="ADD" OnClick="btnAddStat_Click" />

                                            <asp:Button ID="btnDeleteStat" runat="server"
                                                Text="DELETE" OnClick="btnDeleteStat_Click" />

                                            <asp:Button ID="btnUpdateStat" runat="server"
                                                Text="UPDATE" OnClick="btnUpdateStat_Click" />

                                        </td>
                                    </tr>
                                </table>
                            </center>
                        </div>
                    </td>
                    <td>
                        <div class="auto-style1" style="background-color: dimgray">
                            <center>
                                <h2>Resistance Table Control</h2>
                                <table style="background-color: dimgray">
                                    <tr>
                                        <td>Id_Resistance :</td>
                                        <td>
                                            <asp:TextBox ID="txtIdResist" runat="server"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>Phys :</td>
                                        <td>
                                            <asp:TextBox ID="txtPhys" runat="server"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>Gun :</td>
                                        <td>
                                            <asp:TextBox ID="txtGun" runat="server"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>Fire :</td>
                                        <td>
                                            <asp:TextBox ID="txtFire" runat="server"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>Ice :</td>
                                        <td>
                                            <asp:TextBox ID="txtIce" runat="server"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>Elec :</td>
                                        <td>
                                            <asp:TextBox ID="txtElec" runat="server"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>Wind :</td>
                                        <td>
                                            <asp:TextBox ID="txtWind" runat="server"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>Psy :</td>
                                        <td>
                                            <asp:TextBox ID="txtPsy" runat="server"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>Nuclear :</td>
                                        <td>
                                            <asp:TextBox ID="txtNuclear" runat="server"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>Bless :</td>
                                        <td>
                                            <asp:TextBox ID="txtBless" runat="server"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>Curse :</td>
                                        <td>
                                            <asp:TextBox ID="txtCurse" runat="server"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td></td>
                                        <td>

                                            <asp:Button ID="btnAddRes" runat="server"
                                                Text="ADD" OnClick="btnAddRes_Click" />

                                            <asp:Button ID="btnDeleteRes" runat="server"
                                                Text="DELETE" OnClick="btnDeleteRes_Click" />

                                            <asp:Button ID="btnUpdateRes" runat="server"
                                                Text="UPDATE" OnClick="btnUpdateRes_Click" />

                                        </td>
                                    </tr>
                                </table>
                            </center>
                        </div>
                    </td>
                </tr>
            </table>
        </center>
    </form>
</body>
</html>

