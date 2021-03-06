﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio01_Caratula.aspx.cs" Inherits="ProyectoUI_DesarrolloWebII.Ejercicio01_Caratula" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 177px;
        }
        .auto-style2 {
            width: 256px;
        }
    </style>
    <link href="css/bootstrap-theme.css" rel="stylesheet" />
    <link href="css/bootstrap.min.css" rel="stylesheet" />

    

</head>
<body>
     <style type="text/css">
        .text-align {
            center;
        }        
        .auto-style3 {
            width: 337px;
        }
        .auto-style4 {
            width: 177px;
            height: 30px;
        }
        .auto-style5 {
            width: 256px;
            height: 30px;
        }
        .auto-style6 {
            width: 337px;
            height: 30px;
        }
    </style>
    <form id="form1" runat="server">
    <div class="form-group">
    
        Ejercicio 01<br />
        <table style="width:45%;" align="center">
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style2"><h3>GENERADOR DE CARATULA</h3></td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1"><label>UNIVERSIDAD:</label></td>
                <td class="auto-style2">
                    <div class="input-field col s6">
                        <asp:TextBox ID="TxtUniversidad" runat="server" Width="245px"></asp:TextBox>
                    </div>
                </td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1"><label>FACULTAD:</label></td>
                <td class="auto-style2">
                    <asp:TextBox ID="TxtFacultad" runat="server" Width="245px"></asp:TextBox>
                </td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1"><label>ESCUELA:</label></td>
                <td class="auto-style2">
                    <asp:TextBox ID="TxtEscuela" runat="server" Width="245px"></asp:TextBox>
                </td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1"><label>TIPO:</label></td>
                <td class="auto-style2">
                    <asp:RadioButtonList ID="RbtnTipo" runat="server">
                        <asp:ListItem>TRABAJO</asp:ListItem>
                        <asp:ListItem>INFORME</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1"><label>CICLO:</label></td>
                <td class="auto-style2">
                    <asp:DropDownList ID="DdlCiclo" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DdlCiclo_SelectedIndexChanged1">
                    </asp:DropDownList>
                </td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1"><label>CURSO:</label></td>
                <td class="dropdown-menu">
                    <asp:DropDownList ID="DdlCurso" runat="server" Height="20px" Width="250px" AutoPostBack="True" OnSelectedIndexChanged="DdlCurso_SelectedIndexChanged">
                    </asp:DropDownList>
                </td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1"><label>DOCENTE:</label></td>
                <td class="auto-style2">
                    <asp:TextBox class="form-control" ID="TxtDocente" runat="server" Width="245px"></asp:TextBox>
                </td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1"><label>TITULO:</label></td>
                <td class="auto-style2">
                    <asp:TextBox ID="TxtTitulo" runat="server" Width="245px"></asp:TextBox>
                </td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1"><label>PRESENTACION:</label></td>
                <td class="auto-style2">
                    <asp:RadioButtonList ID="RbtnPresentacion" runat="server" AppendDataBoundItems="True" AutoPostBack="True" OnSelectedIndexChanged="RbtnPresentacion_SelectedIndexChanged">
                        <asp:ListItem>INDIVIDUAL</asp:ListItem>
                        <asp:ListItem>GRUPAL</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1"><label>CODIGO</label></td>
                <td class="auto-style2"><label>NOMBRE</label></td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:TextBox ID="TxtCodigo" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="TxtNombre" runat="server" Width="245px"></asp:TextBox>
                </td>
                <td class="auto-style3">
                    <asp:Button class="btn btn-success" ID="BtnSumar" runat="server" Width="50px" OnClick="BtnSumar_Click" />
                </td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:TextBox ID="TxtCodigo1" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="TxtNombre1" runat="server" Width="245px"></asp:TextBox>
                </td>
                <td class="auto-style3">
                    <asp:Button class="btn btn-success" ID="BtnSumar1" runat="server" Width="50px" OnClick="BtnSumar1_Click"/>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:TextBox ID="TxtCodigo2" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="TxtNombre2" runat="server" Width="245px"></asp:TextBox>
                </td>
                <td class="auto-style3">
                    <asp:Button class="btn btn-success" ID="BtnSumar2" runat="server" Width="50px" OnClick="BtnSumar2_Click" />
                </td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:TextBox ID="TxtCodigo3" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="TxtNombre3" runat="server" Width="245px"></asp:TextBox>
                </td>
                <td class="auto-style3">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Button class="btn btn-success" ID="BtnMostrar" runat="server" Text="Mostrar" Width="100px" OnClick="BtnMostrar_Click"  PostBackUrl="~/GeneradordeCaratula.aspx"/>
                </td>
                <td class="auto-style5">
                    <asp:Button class="btn btn-success" ID="BtnLimpiar" runat="server" Text="Limpiar" Width="100px" />
                </td>
                <td class="auto-style6"></td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
