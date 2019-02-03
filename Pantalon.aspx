<%@ Page Title="" Language="C#" MasterPageFile="~/Template.Master" AutoEventWireup="true" CodeBehind="Pantalon.aspx.cs" Inherits="Arbiter.Pantalon" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

<div id="header-wrapperN">
	<div id="header" class="container">
		<div id="logo">
			<a href="\PaginaPrincipal.aspx" accesskey="4" title=""><h1>ARBITER</h1></a>
		</div>
		<div id="menu">
			<ul>
				<li><a href="\nosotros.aspx" accesskey="1" title="">Nosotros</a></li>
				<li><a href="\contactenos.aspx" accesskey="2" title="">Contactenos</a></li>
				<li><a href="\ubicacion.aspx" accesskey="3" title="">Ubicacion</a></li>
				<li><a href="\catalogo.aspx" accesskey="4" title="">Catálogo</a></li>
				<li><a href="javascript:window.open('Login.aspx')" accesskey="5" title="">Administrativo</a></li>  
		</div>
	</div>
</div>

<div id="page" class="container">
	<div class="title">
		<h2>Categoria: Pantalón </h2>	
	</div>
	<div class="boxA">
		<div class="box">
            <asp:Image ID="Image1" runat="server" Width="320" Height="180" />

			<p >
                <asp:Literal ID="Literal1" runat="server"></asp:Literal> <br />
                <asp:Literal ID="Literal2" runat="server"></asp:Literal> <br />
                <asp:Literal ID="Literal3" runat="server"></asp:Literal> 
            <p>
			
		
		</div>
		<div class="box">
			 <asp:Image ID="Image2" runat="server" Width="320" Height="180" />
			
            <p>
                <asp:Literal ID="Literal4" runat="server"></asp:Literal> <br /> 
                <asp:Literal ID="Literal5" runat="server"></asp:Literal> <br /> 
                <asp:Literal ID="Literal6" runat="server"></asp:Literal> 
            </p>
			
		</div>
	</div>
	<div class="boxB">
		<div class="box">
			 <asp:Image ID="Image3" runat="server" Width="320" Height="180" />
			
            <p>
                <asp:Literal ID="Literal7" runat="server"></asp:Literal> <br /> 
                <asp:Literal ID="Literal8" runat="server"></asp:Literal> <br /> 
                <asp:Literal ID="Literal9" runat="server"></asp:Literal> 
            </p>
			
			
		</div>
		<div class="box">
			 <asp:Image ID="Image4" runat="server" Width="320" Height="180" />
			
            <p>
                <asp:Literal ID="Literal10" runat="server"></asp:Literal> <br /> 
                <asp:Literal ID="Literal11" runat="server"></asp:Literal> <br /> 
                <asp:Literal ID="Literal12" runat="server"></asp:Literal> 
            </p>
			
			
		</div>
	</div>
	<div class="boxC">
		<div class="box">
			 <asp:Image ID="Image5" runat="server" Width="320" Height="180" />
			<p>
                <asp:Literal ID="Literal13" runat="server"></asp:Literal> <br /> 
                <asp:Literal ID="Literal14" runat="server"></asp:Literal> <br /> 
                <asp:Literal ID="Literal15" runat="server"></asp:Literal> 
            </p>
			
			
		</div>
		<div class="box">
			 <asp:Image ID="Image6" runat="server" Width="320" Height="180" />
			<p>
                <asp:Literal ID="Literal16" runat="server"></asp:Literal> <br /> 
                <asp:Literal ID="Literal17" runat="server"></asp:Literal> <br /> 
                <asp:Literal ID="Literal18" runat="server"></asp:Literal>  
            </p>
			
		</div>
	</div>
    
    <form id="Form1" runat="server">
    <asp:Button ID="Button1" runat="server" Text="Siguiente Pagina" class="button" 
        style="float:right" onServerClick="BotonSiguiente_Click" 
        onclick="Button1_Click" />
    </form>
</div>


</asp:Content>
