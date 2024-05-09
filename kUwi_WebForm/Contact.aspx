<%@ Page Title="Contact" Language="C#" MasterPageFile="~/KIWAInternal.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="kUwi_WebForm.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main aria-labelledby="title">
        <h2 id="title"><%: Title %></h2>
        <address>
            One Somewhere Way<br />
            Mona<br />
            Kingston 7<br />
            Jamaica<br/>            
            876.000.0100
        </address>

        <address>
            <strong>Support:</strong>   <a href="mailto:Support@example.com">Support@example.com</a><br />
            <strong>Marketing:</strong> <a href="mailto:Marketing@example.com">Marketing@example.com</a>
        </address>
    </main>
</asp:Content>
