<%@ Control Language="C#" AutoEventWireup="true" CodeFile="RX.ascx.cs" Inherits="RX" %>

<table border = "0" cellpadding = "5" id="RX_Display_Table" style = "background-color: LightYellow ;border-color:Black;border-width:1px;border-style:Solid;border-collapse: collapse;">
<tr style = "border-color:Black;border-width:1px;border-style:Solid;text-align:center;">
<td style = "border: solid 1px; padding: 5px;">
.
</td>
<td style = "border: solid 1px; padding: 5px;">
Sphere
</td>
<td style = "border: solid 1px; padding: 5px;">
Cyl
</td>
<td style = "border: solid 1px; padding: 5px;">
Axis
</td>
<td style = "border: solid 1px; padding: 5px;">
Prism
</td>
<td style = "border: solid 1px; padding: 5px;">
Base
</td>
<td style = "border: solid 1px; padding: 5px;">
Add
</td>
<td style = "border: solid 1px; padding: 5px;">
Seg
</td>
<td style = "border: solid 1px; padding: 5px;">
PD
</td>
<td style = "border: solid 1px; padding: 5px;">
NPD
</td>
</tr>

<tr>
<td style = "border: solid 1px; padding: 5px;">
OD
</td>
<td id = "Rx_Display_RSphere" style = "border: solid 1px; padding: 5px;">

<%=Rx_rSphere %>

</td>
<td id = "Rx_Display_RCylinder" style = "border: solid 1px; padding: 5px;">

<%=Rx_rCylinder %>

</td>
<td id = "Rx_Display_RAxis"  style = "border: solid 1px; padding: 5px;">

<%=Rx_rAxis %>

</td>
<td id = "Rx_Display_RPrism" style = "border: solid 1px; padding: 5px;">

<%=Rx_rPrism %>

</td>
<td id = "Rx_Display_RBase" style = "border: solid 1px; padding: 5px;">

<%=Rx_rBase %>

</td>
<td id = "Rx_Display_RAdd" style = "border: solid 1px; padding: 5px;">

<%=Rx_rAdd %>

</td>
<td id = "Rx_Display_RSeg" style = "border: solid 1px; padding: 5px;">

<%=Rx_rSeg %>

</td>
<td id = "Rx_Display_RPD" style = "border: solid 1px; padding: 5px;">

<%=Rx_rPD %>

</td>
<td id = "Rx_Display_RNPD" style = "border: solid 1px; padding: 5px;">

<%=Rx_rNPD %>

</td>

</tr>
<tr>
<td>
OS
</td>

<td id = "Rx_Display_LSphere" style = "border: solid 1px; padding: 5px;">

<%=Rx_lSphere %>

</td>
<td id = "Rx_Display_LCylinder" style = "border: solid 1px; padding: 5px;">

<%=Rx_lCylinder%>

</td>
<td id = "Rx_Display_LAxis" style = "border: solid 1px; padding: 5px;">

<%=Rx_lAxis%>

</td>
<td id = "Rx_Display_Lprism" style = "border: solid 1px; padding: 5px;">

<%=Rx_lPrism%>

</td>
<td id = "Rx_Display_LBase" style = "border: solid 1px; padding: 5px;">

<%=Rx_lBase%>

</td>
<td id = "Rx_Display_LAdd" style = "border: solid 1px; padding: 5px;">

<%=Rx_lAdd%>

</td>
<td id = "Rx_Display_LSeg" style = "border: solid 1px; padding: 5px;">

<%=Rx_lSeg%>

</td>
<td id = "Rx_Display_LPD" style = "border: solid 1px; padding: 5px;">

<%=Rx_lPD%>

</td>
<td id = "Rx_Display_LNPD" style = "border: solid 1px; padding: 5px;">

<%=Rx_lNPD%>

</td>
</tr>
</table>