<%@ Page Language="C#" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Dotto Netto ohjelmointi</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>To 22.10.2015</h1>
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Default.aspx">Nimi</asp:HyperLink>
        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/Wines.aspx">Viinit</asp:HyperLink>
        <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/DemoxOy.aspx">Maailman viininloppahuulet</asp:HyperLink>
        <h1>To 29.10.2015</h1>
        <asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="~/DemoSQL.aspx">Demo SQLDataSource</asp:HyperLink>
        <asp:HyperLink ID="HyperLink5" runat="server" NavigateUrl="~/DemoXML.aspx">Demo SQLDataSource</asp:HyperLink>
        <h1>To 5.11.2015</h1>
        <asp:HyperLink ID="HyperLink6" runat="server" NavigateUrl="~/IndexMP.aspx">Esimerkki Master Pagesta</asp:HyperLink>
        <h1>To 12.11.2015</h1>
        <asp:HyperLink ID="HyperLink7" runat="server" NavigateUrl="~/DemoEF.aspx">Esimerkki Entity Frameworkista</asp:HyperLink>
    </div>
    </form>
</body>
</html>
