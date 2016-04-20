<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="indexTitle" ContentPlaceHolderID="TitleContent" runat="server">
    Miles of Smiles Chester - Home
</asp:Content>

<asp:Content ID="indexContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="homepage_maincontent">
        <% Html.RenderPartial("_aboutUs"); %>
        <% Html.RenderPartial("_testimonial"); %>
        <% Html.RenderPartial("_homepageimage"); %>
    </div>
</asp:Content>
