<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<%@ Register src="RX.ascx" tagname="RX" tagprefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <div id="input"> 
        <uc1:RX ID="RX1" runat="server" />
        <asp:Label ID="Label3" runat="server" Text="Rx ID"></asp:Label>
        <br />
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Enter ID of Rx to display: "></asp:Label>
         <asp:TextBox ID="tbRxId" runat="server" Width="82px" Height="20px" 
            MaxLength="3"></asp:TextBox>
        <asp:RangeValidator ID="RangeValidator1" runat="server" 
            ControlToValidate="tbRxId" EnableClientScript="False" 
            ErrorMessage="Rx ID must be in the range from 3 to 74" MaximumValue="74" 
            MinimumValue="3" Type="Integer" ForeColor="Red"></asp:RangeValidator>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
            ControlToValidate="tbRxId" EnableClientScript="False" 
            ErrorMessage="Rx ID is required" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
        <br />
        <asp:Button ID="displayRx" runat="server" Text="Display Rx" 
            onclick="displayRx_Click" Width="119px" />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server"></asp:Label>
        </div>
    </div>
    </form>
</body>
</html>
