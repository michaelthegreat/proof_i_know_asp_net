<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <br />
        <br />
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" 
            DataSourceID="EntityDataSource1" DataTextField="CompanyName" 
            DataValueField="SupplierID" 
            onselectedindexchanged="DropDownList1_SelectedIndexChanged" 
            AppendDataBoundItems="True">
            <asp:ListItem>Select Supplier</asp:ListItem>
        </asp:DropDownList>

        &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblMessage" runat="server" ToolTip="Message here."></asp:Label>

        <asp:EntityDataSource ID="EntityDataSource1" runat="server" 
            ConnectionString="name=NorthwindEntities" 
            DefaultContainerName="NorthwindEntities" EnableFlattening="False" 
            EntitySetName="Suppliers" Select="it.[CompanyName], it.[SupplierID]">
        </asp:EntityDataSource>
    </div>
    </form>
</body>
</html>
