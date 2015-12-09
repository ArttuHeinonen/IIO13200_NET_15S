<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Record.aspx.cs" Inherits="Record" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title><%{ Response.Write(Request.QueryString["ISBN"]); }%></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:XmlDataSource ID="srcLevyt" DataFile="~/App_Data/LevykauppaX.xml" runat="server"></asp:XmlDataSource>
        <h1>Levykauppa X</h1>
        <asp:Repeater ID="repeater" runat="server" DataSourceID="srcLevyt">
            <ItemTemplate>
                <img alt="Kansi" src="Images/<%# Eval("ISBN") %>.jpg" />
                <h2><%# Eval("Artist") %> <%# Eval("Title") %></h2>
                <b>ISBN:</b> <%# Eval("ISBN") %><br />
                <b>Hinta:</b> <%# Eval("Price") %><br />
            </ItemTemplate>
        </asp:Repeater>
        <b>Levyn biisit:</b><br />
        <asp:XmlDataSource ID="srcSongs" DataFile="~/App_Data/LevykauppaX.xml" runat="server"></asp:XmlDataSource>
        <asp:Repeater ID="repeaterForSongs" runat="server" DataSourceID="srcSongs">
            
            <ItemTemplate>
                <%# Eval("Name") %><br />
            </ItemTemplate>
        </asp:Repeater>
        <a href="index.aspx">Takaisin</a>
    </div>
    </form>
</body>
</html>
