<%@ Page Title="" Language="C#" MasterPageFile="~/Template.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Arbiter.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <form id="form1" runat="server">   

   <div id="header-wrapperN">
	<div id="header" class="container">
     <%--   <div id="Div1">	      
			 <img src="images/logoArbiter.jpg"/>
		</div>--%>
		<div id="logo">	      
			<a href="\PaginaPrincipal.aspx" accesskey="4" title=""><h1>ARBITER</h1></a>
		</div>
		<div id="menu">
			<ul>
				<li><a href="#" accesskey="1" title="">Nosotros</a></li>
				<li><a href="#" accesskey="2" title="">Contactenos</a></li>
				<li><a href="#" accesskey="3" title="">Ubicacion</a></li>
				<li><a href="#" accesskey="4" title="">Catálogo</a></li>
				<li><a href="#" accesskey="5" title="">Administrativo</a></li>
			</ul>
		</div>
	       
	</div>
    </div>
                  <div id="page" class="container" >

                    <table> 
                        <tr>
                            <td  rowspan="6" > 
                                    
                                    <div class="title" align="center">
		                                <h2>Sistema Administrativo Arbiter</h2>
	                                </div>

                                     <p style="font-weight: bold">Bienvenido al sistema de administración de Arbiter, aquí podrán gestionar el catálogo de productos 
                                     visible en la página web para el público general, Consultar los resultados del análisis estadístico de las
                                     ventas que incluye: mercancía, clientes y empleados,  además de  los reportes de la evaluación de ganancias.</p>            
                                                                          
                                     &nbsp;
                                     <div align="center">
                                       <img src="images/tienda.jpg" /> 
                                     </div>
                                   

                            </td>

                            <td  rowspan="6" width="50"> 
                                &nbsp;&nbsp; &nbsp;
                            </td>

                            <td colspan="2" align="center" height="50">
                                <asp:Label ID="Label1" runat="server" Text="Ingresar" Font-Bold="True"></asp:Label>
                            </td>
             
                        </tr>
                        <tr>
                            <td align="center" height="50">
                                <asp:Label ID="Label2" runat="server" Text="Usuario"></asp:Label>
                            </td>
                             <td height="50">
                                    <asp:TextBox ID="TBusuario" runat="server"></asp:TextBox>
                            </td>
               
                        </tr>
                        <tr>
                            <td align="center" height="50">
                                <asp:Label ID="Label3" runat="server" Text="Contraseña"></asp:Label>
                            </td>
                            <td height="50">
                                    <asp:TextBox ID="TBcontrasena" runat="server" TextMode="Password"></asp:TextBox>
                            </td>
             
                        </tr>
                        <tr>
                            <td colspan="2" align="center" height="50">

                                <asp:Button ID="BAceptar" runat="server" Text="Aceptar" 
                                    onclick="BAceptar_Click" />

                            </td>
                        </tr>
                        <tr>
                            <td colspan="2" align="center" height="50">
                                 <asp:Label ID="Lmsj" runat="server" Text="Label" ForeColor="Red"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2"  height="200">
                               
                            </td>
                        </tr>
                      
                    </table>
    
                     </div> 


    </form>


</asp:Content>
