using Microsoft.Reporting.WebForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace ProyectoUI_DesarrolloWebII
{
    public partial class GeneradorCaratulaINF : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            rvCaratula.LocalReport.ReportPath = @"C:\web\ProyectoUIWebII\ProyectoUI_DesarrolloWebII\Reporte.rdlc";

            if (PreviousPage != null)
            {
                //Recepcionar datos del PostBackUrl
                string universidad = ((TextBox)PreviousPage.FindControl("TxtUniversidad")).Text;
                string facultad = ((TextBox)PreviousPage.FindControl("TxtFacultad")).Text;
                string escuela = ((TextBox)PreviousPage.FindControl("TxtEscuela")).Text;
                //string tipo = ((RadioButtonList)PreviousPage.FindControl("RbtnTipo")).SelectedValue;
                string ciclo = ((DropDownList)PreviousPage.FindControl("DdlCiclo")).SelectedValue;
                string curso = ((DropDownList)PreviousPage.FindControl("DdlCurso")).SelectedValue;
                string docente = ((TextBox)PreviousPage.FindControl("TxtDocente")).Text;
                ////string presentacion = ((RadioButtonList)PreviousPage.FindControl("RbtnPresentacion")).SelectedValue;
                string titulo = ((TextBox)PreviousPage.FindControl("TxtTitulo")).Text;

                string codigo = ((TextBox)PreviousPage.FindControl("TxtCodigo")).Text;
                string nombre = ((TextBox)PreviousPage.FindControl("TxtNombre")).Text;
                string codigo1 = ((TextBox)PreviousPage.FindControl("TxtCodigo1")).Text;
                string nombre1 = ((TextBox)PreviousPage.FindControl("TxtNombre1")).Text;
                string codigo2 = ((TextBox)PreviousPage.FindControl("TxtCodigo2")).Text;
                string nombre2 = ((TextBox)PreviousPage.FindControl("TxtNombre2")).Text;
                string codigo3 = ((TextBox)PreviousPage.FindControl("TxtCodigo3")).Text;
                string nombre3 = ((TextBox)PreviousPage.FindControl("TxtNombre3")).Text;

                //Crear los parámetros del ReportViewer         <nombre del parámetro>
                //                                              <en Reporte.rdlc>
                ReportParameter puniversidad = new ReportParameter("Universidad", universidad);
                ReportParameter pfacultad = new ReportParameter("Facultad", facultad);
                ReportParameter pescuela = new ReportParameter("Escuela", escuela);
                //ReportParameter ptipo = new ReportParameter("Tipo", tipo);
                ReportParameter pciclo = new ReportParameter("Ciclo", ciclo);
                ReportParameter pcurso = new ReportParameter("Curso", curso);
                ReportParameter pdocente = new ReportParameter("Docente", docente);
                ////ReportParameter ppresentacion = new ReportParameter("Presentacion", presentacion);
                ReportParameter ptitulo = new ReportParameter("Titulo", titulo);

                ReportParameter pcodigo = new ReportParameter("Codigo", codigo);
                ReportParameter pnombre = new ReportParameter("Nombre", nombre);
                ReportParameter pcodigo1 = new ReportParameter("Codigo1", codigo1);
                ReportParameter pnombre1 = new ReportParameter("Nombre1", nombre1);
                ReportParameter pcodigo2 = new ReportParameter("Codigo2", codigo2);
                ReportParameter pnombre2 = new ReportParameter("Nombre2", nombre2);
                ReportParameter pcodigo3 = new ReportParameter("Codigo3", codigo3);
                ReportParameter pnombre3 = new ReportParameter("Nombre3", nombre3);


                //Cargar los parámetros del ReportViewer a Reporte.rdlc
                if (!IsPostBack)
                {
                    //Cargar parámetros
                    rvCaratula.LocalReport.SetParameters(new ReportParameter[] {
                         puniversidad,pfacultad,pescuela,pciclo,pcurso,pdocente,pcodigo,pnombre,ptitulo
                    });

                    //Imprimimos los parámetros
                    rvCaratula.LocalReport.Refresh();
                }
            }
        }
    }
}