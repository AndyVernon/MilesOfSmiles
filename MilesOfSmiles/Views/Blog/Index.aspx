<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<BlogViewModel>" %>
<%@ Import Namespace="MilesOfSmiles.Models" %>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Miles of Smiles Chester - Blog
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <% foreach (BlogModel item in Model.Blogs.OrderByDescending(o => o.Date)) { %>
        <% if (item.Show) { %>
            <div class="blog_item">
                <h3>
                    <%: item.Date.ToLongDateString() %> <% if (item.Location != null) { %>at <%: item.Location %><% } %>
                </h3>
                <p>
                    <%: item.Details %>
                </p>
                <% if(item.Photos != null && item.Photos.Count > 0) { %>
                    <% foreach (var photo in item.Photos) { %>
                        <img alt="<%: photo.AltText %>" title="<%: photo.TitleText %>" src="http://79.170.44.217/milesofsmileschester.com/Images/blog/<%: photo.ImageSrc %>" />
                    <% } %>
                <% } %>
            </div>
        <% } %>
    <% } %>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ScriptsSection" runat="server">
</asp:Content>
