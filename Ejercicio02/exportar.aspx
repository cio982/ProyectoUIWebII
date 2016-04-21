<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="exportar.aspx.cs" Inherits="Ejercicio02.exportar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
     <title>Horario UPT</title>
	<link rel="icon" type="image/png" href="img/icono.png" />
	<link rel="stylesheet" href="css/estilos.css"/>
	<meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1, user-scalable=no"/>
	<script src="js/jquery.js"></script>
    <style type="text/css">
        .auto-style1 {
            height: 23px;
        }
        body{
            color: white;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <center>
        
        <asp:Panel ID="pnlPanel" runat="server">
            <h1>Horario</h1>
            <table style="width:650px;">
                <tr>
                    <td class="auto-style1"><b>Lunes</b></td>
                    <td class="auto-style1"><b>Martes</b></td>
                    <td class="auto-style1"><b>Miercoles</b></td>
                    <td class="auto-style1"><b>Jueves</b></td>
                    <td class="auto-style1"><b>Viernes</b></td>
                    <td class="auto-style1"><b>Sabado</b></td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="LblResultado1" class="labelexpor" runat="server"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="LblResultado2" class="labelexpor" runat="server"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="LblResultado3" class="labelexpor" runat="server"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="LblResultado4" class="labelexpor" runat="server"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="LblResultado5" class="labelexpor" runat="server"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="LblResultado6" class="labelexpor" runat="server"></asp:Label>
                    </td>
                </tr>
            </table>
        </asp:Panel>
        <br />
        <asp:Button ID="btnExcel" class="btncontr btncontr-e" runat="server" Text="Excel" OnClick="btnExcel_Click" />
        <asp:Button ID="btnPDF" class="btncontr btncontr-p" runat="server" Text="PDF" OnClick="btnPDF_Click1" />
        &nbsp;</center>
    </div>
    </form>
</body>
</html>
