<%@ Page Title="" Language="C#" MasterPageFile="~/MasterAdmin.Master" AutoEventWireup="true" CodeBehind="ProductoDel.aspx.cs" Inherits="Arbiter.ProductoDel" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

<table>
    <tr>
        <td colspan="3" height="50" align="center">
            <asp:Label ID="LEliPro" runat="server" Text="Eliminar Producto" Font-Bold="True" Font-Size="X-Large"></asp:Label>
        </td>
    </tr>
    <tr>
        <td colspan="3" height="20" align="left">
            <asp:Label ID="Lmsj" runat="server" Font-Bold="True" ForeColor="Red" ></asp:Label>
        </td>
    </tr>
    
    <tr>
        <td height="50" width="100" align="center" >
            <asp:Label ID="Lcodigo" runat="server" Text="Código:" Font-Bold="True"></asp:Label>
        </td>
        <td height="50" width="200" align="center">
            <asp:TextBox ID="TBcodigo" runat="server"></asp:TextBox>
        </td>
        <td height="50" width="300" align="left">
            <asp:Button ID="BBuscar" runat="server" Text="Buscar" onclick="BBuscar_Click" />
        </td>
    </tr>

    <tr>
        <td height="50" width="100" align="center" >
            <asp:Label ID="LTipoS" runat="server" Text="Tipo:" Font-Bold="True"></asp:Label>
        </td>
        <td height="50" width="200" align="center">
            <asp:Label ID="LTipo" runat="server" Text=""></asp:Label>
        </td>
        <td height="50" align="center">
            <asp:Label ID="LImagen" runat="server" Text="Imagen:" Font-Bold="True"></asp:Label>
        </td>
    </tr>
    <tr>
        <td height="50" align="center">
            <asp:Label ID="LMarcaS" runat="server" Text="Marca:" Font-Bold="True"></asp:Label>
        </td>
        <td height="50" align="center">
            <asp:Label ID="LMarca" runat="server" Text=""></asp:Label>
        </td>
        <td rowspan="4" height="50" align="center">
            
            <asp:Image ID="Image1" runat="server" Width="320" Height="180" />
            
        </td>
    </tr>
    <tr>
        <td height="50" align="center">
            <asp:Label ID="LColorS" runat="server" Text="Color:" Font-Bold="True"></asp:Label>
        </td>
        <td height="50" align="center">
            <asp:Label ID="LColor" runat="server" Text=""></asp:Label>
        </td>
    </tr>
    <tr>
        <td height="50" align="center">
            <asp:Label ID="LTallaS" runat="server" Text="Talla:" Font-Bold="True"></asp:Label>
        </td>
        <td height="50" align="center">
            <asp:Label ID="LTalla" runat="server" Text=""></asp:Label>
        </td>
    </tr>
    <tr>
        <td height="50" align="center">
            <asp:Label ID="LMontoS" runat="server" Text="Monto $:" Font-Bold="True"></asp:Label>
        </td>
        <td height="50" align="center">
            <asp:Label ID="LMonto" runat="server" Text=""></asp:Label>
        </td>
    </tr>
    <tr>
        <td colspan="3" height="50" align="center">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="BEliminar" runat="server" Text="Eliminar" Width="80px" 
                onclick="BEliminar_Click" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="BVolver" runat="server" Text="Volver" Width="80px" PostBackUrl="~/InicioAdmin.aspx" />
        </td>
    </tr>

</table>



</asp:Content>
