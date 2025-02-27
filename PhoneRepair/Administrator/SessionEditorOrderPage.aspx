<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SessionEditorOrderPage.aspx.cs" Inherits="PhoneRepair.Administrator.SessionEditorOrderPage" %>
<%@ Register TagName="BreakingControl" TagPrefix="phoneLib" Src="~/Controls/BreakingControl.ascx"%>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <%if (!HasError) {  %>
        <h2>Order# <%=orderId %></h2>
        <div>
            Phone# <%=PhoneNumber %>
        </div>
        <div>
            <phoneLib:BreakingControl ID="BreakingControl1" runat="server" />
        </div>
        <div>
            <asp:Button ID="btnSave" runat="server" Text="Save" /></div>
        <%} else {  %>
        <h2>
            <%=ErrorText %>
        </h2>
        <p>
            <%=ErrorDetails %>
        </p>
        <% } %>
    </form>
</body>
</html>
