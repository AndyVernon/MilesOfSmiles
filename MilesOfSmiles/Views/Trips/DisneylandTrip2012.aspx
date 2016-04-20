<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<List<PhotoItem>>" %>
<%@ Import Namespace="MilesOfSmiles.Models" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Miles of Smiles Chester - Trip Photos
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <% foreach (var item in Model) { %>
        <div style="display: inline-block;">
            <img alt="<%: item.AltText %>" title="<%: item.TitleText %>" src="http://79.170.44.217/milesofsmileschester.com/Images/trips/small/<%: item.ImageSrc %>" />
        </div>
    <% } %>

</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ScriptsSection" runat="server">
</asp:Content>
