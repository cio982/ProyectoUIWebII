<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GeneradordeCaratula.aspx.cs" Inherits="ProyectoUI_DesarrolloWebII.GeneradordeCaratula" %>

<%@ Register assembly="Microsoft.ReportViewer.WebForms, Version=12.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: left;
        }
    </style>
</head>
    <center>
<body>
    <form id="form1" runat="server">
    <div>
    
        <div class="auto-style1">
    
        <rsweb:ReportViewer ID="rvCaratula" runat="server" Font-Names="Verdana" Font-Size="8pt" WaitMessageFont-Names="Verdana" WaitMessageFont-Size="14pt" Height="673px" Width="586px">
            <LocalReport ReportPath="Reporte.rdlc">
            </LocalReport>
        </rsweb:ReportViewer>
        </div>
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
    
    </div>
    </form>

</body>
        </center>
</html>
