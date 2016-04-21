<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="consultar.aspx.cs" Inherits="Ejercicio02.consultar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Horario UPT</title>
	<link rel="icon" type="image/png" href="img/icono.png" />
	<link rel="stylesheet" href="css/estilos.css"/>
	<meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1, user-scalable=no"/>
	<script src="js/jquery.js"></script>
	<script src="js/select.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
    <div id="contenedor">
		<div class="cont_consultas">
			<h1>HORARIO UPT</h1>
			<h2>Consultas</h2>
			<label class="lbl_consulta" >Seleccionar una opción:</label>
			<a id="lista01" class="lista_select" href="#">
				Ciclo
				<span  class="icon-items icon-flecha1"></span>
			</a>
			<div id="lst_item1" class="lst_items">
				<ul>
                    <asp:Label ID="lblLista1" runat="server"></asp:Label>
				</ul>
			</div>
			<a id="lista02" class="lista_select" href="#">
				Docenter
				<span  class="icon-items icon-flecha1"></span>
			</a>
			<div id="lst_item2" class="lst_items">
				<ul>
					<asp:Label ID="lblLista2" runat="server"></asp:Label>
				</ul>
			</div>
			<a id="lista03" class="lista_select" href="#">
				Curso
				<span  class="icon-items icon-flecha1"></span>
			</a>
			<div id="lst_item3" class="lst_items">
				<ul>
					<asp:Label ID="lblLista3" runat="server"></asp:Label>
				</ul>
			</div>
			<a id="lista04" class="lista_select" href="#">
				Aula / Laboratorio
				<span  class="icon-items icon-flecha1"></span>
			</a>
			<div id="lst_item4" class="lst_items">
				<ul>
					<asp:Label ID="lblLista4" runat="server"></asp:Label>
				</ul>
			</div>
			<a id="lista05" class="lista_select" href="#">
				Día
				<span  class="icon-items icon-flecha1"></span>
			</a>
			<div id="lst_item5" class="lst_items">
				<ul>
					<li><a href="consulta_tipo.aspx?tipo=5&id=1">Lunes</a></li>
					<li><a href="consulta_tipo.aspx?tipo=5&id=2">Martes</a></li>
					<li><a href="consulta_tipo.aspx?tipo=5&id=3">Miercoles</a></li>
					<li><a href="consulta_tipo.aspx?tipo=5&id=4">Jueves</a></li>
                    <li><a href="consulta_tipo.aspx?tipo=5&id=5">Viernes</a></li>
					<li><a href="consulta_tipo.aspx?tipo=5&id=6">Sabado</a></li>
				</ul>
			</div>
			<a id="lista06" class="lista_select" href="consulta_tipo?tipo=6&id=0">
				Disponibilidad libre
			</a>
		</div>
		<div class="regresar">
			<a href="index.aspx"><span class="icon-items icon-flecha2"></span></a>
		</div>
	</div>
    </form>
    </body>
</html>
