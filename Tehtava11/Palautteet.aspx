<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Palautteet.aspx.cs" Inherits="Palautteet" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Palautteet</h1>
        <asp:GridView ID="gv" runat="server" AutoGenerateColumns="true" ></asp:GridView>
        <a href="Index.aspx">Takaisin</a>
    </div>
    </form>
</body>
</html>
