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
    public partial class consulta_tipo : System.Web.UI.Page
    {
        string tipox;
        string idx;
        string URLdireccion = @"d:\Ficheros\";

        //HOARIO
        private ArrayList RegistrosHorario = new ArrayList();
        private Horario Horario = new Horario();

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
            tipox = Request.QueryString["tipo"];
            idx = Request.QueryString["id"];

            //CURSO
            RegistrosCurso = new ArrayList();
            Curso = new Curso();
            LeerCursos();

            //SALON
            RegistrosSalon = new ArrayList();
            Salon = new Salon();
            LeerSalon();

            //BLOQUE
            RegistrosBloque = new ArrayList();
            Bloque = new Bloque();
            LeerBloque();

            //DOCENTE
            RegistrosDocente = new ArrayList();
            Docente = new Docente();
            LeerDocente();

            //HOARIO
            RegistrosHorario = new ArrayList();
            Horario = new Horario();
            LeerHorario();

            MostrarHorarioTipo(tipox,idx);


        }
        private void LeerHorario()
        {
            //string fichero = @"d:\Ficheros\Horario.txt";
            string fichero = URLdireccion + "Horario.txt";

            try
            {
                StreamReader Lector = new StreamReader(fichero);
                String lineas = Lector.ReadLine();
                while (lineas != "null")
                {
                    Char[] delimitador = { ',' };
                    String[] palabras = lineas.Split(delimitador);

                    Horario h = new Horario();
                    h.ho_id = palabras[0];
                    h.ho_curso = palabras[1];
                    h.ho_docente = palabras[2];
                    h.ho_dia = palabras[3];
                    h.ho_salon = palabras[4];
                    h.ho_hinicio = palabras[5];
                    h.ho_hfinal = palabras[6];

                    RegistrosHorario.Add(h);
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
            //string fichero = @"d:\Ficheros\Curso.txt";
            string fichero = URLdireccion + "Curso.txt";

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
            //string fichero = @"d:\Ficheros\Salon.txt";
            string fichero = URLdireccion + "Salon.txt";
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
        private void LeerBloque()
        {
            //string fichero = @"d:\Ficheros\Bloque.txt";
            string fichero = URLdireccion + "Bloque.txt";
            try
            {
                StreamReader Lector = new StreamReader(fichero);
                String lineas = Lector.ReadLine();
                while (lineas != "null")
                {
                    Char[] delimitador = { ',' };
                    String[] palabras = lineas.Split(delimitador);
                    Bloque x = new Bloque();
                    x.blo_id = palabras[0];
                    x.blo_hora = palabras[1];

                    RegistrosBloque.Add(x);
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
            //string fichero = @"d:\Ficheros\Docente.txt";
            string fichero = URLdireccion + "Docente.txt";
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


        //BORRAR===================================
        //public void Mostrar_XHorario()
        //{
        //    //string fichero = @"d:\Ficheros\xhorario.txt";
        //    string fichero = URLdireccion + "xhorario.txt";
        //    String resultado = "";
        //    try
        //    {
        //        using (StreamReader lector = new StreamReader(fichero))
        //        {
        //            while (lector.Peek() > -1)
        //            {
        //                string linea = lector.ReadLine();
        //                if (!String.IsNullOrEmpty(linea))
        //                {
        //                    resultado = linea;
        //                    ImprimirHorario(linea);
        //                }
        //            }
        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        //Console.WriteLine("Error: " + ex.Message);

        //    }
        //}
        private void MostrarHorarioTipo(String tipo, String id)
        {
            switch (tipo)
            {
                case "1":
                    //Ciclo
                    foreach (object RegistrosCurso in RegistrosCurso)
                    {
                        //captura los cursos de un ciclo
                        Curso = (Curso)RegistrosCurso;
                        if (Curso.cur_ciclo == id)
                        {
                            string idcurso = Curso.cur_id;
                            //Proceso para imprimir los cursos por ciclo
                            foreach (object RegistrosHorario in RegistrosHorario)
                            {
                                Horario = (Horario)RegistrosHorario;
                                if (Horario.ho_curso == idcurso)
                                {
                                    String dia = Horario.ho_dia;
                                    String curso = Horario.ho_curso; ;
                                    String docente = Horario.ho_docente;
                                    String salon = Horario.ho_salon;
                                    String hora1 = Horario.ho_hinicio;
                                    String hora2 = Horario.ho_hfinal;

                                    DetallarPorDia(dia, curso, docente, salon, hora1, hora2);
                                }
                            }
                        }
                    }

                    
                    break;
                case "2":
                    //Docente
                    foreach (object RegistrosHorario in RegistrosHorario)
                    {
                        Horario = (Horario)RegistrosHorario;
                        if (Horario.ho_docente == id)
                        {
                            String dia = Horario.ho_dia;
                            String curso = Horario.ho_curso; ;
                            String docente = Horario.ho_docente;
                            String salon = Horario.ho_salon;
                            String hora1 = Horario.ho_hinicio;
                            String hora2 = Horario.ho_hfinal;

                            DetallarPorDia(dia, curso, docente, salon, hora1, hora2);
                        }
                    }
                    break;
                case "3":
                    //Curso
                    //ImprimirHorarioPorCurso(id);
                    foreach (object RegistrosHorario in RegistrosHorario)
                    {
                        Horario = (Horario)RegistrosHorario;
                        if (Horario.ho_curso == id)
                        {
                            String dia = Horario.ho_dia;
                            String curso = Horario.ho_curso; ;
                            String docente = Horario.ho_docente;
                            String salon = Horario.ho_salon;
                            String hora1 = Horario.ho_hinicio;
                            String hora2 = Horario.ho_hfinal;

                            DetallarPorDia(dia, curso, docente, salon, hora1, hora2);
                        }
                    }
                    break;
                case "4":
                    //Aula - Laboratorio
                    foreach (object RegistrosHorario in RegistrosHorario)
                    {
                        Horario = (Horario)RegistrosHorario;
                        if (Horario.ho_salon == id)
                        {
                            String dia = Horario.ho_dia;
                            String curso = Horario.ho_curso; ;
                            String docente = Horario.ho_docente;
                            String salon = Horario.ho_salon;
                            String hora1 = Horario.ho_hinicio;
                            String hora2 = Horario.ho_hfinal;

                            DetallarPorDia(dia, curso, docente, salon, hora1, hora2);
                        }
                    }
                    break;
                case "5":
                    //Dia
                    foreach (object RegistrosHorario in RegistrosHorario)
                    {
                        Horario = (Horario)RegistrosHorario;
                        if (Horario.ho_dia == id)
                        {
                            String dia = Horario.ho_dia;
                            String curso = Horario.ho_curso; ;
                            String docente = Horario.ho_docente;
                            String salon = Horario.ho_salon;
                            String hora1 = Horario.ho_hinicio;
                            String hora2 = Horario.ho_hfinal;

                            DetallarPorDia(dia, curso, docente, salon, hora1, hora2);
                        }
                    }
                    break;
                case "6":
                    //Disponibilidad libre

                    break;
            }
        }

        //Imprimir Horario por curso
        //private void ImprimirHorarioPorCurso(String idcurso)
        //{


        //    foreach (object RegistrosHorario in RegistrosHorario)
        //    {
        //        Horario = (Horario)RegistrosHorario;
        //        if (Horario.ho_curso == idcurso)
        //        {
        //            String dia = Horario.ho_dia;
        //            String curso = Horario.ho_curso; ;
        //            String docente = Horario.ho_docente;
        //            String salon = Horario.ho_salon;
        //            String hora1 = Horario.ho_hinicio;
        //            String hora2 = Horario.ho_hfinal;

        //            DetallarPorDia(dia, curso, docente, salon, hora1, hora2);
        //        }
        //    }
        //}


        private void DetallarPorDia(String dia, String curso, String docente, String salon, String hora1, String hora2)
        {
            //Datos del curso
            String nomcur = "";
            String colcur = "";
            String nomsalon = NombreSalon(salon);
            String horabloque1 = HoraBloque(hora1);
            String horabloque2 = HoraBloque(hora2);
            String nomdoc = NombreDocente(docente);

            //captura de nombre y color del curso
            foreach (object RegistrosCurso in RegistrosCurso)
            {
                Curso = (Curso)RegistrosCurso;
                if (Curso.cur_id == curso)
                {
                    nomcur = Curso.cur_nombre;
                    colcur = Curso.cur_color;
                }
            }

            DetallarItemHorario(dia,nomcur, colcur, nomsalon, horabloque1, horabloque2, nomdoc);
            

        }

        private void DetallarItemHorario(String dia, String nomcur, String colcur, String nomsalon, String horabloque1, String horabloque2, String nomdoc)
        {
            switch (dia)
            {
                case "1":
                    LblResultado1.Text += " <div class=\"cursos-item\" style=\"background: " + colcur + "; \">"
                                            + "<p>" + nomcur + "</p>"
                                          + "<span>" + nomsalon + "</span>"
                                          + "<span>" + horabloque1 + " - " + horabloque2 + "</span>"
                                          + "<span>" + nomdoc + "</span>"
                                          + "</div>";
                    break;
                case "2":
                    LblResultado2.Text += " <div class=\"cursos-item\" style=\"background: " + colcur + "; \">"
                                            + "<p>" + nomcur + "</p>"
                                          + "<span>" + nomsalon + "</span>"
                                          + "<span>" + horabloque1 + " - " + horabloque2 + "</span>"
                                          + "<span>" + nomdoc + "</span>"
                                          + "</div>";
                    break;
                case "3":
                    LblResultado3.Text += " <div class=\"cursos-item\" style=\"background: " + colcur + "; \">"
                                            + "<p>" + nomcur + "</p>"
                                          + "<span>" + nomsalon + "</span>"
                                          + "<span>" + horabloque1 + " - " + horabloque2 + "</span>"
                                          + "<span>" + nomdoc + "</span>"
                                          + "</div>";
                    break;
                case "4":
                    LblResultado4.Text += " <div class=\"cursos-item\" style=\"background: " + colcur + "; \">"
                                            + "<p>" + nomcur + "</p>"
                                          + "<span>" + nomsalon + "</span>"
                                          + "<span>" + horabloque1 + " - " + horabloque2 + "</span>"
                                          + "<span>" + nomdoc + "</span>"
                                          + "</div>";
                    break;
                case "5":
                    LblResultado5.Text += " <div class=\"cursos-item\" style=\"background: " + colcur + "; \">"
                                            + "<p>" + nomcur + "</p>"
                                          + "<span>" + nomsalon + "</span>"
                                          + "<span>" + horabloque1 + " - " + horabloque2 + "</span>"
                                          + "<span>" + nomdoc + "</span>"
                                          + "</div>";
                    break;
                case "6":
                    LblResultado6.Text += " <div class=\"cursos-item\" style=\"background: " + colcur + "; \">"
                                            + "<p>" + nomcur + "</p>"
                                          + "<span>" + nomsalon + "</span>"
                                          + "<span>" + horabloque1 + " - " + horabloque2 + "</span>"
                                          + "<span>" + nomdoc + "</span>"
                                          + "</div>";
                    break;
            }
        }
        private String NombreSalon(String id)
        {
            String nombre = "";
            foreach (object RegistrosSalon in RegistrosSalon)
            {
                Salon = (Salon)RegistrosSalon;
                if (Salon.salon_id == id)
                {
                    nombre = Salon.salon_nom;
                }
            }
            return nombre;
        }

        private String HoraBloque(String id)
        {
            String hora = "";
            foreach (object RegistrosBloque in RegistrosBloque)
            {
                Bloque = (Bloque)RegistrosBloque;
                if (Bloque.blo_id == id)
                {
                    hora = Bloque.blo_hora;
                }
            }
            return hora;
        }
        private String NombreDocente(String id)
        {
            String nombre = "";
            foreach (object RegistrosDocente in RegistrosDocente)
            {
                Docente = (Docente)RegistrosDocente;
                if (Docente.doc_id == id)
                {
                    nombre = Docente.doc_nombre + " " + Docente.doc_apellido;
                }
            }
            return nombre;
        }

    }
}