<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<dynamic>" %>
<div class="homepage_third">
    <h3>About Us</h3>
    <p>
        How it all began: In 1991 a Chester Chronicle employee who had been involved with various fundraising events for many 
        different charities decided to set up a charity that would enable children with a terminal illness, sickness of disability 
        to have the 'Holiday of a Lifetime' ...<%: Html.ActionLink("read more..", "AboutUs", "Home") %>
    </p>
    
</div>

