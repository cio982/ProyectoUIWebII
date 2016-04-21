using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ejercicio02
{
    public partial class consultar : System.Web.UI.Page
    {
        //Ciclo
        private ArrayList RegistrosCiclo = new ArrayList();
        private Ciclo Ciclo = new Ciclo();

        //CURSO
        private ArrayList RegistrosCurso = new ArrayList();
        private Curso Curso = new Curso();

        //SALON
        private ArrayList RegistrosSalon = new ArrayList();
        private Salon Salon = new Salon();

        //BLOQUE
        private ArrayList RegistrosBloque = new ArrayList();
        private Bloque Bloque = new Bloque();

        //DOCENTE
        private ArrayList RegistrosDocente = new ArrayList();
        private Docente Docente = new Docente();
        protected void Page_Load(object sender, EventArgs e)
        {
            //CICLO
            RegistrosCiclo = new ArrayList();
            Ciclo = new Ciclo();
            LeerCiclos();
            ImprimirCiclo();

            //CURSO
            RegistrosCurso = new ArrayList();
            Curso = new Curso();
            LeerCursos();
            ImprimirCurso();

            //SALON
            RegistrosSalon = new ArrayList();
            Salon = new Salon();
            LeerSalon();
            ImprimirSalon();

 

            //DOCENTE
            RegistrosDocente = new ArrayList();
            Docente = new Docente();
            LeerDocente();
            ImprimirDocente();
        }

        private void LeerCiclos()
        {
            string fichero = @"d:\Ficheros\Ciclo.txt";
            try
            {
                StreamReader Lector = new StreamReader(fichero);
                String lineas = Lector.ReadLine();
                while (lineas != "null")
                {
                    Char[] delimitador = { ',' };
                    String[] palabras = lineas.Split(delimitador);

                    Ciclo ci = new Ciclo();
                    ci.ciclo_id = palabras[0];

                    RegistrosCiclo.Add(ci);
                    lineas = Lector.ReadLine();
                }
                Lector.Close();
            }
            catch (Exception e)
            {

            }

        }
        private void LeerCursos()
        {
            string fichero = @"d:\Ficheros\Curso.txt";
            try
            {
                StreamReader Lector = new StreamReader(fichero);
                String lineas = Lector.ReadLine();
                while (lineas != "null")
                {
                    Char[] delimitador = { ',' };
                    String[] palabras = lineas.Split(delimitador);
                    Curso c = new Curso();
                    c.cur_id = palabras[0];
                    c.cur_ciclo = palabras[1];
                    c.cur_docente = palabras[2];
                    c.cur_nombre = palabras[3];
                    c.cur_color = palabras[4];
                    RegistrosCurso.Add(c);
                    lineas = Lector.ReadLine();
                }
                Lector.Close();
            }
            catch (Exception e)
            {

            }
        }
        private void LeerSalon()
        {
            string fichero = @"d:\Ficheros\Salon.txt";
            try
            {
                StreamReader Lector = new StreamReader(fichero);
                String lineas = Lector.ReadLine();
                while (lineas != "null")
                {
                    Char[] delimitador = { ',' };
                    String[] palabras = lineas.Split(delimitador);
                    Salon s = new Salon();
                    s.salon_id = palabras[0];
                    s.salon_tipo = palabras[1];
                    s.salon_nom = palabras[2];

                    RegistrosSalon.Add(s);
                    lineas = Lector.ReadLine();
                }
                Lector.Close();
            }
            catch (Exception e)
            {

            }
        }
 

        private void LeerDocente()
        {
            string fichero = @"d:\Ficheros\Docente.txt";
            try
            {
                StreamReader Lector = new StreamReader(fichero);
                String lineas = Lector.ReadLine();
                while (lineas != "null")
                {
                    Char[] delimitador = { ',' };
                    String[] palabras = lineas.Split(delimitador);
                    Docente x = new Docente();
                    x.doc_id = palabras[0];
                    x.doc_nombre = palabras[1];
                    x.doc_apellido = palabras[2];

                    RegistrosDocente.Add(x);
                    lineas = Lector.ReadLine();
                }
                Lector.Close();
            }
            catch (Exception e)
            {

            }
        }
        private void ImprimirCiclo()
        {

            foreach (object RegistrosCiclo in RegistrosCiclo)
            {
                Ciclo = (Ciclo)RegistrosCiclo;
                lblLista1.Text += "<li><a href=\"consulta_tipo.aspx?tipo=1&id="+Ciclo.ciclo_id+ "\">"+Ciclo.ciclo_id+"</a></li>";
                
            }
        }

        private void ImprimirCurso()
        {

            foreach (object RegistrosCurso in RegistrosCurso)
            {
                Curso = (Curso)RegistrosCurso;
                lblLista3.Text += "<li><a href=\"consulta_tipo.aspx?tipo=3&id=" + Curso.cur_id + "\">" + Curso.cur_nombre + "</a></li>";

            }
        }
        private void ImprimirSalon()
        {

            foreach (object RegistrosSalon in RegistrosSalon)
            {
                Salon = (Salon)RegistrosSalon;
                lblLista4.Text += "<li><a href=\"consulta_tipo.aspx?tipo=4&id=" + Salon.salon_id + "\">" + Salon.salon_nom + "</a></li>";

            }
        }
        private void ImprimirDocente()
        {

            foreach (object RegistrosDocente in RegistrosDocente)
            {
                Docente = (Docente)RegistrosDocente;
                lblLista2.Text += "<li><a href=\"consulta_tipo.aspx?tipo=2&id=" + Docente.doc_id + "\">" + Docente.doc_nombre + " "+Docente.doc_apellido+ "</a></li>";

            }
        }

    }
}