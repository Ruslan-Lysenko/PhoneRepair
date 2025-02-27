<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="BreakingControl.ascx.cs" Inherits="PhoneRepair.Controls.BreakingControl" %>

<asp:Label runat="server" ID="lblBreak" style="display: inline-block; width: 150px;">Breaking</asp:Label>
<br />
<asp:CheckBox ID="ckbxButton" runat="server" Text="Button" AutoPostBack="true" />
<br />
<asp:CheckBox ID="ckbxDisplay" runat="server" Text="Display" AutoPostBack="true" />
<br />
<asp:CheckBox ID="ckbxCamera" runat="server" Text="Camera" AutoPostBack="true" />
