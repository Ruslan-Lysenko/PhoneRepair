<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditorOrder.aspx.cs" Inherits="PhoneRepair.Administrator.EditorOrder" %>
<%@ Register TagName="BreakingControl" TagPrefix="phoneLib" Src="~/Controls/BreakingControl.ascx"%>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Order# <%=orderId %></h2>
        <div>
            Phone# <%=PhoneNumber %>
        </div>
        <div>
            <phoneLib:BreakingControl ID="BreakingControl1" runat="server" />
        </div>
        <div>
            <asp:Button ID="btnSave" runat="server" Text="Save" /></div>
    </form>
</body>
</html>
