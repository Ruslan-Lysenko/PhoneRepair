<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="OrderProcessingPage.aspx.cs" Inherits="PhoneRepair.Administrator.OrderProcessingPage" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
 <h3>OrderProcessing</h3>
<asp:Panel runat="server" ID="ManagePanel">
    <p>Add a new entry</p>
    <br />
    <asp:Label runat="server" ID="lblEnterOrderId" style="display: inline-block; width: 150px;">Enter OrderId</asp:Label>
    <asp:TextBox runat="server" ID="txtOrderId"></asp:TextBox>
    <br />
    <asp:Label runat="server" ID="lblEmployeeId" style="display: inline-block; width: 150px;">Enter EmployeeId</asp:Label>
    <asp:TextBox runat="server" ID="txtEmployeeId"></asp:TextBox>
    <br />
    <asp:Button id="btnSubmit" runat="server" Text="Creat"></asp:Button>
    <br />
    
</asp:Panel>
<asp:Panel ID="pnlIsCompleted" runat="server">
    <h3>Update status.</h3>
    <br />
    <asp:Label runat="server" ID="lblOrderProcessingID" style="display: inline-block; width: 150px;">Enter OrderProcessingId</asp:Label>
    <asp:TextBox runat="server" ID="OrderProcessingID"></asp:TextBox>
    <asp:CheckBox ID="chkIsCompleted" runat="server" />
    <asp:Button id="ButtonIsCompleted" runat="server" Text="Creat"></asp:Button>
   
</asp:Panel>
</asp:Content>
