<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Index.aspx.cs" Inherits="Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        
        <h1>Anna palaute</h1>
        <table style="width: 40%;">
            <tr>
                <td>Pvm: </td>
                <td><asp:TextBox ID="TextBoxPvm" TextMode="DateTime" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Nimi: </td>
                <td>
                    <asp:TextBox ID="TextName" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextName" ErrorMessage="Nimi unohtui!" />
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" ValidationExpression="^[A-Za-z\s]{1,}[\.]{0,1}[A-Za-z\s]{0,}$" runat="server" ControlToValidate="TextName" ErrorMessage="Nimi väärin kirjoitettu!"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td>Opintojakso ja ID: </td>
                <td>
                    <asp:TextBox ID="TextCourse" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="TextCourse" ErrorMessage="Nimi unohtui!" />
                </td>
            </tr>
            <tr>
                <td>Olen oppinut: </td>
                <td>
                    <asp:TextBox ID="TextAreaLearned" TextMode="MultiLine" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="TextAreaLearned" runat="server" ErrorMessage="Teksti puuttuu!"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>Haluan oppia: </td>
                <td>
                    <asp:TextBox ID="TextAreaWant" TextMode="MultiLine" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" ControlToValidate="TextAreaWant" runat="server" ErrorMessage="Teksti puuttuu!"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>Hyvää: </td>
                <td>
                    <asp:TextBox ID="TextAreaGood" TextMode="MultiLine" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" ControlToValidate="TextAreaGood" runat="server" ErrorMessage="Teksti puuttuu!"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>Parannettavaa: </td>
                <td>
                    <asp:TextBox ID="TextAreaImprovement" TextMode="MultiLine" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" ControlToValidate="TextAreaImprovement" runat="server" ErrorMessage="Teksti puuttuu!"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>Muuta: </td>
                <td>
                    <asp:TextBox ID="TextAreaOther" TextMode="MultiLine" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" ControlToValidate="TextAreaOther" runat="server" ErrorMessage="Teksti puuttuu!"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td><asp:Button ID="button" runat="server" Text="Lähetä palaute" OnClick="Button_Click" /></td>
            </tr>
        </table>
        <a href="Palautteet.aspx">Näytä palautteet</a>
    </div>
    </form>
</body>
</html>
