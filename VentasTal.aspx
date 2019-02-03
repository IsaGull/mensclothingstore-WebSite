<%@ Page Title="" Language="C#" MasterPageFile="~/MasterAdmin.Master" AutoEventWireup="true" CodeBehind="VentasTal.aspx.cs" Inherits="Arbiter.VentasTal" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">


<table>
        
        <tr>

            <td rowspan="3" width="150">
            </td>
        
            <td colspan="2" align="center">

                <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Size="X-Large" 
                    Text="Talla más vendida por tipo prenda"></asp:Label>
      
            </td>
        </tr>

    <tr>
            
        <td align="center" >
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="X-Large" 
                Text="Mes:"></asp:Label>
      
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="DDLMes" runat="server" Height="25px" 
                onselectedindexchanged="DDLMes_SelectedIndexChanged" AutoPostBack="True"></asp:DropDownList>
        </td>
        <td>
         <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="X-Large" 
                Text="Tipo de prenda:"></asp:Label>
      
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="DDLTipo" runat="server" Height="25px"  
                AutoPostBack="True" onselectedindexchanged="DDLTipo_SelectedIndexChanged"></asp:DropDownList>
        </td>

    </tr>
    <tr>
        <td  colspan="2" align="center">
            
            
                        <br />
                        <br />
            
            
                        <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" 
                            GridLines="None" Font-Bold="True" Font-Size="Large" CaptionAlign="Bottom" 
                            HorizontalAlign="Center">
                            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                            <EditRowStyle BackColor="#999999" />
                            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                            <SortedAscendingCellStyle BackColor="#E9E7E2" />
                            <SortedAscendingHeaderStyle BackColor="#506C8C" />
                            <SortedDescendingCellStyle BackColor="#FFFDF8" />
                            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                        </asp:GridView>

        </td>
    </tr>

</table>



</asp:Content>
