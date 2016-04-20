<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<EventViewModel>" %>
<%@ Import Namespace="MilesOfSmiles.Models" %>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Miles of Smiles Chester - Forthcoming Events
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Forthcoming Events</h2>
    <table class="forthcoming-events">
        <thead>
            <tr>
                <th class="title">Title</th>
                <th class="date">Date</th>
                <th class="details">Details</th>
                <th></th>
            </tr>
        </thead>
        <tbody>
            <% foreach (EventModel item in Model.FutureEvents.OrderBy(x => x.EventDate)) { %>
                <tr>
                    <td class="title"><%: item.EventTitle %></td>
                    <td class="date">
                        <% if (item.EventDate.HasValue) { %>
                            <%: item.EventDate.Value.ToLongDateString() %></td>
                        <% } else { %>
                            Date TBC
                        <% } %>
                    <td class="details"><%: item.EventDetails %></td>
                    <td class="facebook-link">
                        <% if (!String.IsNullOrEmpty(item.FacebookLink)) { %>
                            <%: item.FacebookLink %>
                        <% } %>
                    </td>
                </tr>
            <% } %>

        </tbody>
            
    </table>

</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ScriptsSection" runat="server">
</asp:Content>
