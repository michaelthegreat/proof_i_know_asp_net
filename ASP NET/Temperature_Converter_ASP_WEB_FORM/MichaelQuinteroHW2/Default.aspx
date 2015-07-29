<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        body{
           margin:auto
        }
        .auto-style1{

        }
        .auto-style2 {
            width: 103px;
        }
        .auto-style3 {
            width: 122px;
        }

        .auto-style5 {
            width: 103px;
            height: 23px;
        }
        .auto-style6 {
            width: 122px;
            height: 23px;
        }

        .auto-style8 {

            vertical-align: middle;
            text-align: center;
            width: 252px;
        }
        .auto-style18 {
            height: 23px;
            width: 178px;
        }
        .auto-style19 {
            width: 178px;
        }
        .auto-style20 {
            text-align: center;
            width: 252px;
            height: 23px;
        }
        .auto-style22 {
            margin: 0 auto;
            width: 252px;
            height: 67px;
        }
        .auto-style24 {
            width: 103px;
            height: 67px;
        }
        .auto-style25 {
            width: 122px;
            height: 67px;
        }
        .auto-style26 {
            width: 178px;
            height: 67px;
        }
        .auto-style27 {
            width: 311px;
        }
        .auto-style28 {
            height: 23px;
            width: 311px;
        }
        .auto-style29 {
            width: 311px;
            height: 67px;
        }
        .header{
            font-size:xx-large;
            color:red;
        }
    </style>
</head>
<body><center>
    <form id="form1" runat="server">
        <div class ="header">Temperature</div>
      <div class = "header"> Conversion</div>
        <table class="auto-style1" style = " width: 158px;">
             <tr>
                <td class="auto-style28"></td>
                <td class="auto-style5">Farenheit</td>
                <td class="auto-style20">&nbsp;</td>
                <td class="auto-style6">Celsius</td>
                <td class="auto-style18"></td>
            </tr>
            <tr>
                <td class="auto-style29"></td>
                <td class="auto-style24">
    
                    
        <asp:TextBox ID="tFarenheit" runat="server" OnTextChanged="TextBox1_TextChanged" Width="65px"></asp:TextBox>
                </td>
                <td  class= "auto-style22">
               
                             
                    <center>
                              
                                    <div>   <asp:Button ID="ctof" runat="server" Height="26px" OnClick="ctof_Click" Text="&lt;&lt;" BorderColor="#FFCC66" />
                                        </div>
                                
                        <div>
                                <asp:Button ID="ftoc" runat="server" OnClick="ftoc_Click" Text="&gt;&gt;" BorderColor="#FFCC99" />
                            </div>
                                 
                             </center>

                </td>
                <td class="auto-style25">
        <asp:TextBox ID="tCelsius" runat="server" OnTextChanged="TextBox2_TextChanged" Width="65px"></asp:TextBox>

                </td>
                <td class="auto-style26"></td>
            </tr>
            <tr>
                <td class="auto-style27">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style8">
                    <asp:Label ID="error" runat="server" Text=" "></asp:Label>
                </td>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style19">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style27">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style8">
                    <asp:Button ID="clear" runat="server" OnClick="clear_Click" Text="clear" BorderColor="Lime" />
                </td>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style19">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style27">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style8">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style19">&nbsp;</td>
            </tr>
        </table>
    </form>
    </center>
</body>
</html>
