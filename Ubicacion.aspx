<%@ Page Title="" Language="C#" MasterPageFile="~/Template.Master" AutoEventWireup="true" CodeBehind="Ubicacion.aspx.cs" Inherits="Arbiter.Ubicacion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">


<script type="text/javascript" src="http://maps.googleapis.com/maps/api/js"></script>

<script type="text/javascript">
    function initialize() 
    {
        var mapProp = 
        {
            center: new google.maps.LatLng(10.477751, -66.858444),
            zoom: 17,
            mapTypeId: google.maps.MapTypeId.ROADMAP
        };
         var map = new google.maps.Map(document.getElementById("googleMap"), mapProp);
         
         var place = new google.maps.LatLng(10.477751, -66.858444);
         var marker = new google.maps.Marker({
         position: place
         , title: 'Arbiter C.A'
         , map: map
         , });
    }
    google.maps.event.addDomListener(window, 'load', initialize);

  
   

</script>



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
			</ul>
		</div>
	</div>
</div>



<div id="page" class="container">
	<div class="title">
		<h2>Ubicacion</h2>	
	</div>
	



               
 
            <table style="margin: 0 auto;">
                <tr >
                    <td rowspan="2"><div id="googleMap" style="width:400px;height:250px;"></div></td>
                    <td> <p> <b>&nbsp Direccion:</b> C.C Paseo Las Mercedes, local, PB, Caracas, Venezuela </p> 
                         <p> <b>&nbsp Numero de Contacto: </b>(0212) 992-90-42</p>
                        <p> <b>&nbsp Email: </b>arbiterdevenezuela@gmail.com</p>
                    
                    
                    </td>
                </tr>
 
            
            </table>









</div>



</asp:Content>
