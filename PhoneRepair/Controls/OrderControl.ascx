<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="OrderControl.ascx.cs" Inherits="PhoneRepair.Controls.OrderControl" %>
<div style="display: table; margin-bottom: 20px;">
    <div style="display: table-row;">
    <span style="display: table-cell; font-weight: bold;">ID:</span>
    <asp:TextBox ID="lblID" runat="server" style="display: table-cell; width: 100%;" />
    </div>
    <div style="display: table-row;">
        <span style="display: table-cell; font-weight: bold;">Phone Manufacturer:</span>
        <asp:TextBox ID="lblPhoneManufacturer" runat="server" style="display: table-cell; width: 100%;" />
    </div>
    <div style="display: table-row;">
        <span style="display: table-cell; font-weight: bold;">Phone Model:</span>
        <asp:TextBox ID="lblPhoneModel" runat="server" style="display: table-cell; width: 100%;" />
    </div>
    <div style="display: table-row;">
        <span style="display: table-cell; font-weight: bold;">Breaking:</span>
        <asp:TextBox ID="lblBreaking" runat="server" style="display: table-cell; width: 100%;" />
    </div>
    <div style="display: table-row;">
        <span style="display: table-cell; font-weight: bold;">Order Name:</span>
        <asp:TextBox ID="lblOrderName" runat="server" style="display: table-cell; width: 100%;" />
    </div>
    <div style="display: table-row;">
        <span style="display: table-cell; font-weight: bold;">Order Phone:</span>
        <asp:TextBox ID="lblOrderPhone" runat="server" style="display: table-cell; width: 100%;" />
    </div>
    <div style="display: table-row;" id="completionStatusRow">
        <span style="display: table-cell; font-weight: bold;">Completion Status:</span>
        <div id="lblIsCompleted" runat="server" style="display: table-cell; font-weight: bold;"></div>
    </div>
</div>

