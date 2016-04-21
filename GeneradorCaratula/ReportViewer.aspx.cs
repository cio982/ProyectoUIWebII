using Microsoft.Reporting.WebForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GeneradorCaratula
{
    public partial class ReportViewer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            rvCaratula.LocalReport.ReportPath = @"C:\Users\Cio\Source\Repos\ProyectoUIWebII\GeneradorCaratula\Reporte.rdlc";

            if (PreviousPage != null)
            {
                //Recepcionar datos del PostBackUrl
                string universidad = ((TextBox)PreviousPage.FindControl("txtUniversidad")).Text;
               // string universidad = ((DropDownList)PreviousPage.FindControl("ddlUniversidad")).SelectedValue;



                //Crear los parámetros del ReportViewer         <nombre del parámetro>
                //                                              <en Reporte.rdlc>
                ReportParameter puniversidad = new ReportParameter("Universidad", universidad);



                //Cargar los parámetros del ReportViewer a Reporte.rdlc
                if (!IsPostBack)
                {
                    //Cargar parámetros
                    rvCaratula.LocalReport.SetParameters(new ReportParameter[] {
                        puniversidad//,pfacultad,pescuela,etc
                    });

                    //Imprimimos los parámetros
                    rvCaratula.LocalReport.Refresh();
                }

            }
        }
    }
}