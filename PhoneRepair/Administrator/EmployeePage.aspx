<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmployeePage.aspx.cs" Inherits="PhoneRepair.Administrator.EmployeePage" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Employee Management</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>Find Employee</h3>
            <asp:Label ID="lblEmployeeId" runat="server" Text="Enter Employee ID: "></asp:Label>
            <asp:TextBox ID="txtEmployeeId" runat="server"></asp:TextBox>
            <asp:Button ID="btnFindEmployee" runat="server" Text="Find Employee" OnClick="btnFindEmployee_Click" />
            <br /><br />

            <asp:Panel ID="pnlEmployeeDetails" runat="server" Visible="false">
                <h3>Employee Details</h3>
                <asp:Label ID="lblEmployeeName" runat="server" Text="Employee Name: "></asp:Label>
                <asp:TextBox ID="txtEmployeeName" runat="server"></asp:TextBox>
                <br /><br />
                <asp:Button ID="btnUpdateEmployee" runat="server" Text="Update Employee" OnClick="btnUpdateEmployee_Click" />
            </asp:Panel>
        </div>
    </form>
</body>
</html>
