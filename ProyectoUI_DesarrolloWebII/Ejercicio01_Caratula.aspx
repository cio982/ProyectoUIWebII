<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio01_Caratula.aspx.cs" Inherits="ProyectoUI_DesarrolloWebII.Ejercicio01_Caratula" %>

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
</head>
<body>
    <style type="text/css">
        .text-align {
            center;
        }        
        .auto-style3 {
            width: 337px;
        }
    </style>
    <form id="form1" runat="server">
    <div>
    
        Ejercicio 01<br />
        <table style="width:45%;" align="center">
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style2">GENERADOR DE CARATULA</td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">UNIVERSIDAD:</td>
                <td class="auto-style2">
                    <asp:TextBox ID="TxtUniversidad" runat="server" Width="245px"></asp:TextBox>
                </td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">FACULTAD:</td>
                <td class="auto-style2">
                    <asp:TextBox ID="TxtFacultad" runat="server" Width="245px"></asp:TextBox>
                </td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">ESCUELA:</td>
                <td class="auto-style2">
                    <asp:TextBox ID="TxtEscuela" runat="server" Width="245px"></asp:TextBox>
                </td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">TIPO:</td>
                <td class="auto-style2">
                    <asp:RadioButtonList ID="RbtnTipo" runat="server">
                        <asp:ListItem>Trabajo</asp:ListItem>
                        <asp:ListItem>Informe</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">CICLO:</td>
                <td class="auto-style2">
                    <asp:DropDownList ID="DdlCiclo" runat="server" Height="20px" Width="140px">
                    </asp:DropDownList>
                </td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">CURSO:</td>
                <td class="auto-style2">
                    <asp:DropDownList ID="DdlCurso" runat="server" Height="20px" Width="250px">
                    </asp:DropDownList>
                </td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">DOCENTE:</td>
                <td class="auto-style2">
                    <asp:TextBox ID="TxtDocente" runat="server" Width="245px"></asp:TextBox>
                </td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">TITULO:</td>
                <td class="auto-style2">
                    <asp:TextBox ID="TxtTitulo" runat="server" Width="245px"></asp:TextBox>
                </td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">PRESENTACION:</td>
                <td class="auto-style2">
                    <asp:RadioButtonList ID="RbtnPresentacion" runat="server">
                        <asp:ListItem>Individual</asp:ListItem>
                        <asp:ListItem>Grupal</asp:ListItem>
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
                <td class="auto-style1">CODIGO</td>
                <td class="auto-style2">NOMBRE</td>
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
                    <asp:Button ID="BtnSumar" runat="server" Width="50px" />
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
                    <asp:Button ID="BtnSumar1" runat="server" Width="50px" />
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
                    <asp:Button ID="BtnSumar2" runat="server" Width="50px" />
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
                    <asp:Button ID="BtnSumar3" runat="server" Width="50px" />
                </td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Button ID="BtnMostrar" runat="server" Text="Mostrar" Width="100px" OnClick="BtnMostrar_Click" />
                </td>
                <td class="auto-style2">
                    <asp:Button ID="BtnLimpiar" runat="server" Text="Limpiar" Width="100px" />
                </td>
                <td class="auto-style3">&nbsp;</td>
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
