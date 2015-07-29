<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        body
        {
            text-align:center;
        }
        .parrot
        {
            text-align: left;
            margin-left:auto

        }
      </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Font-Bold="True" ForeColor="Blue" Text="Northwind Traders Orders" Font-Size="24pt"></asp:Label>
        <br />
        <br />
        <br class = " parrot" />
        <asp:Label ID="Label3" runat="server" Text="Company Name"></asp:Label>
        <br />
        <asp:Label ID="Label4" runat="server" Text="One or more initial letters"></asp:Label>
        <br />
        <asp:TextBox ID="tbInput" runat="server" TabIndex="1" AutoPostBack="True"></asp:TextBox>
        <asp:DropDownList ID="ddlCustomer" runat="server" DataTextField="CompanyName" DataValueField="CompanyName"
            OnSelectedIndexChanged="ddlCustomer_SelectedIndexChanged" AutoPostBack="True" 
            DataSourceID="SqlDataSource1" Width="67px" AppendDataBoundItems="False">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
            EnableViewState="False" onselecting="SqlDataSource1_Selecting" 
            SelectCommand="SELECT [CompanyName] FROM [Customers] WHERE (([CompanyName] LIKE '%' + @CompanyName2 + '%') AND ([CompanyName] LIKE  @CompanyName + '%')) ORDER BY [CompanyName]">
            <SelectParameters>
                <asp:ControlParameter ControlID="tbInput" DefaultValue="" Name="CompanyName2" 
                    PropertyName="Text" Type="String" />
                <asp:ControlParameter ControlID="tbInput" Name="CompanyName" 
                    PropertyName="Text" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
        <br />
        <br />
        <asp:Label ID="lblMessage" runat="server"></asp:Label>
        <br />
    
    </div>
    </form>
</body>
</html>
