<%@ Page Title="" Language="C#" MasterPageFile="~/Template.Master" AutoEventWireup="true" CodeBehind="Siguenos.aspx.cs" Inherits="Arbiter.Siguenos" %>
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
		<h2>Siguenos</h2>	
	</div>
	<div class="boxA">
		<div class="box">
			<img src="images/facebook.jpg" width="320" height="180" alt="" />
			<h3>Facebook</h3>
			
		</div>
	
	</div>
	<div class="boxB">
		<div class="box">
			<img src="images/twitter.jpg" width="320" height="180" alt="" />
			<h3>Twitter</h3>
			
		</div>
		
	</div>
	<div class="boxC">
		<div class="box">
			<a href="https://instagram.com/arbitervzla/"><img src="images/instagram.jpg" width="320" height="180" alt="" /></a>
			<h3>Instagram</h3>
			
		</div>
		
	</div>
</div>



</asp:Content>
