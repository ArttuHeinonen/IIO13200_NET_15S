<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DemoSQL.aspx.cs" Inherits="DemoSQL" Theme="Simppeli" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>SQLDataSource Demo</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <!-- 1. DataSourcen määrittely -->
        <asp:SqlDataSource ID="srcMuuvit" 
            ConnectionString="<%$ ConnectionStrings:Muuvit %>" 
            SelectCommand="SELECT title, director, year FROM movies"
            runat="server"></asp:SqlDataSource>
        <!-- 2. DataKontrolli data esittämistä varten -->
        <h1>KinnFino ylpeänä esittää</h1>
        <asp:GridView ID="gvMuuvit"
            DataSourceID="srcMuuvit"
            runat="server"></asp:GridView>
        
    </div>
    </form>
</body>
</html>
