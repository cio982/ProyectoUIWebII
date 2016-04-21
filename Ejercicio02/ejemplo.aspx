<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ejemplo.aspx.cs" Inherits="Ejercicio02.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <h1> Horario UPT</h1>
    <form id="form1" runat="server">
        <asp:Button ID="BtnListar" runat="server" OnClick="BtnListar_Click" Text="Listar" />
        <br />
        <asp:DropDownList ID="DropDownList1" runat="server">
        </asp:DropDownList>
        <br />
        <asp:Label ID="LblLista" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
