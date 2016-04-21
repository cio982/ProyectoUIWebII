<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="horario_generado.aspx.cs" Inherits="Ejercicio02.horario_generado" %>

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
    <div>
    
    </div>
    <div id="contenedor">
		<div class="cont_horario">
			<h1>HORARIO UPT</h1>
			<div class="cont_h cont_h-1">
				<h3>Mi horario</h3>
				<p>
					<asp:Button ID="btnExcel" class="btncontr btncontr-e" runat="server" Text="Excel" OnClick="btnExcel_Click" />
                    <asp:Button ID="btnPdf" class="btncontr btncontr-p" runat="server" Text="PDF" OnClick="btnPdf_Click" />
				</p>
			</div>
			<div class="cont_h cont_h-2">

                <asp:Panel ID="pnlPanel" runat="server">
            
				<div class="horario">
					<div class="horario-item">
						<div class="dia">
							<span>Lunes</span>
						</div>
						<div class="cursos">
							<div class="cursos">
							    <asp:Label ID="LblResultado1" runat="server"></asp:Label>
                                <asp:Label ID="LblResultado1_2" runat="server"></asp:Label>
                                <asp:Label ID="LblResultado1_3" runat="server"></asp:Label>
                                <asp:Label ID="LblResultado1_4" runat="server"></asp:Label>
                                <asp:Label ID="LblResultado1_5" runat="server"></asp:Label>
                                <asp:Label ID="LblResultado1_6" runat="server"></asp:Label>
                                <asp:Label ID="LblResultado1_7" runat="server"></asp:Label>
                                <asp:Label ID="LblResultado1_8" runat="server"></asp:Label>
                                <asp:Label ID="LblResultado1_9" runat="server"></asp:Label>
                                <asp:Label ID="LblResultado1_10" runat="server"></asp:Label>
                                <asp:Label ID="LblResultado1_11" runat="server"></asp:Label>
                                <asp:Label ID="LblResultado1_12" runat="server"></asp:Label>
                                <asp:Label ID="LblResultado1_13" runat="server"></asp:Label>
                                <asp:Label ID="LblResultado1_14" runat="server"></asp:Label>
                                <asp:Label ID="LblResultado1_15" runat="server"></asp:Label>
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

                </asp:Panel>
			</div>
			<div class="cont_h cont_h-3">
				<h3>Cruce de horario</h3>
				<section>
					<div class="cruce_item">
						<div class="cruc_dia">
							Lunes
						</div>
						<div class="cont_cruce">
							<div class="color_cur">
								<span class="icon-items icon-cinta1"></span>
							</div>
							<div class="nom_cur">
								<p>Nombre de curso 1</p>
								<span>8:00 - 9:50 (LAB-C)</span>
							</div>
						</div>
						<div class="cont_cruce">
							<div class="color_cur">
								<span class="icon-items icon-cinta1"></span>
							</div>
							<div class="nom_cur">
								<p>Nombre de curso 1</p>
								<span>8:00 - 9:50 (LAB-C)</span>
							</div>
						</div>
					</div>
				</section>
				
			</div>
		</div>
	</div>
    </form>
    </body>
</html>
