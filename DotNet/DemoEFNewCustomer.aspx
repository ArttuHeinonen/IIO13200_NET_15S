<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DemoEFNewCustomer.aspx.cs" Inherits="DemoEFNewCustomer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Add new customer</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h3>Asiakkaan tiedot</h3>
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/DemoEF.aspx">Takaisin</asp:HyperLink>
        <table>
            <tr>
                <td>Etunimi</td>
                <td><asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Sukunimi</td>
                <td><asp:TextBox ID="txtLastName" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Osoite</td>
                <td><asp:TextBox ID="txtAddress" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Postinumero</td>
                <td><asp:TextBox ID="txtZIP" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Kaupunki</td>
                <td><asp:TextBox ID="txtCity" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td><asp:Label ID="lblMessage" runat="server" Text="..."></asp:Label></td>
                <td><asp:Button ID="btnCreate" runat="server" Text="Luo uusi" OnClick="btnCreate_Click" /></td>
            </tr>
        </table>
        
    </div>
    </form>
</body>
</html>
