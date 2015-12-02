<%@ Page Title="" Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPage.master" CodeFile="Village.aspx.cs" Inherits="Village" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table>
        <tr>
            <td><asp:Button ID="gatherFood" runat="server" Text="Gather Food" OnClick="gatherFood_Click"></asp:Button></td>
            <td><asp:Button ID="gatherWood" runat="server" Text="Gather Wood" OnClick="gatherWood_Click"></asp:Button></td>
        </tr>
        <tr>
            <td><asp:Button ID="buyHut" runat="server" Text="Hut - 0" OnClick="buyHut_Click" /></td>
            <td><asp:Button ID="buyOutpost" runat="server" Text="Hunt copse - 0" OnClick="buyOutpost_Click"/></td>
        </tr>
    </table>
</asp:Content>
