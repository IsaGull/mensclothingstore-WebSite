<%@ Page Title="" Language="C#" MasterPageFile="~/Template.Master" AutoEventWireup="true" CodeBehind="PaginaPrincipal.aspx.cs" Inherits="Arbiter.PaginaPrincipal" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<div id="header-wrapperN">
	<div id="header" class="container">
		<div id="logo">
			<%--<img src="images/a1.png" alt=""/>--%>
			<a href="\PaginaPrincipal.aspx" accesskey="4" title=""><h1>ARBITER</h1></a>
		</div>
        
		<div id="menu">
			<ul>
				<li><a href="\nosotros.aspx" accesskey="1" title="">Nosotros</a></li>
				<li><a href="\contactenos.aspx" accesskey="2" title="">Contactenos</a></li>
				<li><a href="\ubicacion.aspx" accesskey="3" title="">Ubicacion</a></li>
				<li><a href="\catalogo.aspx" accesskey="4" title="">Catálogo</a></li>
				<li><a href="\Login.aspx" accesskey="5" title="">Administrativo</a></li>               
              	<%--<li><a href="javascript:window.open('Login.aspx')" accesskey="5" title="">Administrativo</a></li>--%>
			</ul>
		</div>
	</div>
</div>
<div id="page" class="container">
	<div class="title">
		<h2>Calidad y compromiso...</h2>	
	</div>
	<div class="boxA">
		<div class="box">
			<img src="images/img07.jpg" width="320" height="180" alt="" />
			<h3>Catálogo</h3>
			<p>Visualiza una breve descripcion de los articulos ofrecidos en la tienda.</p>
			<a href="\Catalogo.aspx" class="button">Leer Más</a>
		</div>
		<div class="box">
			<img src="images/img02.jpg" width="320" height="180" alt="" />
			<h3 >Contactenos</h3>
			<p>Envia un email a traves del portal para el personal de la tienda.</p>
			<a href="\Contactenos.aspx" class="button">Leer Más</a>
		</div>
	</div>
	<div class="boxB">
		<div class="box">
			<img src="images/img03.jpg" width="320" height="180" alt="" />
			<h3>Nosotros</h3>
			<p>Mision, Vision, Valores y breve descripcion de la tienda.</p>
			<a href="\Nosotros.aspx" class="button">Leer Más</a>
		</div>
		<div class="box">
			<img src="images/img04.jpg" width="320" height="180" alt="" />
			<h3>Siguenos</h3>
			<p>Agreganos en la red social de tu preferencia para enterarte de todo.</p>
			<a href="\Siguenos.aspx" class="button">Leer Más</a>
		</div>
	</div>
	<div class="boxC">
		<div class="box">
			<img src="images/img05.jpg" width="320" height="180" alt="" />
			<h3>Ubicacion</h3>
			<p>Direccion, mapa y telefono de contactos de la tienda.</p>
			<a href="\Ubicacion.aspx" class="button">Leer Más</a>
		</div>
		<div class="box">
			<img src="images/img06.jpg" width="320" height="180" alt="" />
			<h3>Administrativo</h3>
			<p>Solo para uso del personal administrativo de la tienda.</p>
            <a href="\Login.aspx" class="button">Leer Más</a>
			<%--<a href="javascript:window.open('Login.aspx')" class="button">Leer Más</a>--%>
		</div>
	</div>
</div>

</asp:Content>
