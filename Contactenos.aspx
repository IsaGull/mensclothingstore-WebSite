<%@ Page Title="" Language="C#" MasterPageFile="~/Template.Master" AutoEventWireup="true" CodeBehind="Contactenos.aspx.cs" Inherits="Arbiter.Contactenos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

<div id="header-wrapperN">
	<div id="header" class="container">
		<div id="logo">
			<a href="\PaginaPrincipal.aspx" accesskey="4" title=""><h1>ARBITER</h1></a>
		</div>
		<div id="menu">
			<ul><li><a href="\nosotros.aspx" accesskey="1" title="">Nosotros</a></li>
				<li><a href="\contactenos.aspx" accesskey="2" title="">Contactenos</a></li>
				<li><a href="\ubicacion.aspx" accesskey="3" title="">Ubicacion</a></li>
				<li><a href="\catalogo.aspx" accesskey="4" title="">Catálogo</a></li>
				<li><a href="javascript:window.open('Login.aspx')" accesskey="5" title="">Administrativo</a></li>  
			</ul>
		</div>
	</div>
</div>


<div id="page" class="container">
   
   
    <form id="Form1" runat="server">
   
   
	<div class="title">
		<h2>Contactanos</h2>
        <h3>Envia un mensaje al personal de la tienda: </h3>
        <br />	
	</div>
             <asp:Table ID="Table1" runat=server Width="1000" >
                <asp:TableRow>
                    <asp:TableCell ColumnSpan="2">                     
                          <asp:TextBox ID="TextBox2" runat="server" Width="1000" placeholder="Titulo" BackColor="#CCCCCC"> </asp:TextBox>   
                     </asp:TableCell>                   
                </asp:TableRow>
 
              <asp:TableRow>
                    <asp:TableCell ColumnSpan="2"> 
                          <asp:TextBox ID="TextBox1" TextMode="MultiLine" Rows="6" runat="server" Width="1000" placeholder="Mensaje" BackColor="#CCCCCC"> </asp:TextBox>  
                    </asp:TableCell>                     
                </asp:TableRow>
                


                <asp:TableRow>
                    <asp:TableCell>  
                         
                    </asp:TableCell>
                </asp:TableRow>
          </asp:Table>
                          <asp:Button ID="Button1" runat="server" Text="Enviar" class="button" onclick="Button1_Click"/>  &nbsp &nbsp &nbsp &nbsp 
                          <asp:Button ID="Button2" runat="server" Text="Borrar Todo" class="button" onclick="Button2_Click"/> <br /> <br />
                        <b>  <asp:Label ID="Label2" runat="server" Text="" Visible=false></asp:Label> </b>
          </form>
          
</div>

</asp:Content>

