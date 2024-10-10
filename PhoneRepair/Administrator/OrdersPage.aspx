<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OrdersPage.aspx.cs" Inherits="PhoneRepair.Administrator.OrdersPage" %>
<%@ Register TagName="OrderControl" TagPrefix="phlb" Src="../Controls/OrderControl.ascx" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <h1>List Orders</h1>
    <form id="form1" runat="server">
        <div>
           <asp:Repeater ID="rptOrders" runat="server">
               <ItemTemplate>
                  <phlb:OrderControl ID="orderEd" runat="server" />
                   <p>Order Name: <%# Eval("LastOrderName") %></p>
                  <p>Order Number: <%# Eval("LastOrderNumber") %></p>
               </ItemTemplate>
           </asp:Repeater>
        </div>
    </form>
</body>
</html>

