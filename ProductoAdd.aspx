<%@ Page Title="" Language="C#" MasterPageFile="~/MasterAdmin.Master" AutoEventWireup="true" CodeBehind="ProductoAdd.aspx.cs" Inherits="Arbiter.ProductoAdd" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

<head>

<script src="//code.jquery.com/jquery-1.11.2.min.js" type="text/javascript"></script>
    <script type="text/javascript">
        function ShowImagePreview(input) {
            if (input.files && input.files[0]) {
                var reader = new FileReader();
                reader.onload = function (e) {
                    $('#<%=Image1.ClientID%>').prop('src', e.target.result)
                        .width(200)
                        .height(121);
                };
                reader.readAsDataURL(input.files[0]);
            }
        }
    </script>

</head>

<table>
    <tr>
        <td colspan="3" height="50" align="center">
            <asp:Label ID="LAddPro" runat="server" Text="Agregar Producto" Font-Bold="True" Font-Size="X-Large"></asp:Label>
        </td>
    </tr>
    <tr>
        <td colspan="3" height="20" align="left">
            <asp:Label ID="Lmsj" runat="server" Font-Bold="True" ForeColor="Red"></asp:Label>
        </td>
    </tr>
    <tr>
        <td height="50" width="100" align="center" >
            <asp:Label ID="LTipo" runat="server" Text="Tipo:" Font-Bold="True"></asp:Label>
        </td>
        <td height="50" width="200" align="center">
            <asp:DropDownList ID="DDLTipo" runat="server" Width="150px">
            </asp:DropDownList>
        </td>
        <td height="50" align="center" width="500">
            
            <asp:Label ID="LImagen" runat="server" Text="Cargar Imagen:" Font-Bold="True"></asp:Label>
            
        </td>
    </tr>
    <tr>
        <td height="50" align="center">
            <asp:Label ID="LMarca" runat="server" Text="Marca:" Font-Bold="True"></asp:Label>
        </td>
        <td height="50" align="center">
            <asp:TextBox ID="TBMarca" runat="server"></asp:TextBox>
        </td>

        <td align="center">
            <asp:FileUpload ID="ImagenFile" runat="server" onchange="ShowImagePreview(this);"  />
         </td> 
       <%-- <input id="ImagenFile" type="file" runat="server"/>
        --%>
    </tr>
    <tr>
        <td height="50" align="center">
            <asp:Label ID="LColor" runat="server" Text="Color:" Font-Bold="True"></asp:Label>
        </td>
        <td height="50" align="center">
            <asp:TextBox ID="TBColor" runat="server"></asp:TextBox>
        </td>
        <td rowspan="4" height="50" align="center">
            <asp:Image ID="Image1" runat="server"  Width="220" Height="180" />
        </td>
    </tr>
    <tr>
        <td height="50" align="center">
            <asp:Label ID="LTalla" runat="server" Text="Talla:" Font-Bold="True"></asp:Label>
        </td>
        <td height="50" align="center">
            <asp:TextBox ID="TBTalla" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td height="50" align="center">
            <asp:Label ID="LMonto" runat="server" Text="Monto $:" Font-Bold="True"></asp:Label>
        </td>
        <td height="50" align="center">
            <asp:TextBox ID="TBMonto" runat="server" TextMode="Number"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td height="50" align="center">
            <asp:Label ID="LCodigo" runat="server" Text="Código:" Font-Bold="True"></asp:Label>
        </td>
        <td height="50" align="center">
            <asp:TextBox ID="TBCodigo" runat="server" TextMode="Number"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td colspan="3" height="50" align="center">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="BAgregar" runat="server" Text="Agregar" Width="80px" onclick="BAgregar_Click" autopostback="false"/>

            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="BVolver" runat="server" Text="Volver" Width="80px" PostBackUrl="~/InicioAdmin.aspx" />
        </td>
    </tr>

</table>



</asp:Content>
