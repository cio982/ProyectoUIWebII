<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="consulta_tipo.aspx.cs" Inherits="Ejercicio02.consulta_tipo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>UPT</title>
    <link rel="icon" type="image/png" href="img/logo_upt.png" />
	<link rel="stylesheet" href="css/estilos.css"/>
	<meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1, user-scalable=no"/>
	<script src="js/jquery.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div id="contenedor">
		<div class="cont_horario">
			<h1>HORARIO UPT
                </h1>
			<div class="cont_h cont_h-1">
				<h3>Mi horario</h3>
				<p>
					<a class="btncontr btncontr-e" href="#">EXCEL</a>
					<a class="btncontr btncontr-p" href="#">PDF</a>
				</p>
			</div>
			<div class="cont_h cont_h-2">
				<div class="horario">
					<div class="horario-item">
						<div class="dia">
							<span>Lunes</span>
						</div>
						<div class="cursos">
							<div class="cursos">
							    <asp:Label ID="LblResultado1" runat="server"></asp:Label>
						    </div>
						</div>
					</div>
					<div class="horario-item">
						<div class="dia">
							<span>Martes</span>
						</div>
                        <div class="cursos">
							<asp:Label ID="LblResultado2" runat="server"></asp:Label>
						</div>
						 
					</div>
                    <div class="horario-item">
						<div class="dia">
							<span>Miercoles</span>
						</div>
						<div class="cursos">
							<asp:Label ID="LblResultado3" runat="server"></asp:Label>
						</div>
					</div>
                    <div class="horario-item">
						<div class="dia">
							<span>Jueves</span>
						</div>
						<div class="cursos">
							<asp:Label ID="LblResultado4" runat="server"></asp:Label>
						 </div>
					</div>
                    <div class="horario-item">
						<div class="dia">
							<span>Viernes</span>
						</div>
						<div class="cursos">
							<asp:Label ID="LblResultado5" runat="server"></asp:Label>
						</div>
					</div>
                    <div class="horario-item">
						<div class="dia">
							<span>Sabado</span>
						</div>
						<div class="cursos">
							<asp:Label ID="LblResultado6" runat="server"></asp:Label>
						</div>
					</div>
				</div>

			</div>
			
		</div>
	</div>
    </form>
</body>
</html>
