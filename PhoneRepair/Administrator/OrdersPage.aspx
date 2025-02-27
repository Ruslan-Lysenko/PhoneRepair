<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OrdersPage.aspx.cs" Inherits="PhoneRepair.Administrator.OrdersPage" EnableEventValidation="false" %>
<%@ Register TagName="OrderControl" TagPrefix="phoneLib" Src="~/Controls/OrderControl.ascx"%>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>OrdersPage</title>
</head>
<body>
    <h1>Orders</h1>
    
    <form id="form1" runat="server">
        <div>
            <asp:Repeater ID="rptOrders" runat="server">
                <ItemTemplate>
                    <phoneLib:OrderControl ID="orderEditor" runat="server" />
                    <asp:Button ID="btnChangeOrder" runat="server" Text="Change" OnClick="Change_Order_Click" />
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </form>
</body>
</html>
