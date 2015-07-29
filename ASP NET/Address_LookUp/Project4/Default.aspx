<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" 
 %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        table
        {

        }

        table.address
        {
            border: solid 1px
        }
       
        td
        {
            padding: 5px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <br />
        <div id = "pnlLastLetter">
    
           

            
    
           

            <asp:Panel ID="Panel1" runat="server">
            </asp:Panel>
    
           

            
    
           

        </div>
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;
        <table>
            <tr>
                <td>

                    <asp:DropDownList ID="ddlNames" runat="server" OnSelectedIndexChanged="ddlNames_SelectedIndexChanged" AutoPostBack="True" Width="140px">
                        
                    </asp:DropDownList>

                </td>
                <td>
                    <table class ="address">
                        <tr>
                            <td> <span ID="lblMessage" runat="server" aria-multiline="True" contenteditable="true"></span>
                                
                            </td>
                        </tr>
                    </table>
                 </td>
            </tr>
        </table>
        </div>
    </form>
</body>
</html>
