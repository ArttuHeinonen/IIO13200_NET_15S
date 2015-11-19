<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DemoEF.aspx.cs" Inherits="DemoEF" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Customers from Viini with EF</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>Viinitasiakkaiden haku Eight-palvelimelta 12.11.2015</h1>
        <asp:Button ID="btnGetAllCustomers" runat="server" Text="Get all customers" OnClick="btnGetAllCustomers_Click" />
        <asp:DropDownList ID="ddlCities" runat="server">
        </asp:DropDownList>
        <asp:Button ID="btnGetCustomersFromCity" runat="server" Text="Hae asiakkaat valitusta kaupungista" OnClick="btnGetCustomersFromCity_Click" />
        <asp:Button ID="btnGetSortedCustomers" runat="server" Text="Hae asiakkaat kaupungittain" OnClick="btnGetSortedCustomers_Click" />
        <asp:HyperLink ID="createNew" runat="server" NavigateUrl="~/DemoEFNewCustomer.aspx">Luo uusi asiakas</asp:HyperLink>
        <br />
        <asp:Label ID="lblMessages" runat="server" Text="..."></asp:Label>
        <div id="tulos" runat="server"/>
        <asp:GridView ID="gvData" runat="server"></asp:GridView>
    </div>
    </form>
</body>
</html>
