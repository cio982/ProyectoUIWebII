<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="generador.aspx.cs" Inherits="Ejercicio02.generador" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml"  lang="es">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Horario UPT</title>
	<link rel="icon" type="image/png" href="img/icono.png" />
	<link rel="stylesheet" href="css/estilos.css"/>
	<meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1, user-scalable=no"/>
	<script src="js/jquery.js"></script>
</head>
<body>
    <div id="contenedor">
		<div class="cont_form">
			<h1>HORARIO UPT</h1>
			<form class="form01" id="form1" runat="server">
			<h2>Generador</h2>
				<div class="cont_controles">
					<asp:Button ID="BtnAgregarCurso" class="btn03" runat="server" Text="+ Agregar" OnClick="Button1_Click"/>

					<!--<button class="btn02">
						<span  class="icon-items icon-agregar"></span>
					</button>
					<button class="btn02">
						<span  class="icon-items icon-menos"></span>
					</button>
					<button class="btn02">
						<span  class="icon-items icon-ok"></span>
					</button>-->
				    
				    <asp:Button ID="btnQuitarCurso" class="btn03" runat="server" Text="- Quitar" OnClick="btnQuitarCurso_Click" />
				    
				    <asp:Button ID="BtnGenerar" class="btn03" runat="server" OnClick="BtnGenerar_Click" Text="Generar" /> 
				</div>

				<section>
					<div class="borde_section">
						<label class="e_label">Seleccionar ciclo:
                        </label>
						&nbsp;<asp:DropDownList ID="DdlCiclo" class="e_select" runat="server" OnSelectedIndexChanged="DdlCiclo_SelectedIndexChanged">
                        </asp:DropDownList><asp:Button ID="btnSeleccionarCiclo" class="btn03"  runat="server" OnClick="btnSeleccionarCiclo_Click" Text="Seleccionar" />
						<label class="e_label">Seleccionar curso:<asp:Label ID="lblCiclo" runat="server" Text="(ciclo)"></asp:Label>
                        </label>
                        &nbsp;<asp:ListBox ID="LstbCurso" class="e_txtarea e_area_i" runat="server" SelectionMode="Multiple"></asp:ListBox>
					</div>
				</section>
				<section>
					<div class="borde_section">
						<label class="e_label">Cursos seleccionados:</label>
                        <asp:ListBox ID="LstCursosSeleccionados"  class="e_txtarea e_area_d" runat="server" SelectionMode="Multiple"></asp:ListBox>
					</div>
				</section>

			</form>
		</div>


		<div class="regresar">
			<a href="index.aspx"><span class="icon-items icon-flecha2"></span></a>
		</div>
	</div>
</body>
</html>
