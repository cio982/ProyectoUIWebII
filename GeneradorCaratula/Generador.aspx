﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Generador.aspx.cs" Inherits="GeneradorCaratula.Generador" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="auto-style1">
    
        <asp:TextBox ID="txtUniversidad" runat="server" Width="308px"></asp:TextBox>
        <br />
        <asp:Button ID="btnEnviar" runat="server" Text="Enviar" Width="137px" PostBackUrl="~/ReportViewer.aspx"/>
    
    </div>
    </form>
</body>
</html>
