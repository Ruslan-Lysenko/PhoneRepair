<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PhoneRepair._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Button ID="btnAdmin" runat="server" Text="Admin" PostBackUrl="~/Administrator/OrdersPage.aspx" />
    <h1>Phone Repair</h1>
    <br />
    <h3>We will save your phone</h3>
    <br />
    <asp:Panel runat="server" ID="frstPanel">
    <asp:CheckBox id="CheckBox1" runat="server" Text="Fill out an application?" AutoPostBack="true" />
    </asp:Panel>
    <asp:Panel Visible="false" runat="server" ID="pnlOrder">
        <br />
        <p>Enter your phone information and your phone number</p>
        <br />
        <asp:Label runat="server" ID="lblPhMan" style="display: inline-block; width: 150px;">Phone Manufacturer</asp:Label>
        <asp:TextBox runat="server" ID="txtManufacturer"></asp:TextBox>
        <br />
        <br />
        <asp:Label runat="server" ID="lblColor" style="display: inline-block; width: 150px;">Color</asp:Label>
        <asp:TextBox runat="server" ID="txtColor"></asp:TextBox>
        <br />
        <br />
        <asp:Label runat="server" ID="lblPhMod" style="display: inline-block; width: 150px;">Phone Model</asp:Label>
        <asp:TextBox runat="server" ID="txtModel"></asp:TextBox>
        <br />
        <br />
        <asp:Label runat="server" ID="lblBreak" style="display: inline-block; width: 150px;">Breaking</asp:Label>
        <asp:TextBox runat="server" ID="txtBreaking"></asp:TextBox>
        <br />
        <br />
        <asp:Label runat="server" ID="lblYourName" style="display: inline-block; width: 150px;">Your Name</asp:Label>
        <asp:TextBox runat="server" ID="txtName"></asp:TextBox>
        <br />
        <br />
         <asp:Label runat="server" ID="lblPhNumber" style="display: inline-block; width: 150px;">Your phone number</asp:Label>
         <asp:TextBox runat="server" ID="txtNumber" style="display: inline-block; width: 150px;"></asp:TextBox>
         <br />

        <asp:Button id="btnSubmit" runat="server" Text="Send"></asp:Button>
    </asp:Panel>
    <asp:Panel Visible="false" ID="pnlOrderCreated" runat="server">
        <h2>Thank you for submitting your application, <%=LastOrderName %>.</h2>
        <h2>We will call you back on this phone number <%=LastOrderNumber %>.</h2>
    </asp:Panel>
</asp:Content>
