<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="IndexMP.aspx.cs" Inherits="IndexMP" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
        <asp:Label ID="lblHello" runat="server" Text="..."></asp:Label>
        <h1>To 22.10.2015</h1>
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Default.aspx">Nimi</asp:HyperLink>
        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/Wines.aspx">Viinit</asp:HyperLink>
        <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/DemoxOy.aspx">Maailman viininloppahuulet</asp:HyperLink>
        <h1>To 29.10.2015</h1>
        <asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="~/DemoSQL.aspx">Demo SQLDataSource</asp:HyperLink>
        <asp:HyperLink ID="HyperLink5" runat="server" NavigateUrl="~/DemoXML.aspx">Demo SQLDataSource</asp:HyperLink>
        <h1>To 5.11.2015</h1>
        <asp:HyperLink ID="HyperLink6" runat="server" NavigateUrl="~/IndexMP.aspx">Esimerkki Master Pagesta</asp:HyperLink>
    <br />
    <asp:HyperLink ID="HyperLink7" NavigateUrl="~/TestaaTeema.aspx" runat="server" >Esimerkki tyyleistä</asp:HyperLink>
</asp:Content>
