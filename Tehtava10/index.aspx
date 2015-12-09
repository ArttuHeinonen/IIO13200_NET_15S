<%@ Page Language="C#" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Levykauppa X</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:XmlDataSource ID="srcLevyt" DataFile="~/App_Data/LevykauppaX.xml" runat="server" XPath="Records/genre/record"></asp:XmlDataSource>
        <h1>Levykauppa X</h1>
        <asp:Repeater ID="repeater" runat="server" DataSourceID="srcLevyt">
            <HeaderTemplate>
                <table>
            </HeaderTemplate>
            <ItemTemplate>
                <tr>
                    <td>
                        <img alt="Kansikuva" src='<%#"Images/" + Eval("ISBN") + ".jpg"%>' />
                    </td>
                    <td>
                        <h2><%# Eval("Artist") %> : <%# Eval("Title") %></h2>
                        <h3>ISBN: <a href="Record.aspx?ISBN=<%# Eval("ISBN") %>"><%# Eval("ISBN") %></a></h3>
                        <h3>Hinta:</h3> <%# Eval("Price") %>
                    </td>
                    <asp:DataList ID="DataList1" runat="server"></asp:DataList>
            </ItemTemplate>
            <FooterTemplate>
                </tr>
                </table>
            </FooterTemplate>
        </asp:Repeater>
    </div>
    </form>
</body>
</html>
