<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="contactTitle" ContentPlaceHolderID="TitleContent" runat="server">
    Miles of Smiles Chester - Contact Us
</asp:Content>

<asp:Content ID="contactContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="committee">
        <h2>Miles of Smiles Committee</h2>
        <div class="committee-contact">
        <table class="contacts">
            <tr>
                <td class="name">Sue Thomas</td>
                <td class="position">Chair/Trip co-ordinater</td>
                <td class="phone">07878 221272</td>

            </tr>
            <tr>
                <td></td>
                <td>11 Westbourne Road Chester CH1 5BA</td>
            </tr>
            <tr>
                <td class="name">Gary Horton</td>
                <td class="position">Treasurer</td>
                <td class="phone">07867 887042</td>
            </tr>
            <tr>
                <td></td>
                <td>92 Hillside Road Blacon Chester CH1 5NL</td>
            </tr>
            <tr>
                <td class="name">Ceri Evans</td>
                <td class="position">Committee member</td>
                <td class="phone"></td>
            </tr>
            <tr>
                <td class="name">Monika Nowobilska</td>
                <td class="position">Voluntary Helper</td>
                <td class="phone"></td>
            </tr>
            <tr>
                <td class="name">Sam Newall</td>
                <td class="position">Voluntary Helper</td>
                <td class="phone"></td>
            </tr>
        </table>
        <p>
            Email us at <a href="mailto:milesofsmilesladies@live.co.uk">milesofsmilesladies@live.co.uk</a>
        </p>
    </div>
        <div class="committee-photo">
            <asp:Image ID="Image1" ImageUrl="../../Images/committeeimage_300x200.png" runat="server" />
        </div>
    </div>
</asp:Content>