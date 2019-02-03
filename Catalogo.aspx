<%@ Page Title="" Language="C#" MasterPageFile="~/Template.Master" AutoEventWireup="true" CodeBehind="Catalogo.aspx.cs" Inherits="Arbiter.Catalogo" %>
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
	<div class="title">
		<h2>Selecciona la categoria que deseas ver:</h2>	
	</div>
	<div class="boxA">
		<div class="box">
			<img src="images/esmoquin.jpg" width="320" height="180" alt="" />
			<h3 >Esmoquin </h3>
			
			<a href="\Esmoquin.aspx" class="button">Ver Más</a>
		</div>
		<div class="box">
			<img src="images/traje.jpg" width="320" height="180" alt="" />
			<h3>Trajes</h3>
			
			<a href="\Traje.aspx" class="button">Ver Más</a>
		</div>
	</div>
	<div class="boxB">
		<div class="box">
			<img src="images/camisa.jpg" width="320" height="180" alt="" />
			<h3>Camisas</h3>
			
			<a href="\Camisa.aspx" class="button">Ver Más</a>
		</div>
		<div class="box">
			<img src="images/pantalon.jpg" width="320" height="180" alt="" />
			<h3>Pantalones</h3>
			
			<a href="\Pantalon.aspx" class="button">Ver Más</a>
		</div>
	</div>
	<div class="boxC">
		<div class="box">
			<img src="images/corbata1.jpg" width="320" height="180" alt="" />
			<h3>Corbatas</h3>
			
			<a href="\Corbata.aspx" class="button">Ver Más</a>
		</div>
		<div class="box">
			<img src="images/accesorio.jpg" width="320" height="180" alt="" />
			<h3>Accesorios</h3>
			
			<a href="\Accesorio.aspx" class="button">Ver Más</a>
		</div>
	</div>
</div>




</asp:Content>
