using Microsoft.Reporting.WebForms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoUI_DesarrolloWebII
{
    public partial class Ejercicio01_Caratula : System.Web.UI.Page
    {
        string rutadirectorio = "D:\\EJER3\\";
        string tipo = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            

            TxtUniversidad.Enabled = false;
            TxtFacultad.Enabled = false;
            TxtEscuela.Enabled = false;
            TxtDocente.Enabled = false;

            Ocultar();           

            /*datos genericos*/
            string rutaarchivo = rutadirectorio + "Datos.txt";
            string rutaarchivo2 = rutadirectorio + "Datos2.txt";
            string rutaarchivo3 = rutadirectorio + "Datos3.txt";
            /*ciclos*/
            string rutaarchivo4 = rutadirectorio + "ciclo.txt";
            /*cursos*/
            string rutaarchivo5 = rutadirectorio + "curso1.txt";
            string rutaarchivo6 = rutadirectorio + "curso2.txt";
            string rutaarchivo7 = rutadirectorio + "curso3.txt";
            string rutaarchivo8 = rutadirectorio + "curso4.txt";
            string rutaarchivo9 = rutadirectorio + "curso5.txt";
            string rutaarchivo10 = rutadirectorio + "curso6.txt";
            string rutaarchivo11 = rutadirectorio + "curso7.txt";
            string rutaarchivo12 = rutadirectorio + "curso8.txt";
            string rutaarchivo13 = rutadirectorio + "curso9.txt";
            string rutaarchivo14 = rutadirectorio + "curso10.txt";
            string rutaarchivo151 = rutadirectorio + "electivos.txt";
            /*docentes-cursos=66*/
            string rutaarchivo15 = rutadirectorio + "MATEMATICA I.txt";
            string rutaarchivo16 = rutadirectorio + "MATEMATICA BASICA I.txt";
            string rutaarchivo17 = rutadirectorio + "INTRODUCCION A LA INGENIERIA DE SISTEMAS.txt";
            string rutaarchivo18 = rutadirectorio + "DISEÑO EN INGENIERIA.txt";
            string rutaarchivo19 = rutadirectorio + "COMUNICACION ORAL Y ESCRITA.txt";
            string rutaarchivo20 = rutadirectorio + "METODOLOGIA DEL TRABAJO UNIVERSITARIO.txt";

            string rutaarchivo21 = rutadirectorio + "MATEMATICA II.txt";
            string rutaarchivo22 = rutadirectorio + "FISICA I.txt";
            string rutaarchivo221 = rutadirectorio + "TECNICAS DE PROGRAMACION.txt";
            string rutaarchivo23 = rutadirectorio + "ECONOMIA I.txt";
            string rutaarchivo24 = rutadirectorio + "ESTADISTICA I.txt";
            string rutaarchivo25 = rutadirectorio + "QUIMICA I.txt";

            string rutaarchivo26 = rutadirectorio + "MATEMATICA DISCRETA.txt";
            string rutaarchivo27 = rutadirectorio + "SISTEMAS ELECTRONICOS DIGITALES.txt";
            string rutaarchivo28 = rutadirectorio + "ALGORITMOS Y ESTRUCTURA DE DATOS.txt";
            string rutaarchivo29 = rutadirectorio + "DISEÑO Y MODELAMIENTO.txt";
            string rutaarchivo30 = rutadirectorio + "MODELO DE PROCESOS DE NEGOCIOS.txt";
            string rutaarchivo31 = rutadirectorio + "SISTEMAS DE INFORMACION.txt";

            string rutaarchivo32 = rutadirectorio + "INTRODUCCION AL DESARROLLO WEB.txt";
            string rutaarchivo33 = rutadirectorio + "ARQUITECTURA DEL COMPUTADOR.txt";
            string rutaarchivo34 = rutadirectorio + "PROGRAMACION I.txt";
            string rutaarchivo35 = rutadirectorio + "INGENIERIA ECONOMICA Y FINANCIERA.txt";
            string rutaarchivo36 = rutadirectorio + "INGENIERIA DE REQUERIMIENTOS.txt";
            string rutaarchivo37 = rutadirectorio + "PROGRAMACION ORIENTADA A OBJETOS.txt";

            string rutaarchivo38 = rutadirectorio + "DISEÑO DE BASE DE DATOS.txt";
            string rutaarchivo39 = rutadirectorio + "SISTEMAS OPERATIVOS I.txt";
            string rutaarchivo40 = rutadirectorio + "PROGRAMACION II.txt";
            string rutaarchivo41 = rutadirectorio + "INVESTIGACION DE OPERACIONES.txt";
            string rutaarchivo42 = rutadirectorio + "DISEÑO Y ARQUITECTURA DE SOFTWARE.txt";
            string rutaarchivo43 = rutadirectorio + "INTERACCION Y DISEÑO DE INTERFACES.txt";

            string rutaarchivo44 = rutadirectorio + "BASE DE DATOS I.txt";
            string rutaarchivo45 = rutadirectorio + "SISTEMAS OPERATIVOS II.txt";
            string rutaarchivo46 = rutadirectorio + "PROGRAMACION III.txt";
            string rutaarchivo47 = rutadirectorio + "DESARROLLO DE APLICACIONES WEB I.txt";
            string rutaarchivo48 = rutadirectorio + "INGENIERIA DE SOFTWARE.txt";
            string rutaarchivo49 = rutadirectorio + "ETICA PROFECIONAL.txt";

            string rutaarchivo50 = rutadirectorio + "BASE DE DATOS II.txt";
            string rutaarchivo51 = rutadirectorio + "REDES Y COMUNICACIONES DE DATOS I.txt";
            string rutaarchivo52 = rutadirectorio + "SOLUCIONES MOVILES I.txt";
            string rutaarchivo53 = rutadirectorio + "CALIDAD Y PRUEBAS DE SOFTWARE.txt";
            string rutaarchivo54 = rutadirectorio + "GESTION DE PROYECTOS DE TI.txt";

            string rutaarchivo55 = rutadirectorio + "DESARROLLO DE APLICACIONES WEB II,.txt";
            string rutaarchivo56 = rutadirectorio + "REDES Y COMUNICACIONES DE DATOS II.txt";
            string rutaarchivo57 = rutadirectorio + "INGLES TECNICO.txt";
            string rutaarchivo58 = rutadirectorio + "INTELIGENCIA DE NEGOCIOS.txt";
            string rutaarchivo59 = rutadirectorio + "SEGURIDAD INFORMATICA.txt";

            string rutaarchivo60 = rutadirectorio + "GESTION DE LA CONFIGURACION Y ADMINISTRACION DE SOFTWARE.txt";
            string rutaarchivo61 = rutadirectorio + "REDES Y COMUNICACIONES DE DATOS III.txt";
            string rutaarchivo62 = rutadirectorio + "PLANEAMIENTO ESTRATEGICO DE TI.txt";
            string rutaarchivo63 = rutadirectorio + "CONSTRUCCION DE SOFTWARE I.txt";
            string rutaarchivo64 = rutadirectorio + "AUDITORIA DE SISTEMAS.txt";
            string rutaarchivo65 = rutadirectorio + "METODOLOGIA DE LA INVESTIGACION APLICADA.txt";

            string rutaarchivo66 = rutadirectorio + "TALLER DE LIDERAZGO Y ENPRENDIMIENTO.txt";
            string rutaarchivo67 = rutadirectorio + "TALLER DE REDES Y COMUNICACION DE DATOS.txt";
            string rutaarchivo68 = rutadirectorio + "TALLER DE TESIS.txt";
            string rutaarchivo69 = rutadirectorio + "CONSTRUCCION DE SOFTWARE II.txt";
            string rutaarchivo70 = rutadirectorio + "GERENCIA DE TI.txt";

            string rutaarchivo71 = rutadirectorio + "MEDIO AMBIENTE Y DESARROLLO SOSTENIBLE.txt";
            string rutaarchivo72 = rutadirectorio + "CONTABILIDAD GENERAL.txt";
            string rutaarchivo73 = rutadirectorio + "PATRONES DE SOFTWARE.txt";
            string rutaarchivo74 = rutadirectorio + "DERECHO INFORMATICO.txt";
            string rutaarchivo75 = rutadirectorio + "DISEÑO Y CREACION DE VIDEOJUEGOS.txt";
            string rutaarchivo76 = rutadirectorio + "NEGOCIOS Y MARKETING POR INTERNET,.txt";
            string rutaarchivo77 = rutadirectorio + "TOPICOS DE BASE DE DATOS AVANZADOS.txt";
            string rutaarchivo78 = rutadirectorio + "SISTEMA DE INFORMACION DE BANCA Y FINANZAS.txt";
            string rutaarchivo79 = rutadirectorio + "SOLUCIONES MOVILES II.txt";
            /**/

            /*//////////////////////////////////////////////////////////////////////////////////////////datos*/
            if (!File.Exists(rutadirectorio))
            {
                string directorio = Path.Combine(rutadirectorio);
                Directory.CreateDirectory(directorio);
            }

            if (!File.Exists(rutaarchivo))
            {
                FileStream archivo = new FileStream(rutaarchivo, FileMode.Create);
                using (StreamWriter w = new StreamWriter(archivo))
                {
                    w.Write("UNIVERSIDAD PRIVADA DE TACNA");
                }
            }

            if (!File.Exists(rutaarchivo2))
            {
                FileStream archivo2 = new FileStream(rutaarchivo2, FileMode.Create);
                using (StreamWriter w = new StreamWriter(archivo2))
                {
                    w.Write("FACULTADA DE INGENIERIA");
                }
            }

            if (!File.Exists(rutaarchivo3))
            {
                FileStream archivo3 = new FileStream(rutaarchivo3, FileMode.Create);
                using (StreamWriter w = new StreamWriter(archivo3))
                {
                    w.Write("ESCUELA PROFESIONAL DE INGENIERIA DE SISTEMAS");
                }
            }

            /*////////////////////////////////////////////////////////////////////////////////////////////ciclos*/
            if (!File.Exists(rutaarchivo4))
            {
                FileStream archivo4 = new FileStream(rutaarchivo4, FileMode.Create);
                using (StreamWriter w = new StreamWriter(archivo4))
                {
                    w.Write("I Ciclo,II Ciclo,III Ciclo,IV Ciclo,V Ciclo,VI Ciclo,VII Ciclo,VIII Ciclo,IX Ciclo,X Ciclo,Electivos");
                }
            }

            if (!File.Exists(rutaarchivo5))
            {
                FileStream archivo5 = new FileStream(rutaarchivo5, FileMode.Create);
                using (StreamWriter w = new StreamWriter(archivo5))
                {
                    w.Write("MATEMATICA I,MATEMATICA BASICA I,INTRODUCCION A LA INGENIERIA DE SISTEMAS,DISEÑO EN INGENIERIA,COMUNICACION ORAL Y ESCRITA,METODOLOGIA DEL TRABAJO UNIVERSITARIO");
                }
            }

            if (!File.Exists(rutaarchivo6))
            {
                FileStream archivo6 = new FileStream(rutaarchivo6, FileMode.Create);
                using (StreamWriter w = new StreamWriter(archivo6))
                {
                    w.Write("MATEMATICA II,FISICA I,TECNICAS DE PROGRAMACION,ECONOMIA I,ESTADISTICA I,QUIMICA I");
                }
            }

            if (!File.Exists(rutaarchivo7))
            {
                FileStream archivo7 = new FileStream(rutaarchivo7, FileMode.Create);
                using (StreamWriter w = new StreamWriter(archivo7))
                {
                    w.Write("MATEMATICA DISCRETA,SISTEMAS ELECTRONICOS DIGITALES,ALGORITMOS Y ESTRUCTURA DE DATOS,DISEÑO Y MODELAMIENTO,MODELO DE PROCESOS DE NEGOCIOS,SISTEMAS DE INFORMACION");
                }
            }

            if (!File.Exists(rutaarchivo8))
            {
                FileStream archivo8 = new FileStream(rutaarchivo8, FileMode.Create);
                using (StreamWriter w = new StreamWriter(archivo8))
                {
                    w.Write("INTRODUCCION AL DESARROLLO WEB,ARQUITECTURA DEL COMPUTADOR,PROGRAMACION I,INGENIERIA ECONOMICA Y FINANCIERA,INGENIERIA DE REQUERIMIENTOS,PROGRAMACION ORIENTADA A OBJETOS");
                }
            }

            if (!File.Exists(rutaarchivo9))
            {
                FileStream archivo9 = new FileStream(rutaarchivo9, FileMode.Create);
                using (StreamWriter w = new StreamWriter(archivo9))
                {
                    w.Write("DISEÑO DE BASE DE DATOS,SISTEMAS OPERATIVOS I,PROGRAMACION II,INVESTIGACION DE OPERACIONES,DISEÑO Y ARQUITECTURA DE SOFTWARE,INTERACCION Y DISEÑO DE INTERFACES");
                }
            }

            if (!File.Exists(rutaarchivo10))
            {
                FileStream archivo10 = new FileStream(rutaarchivo10, FileMode.Create);
                using (StreamWriter w = new StreamWriter(archivo10))
                {
                    w.Write("BASE DE DATOS I,SISTEMAS OPERATIVOS II,PROGRAMACION III,DESARROLLO DE APLICACIONES WEB I,INGENIERIA DE SOFTWARE,ETICA PROFECIONAL");
                }
            }

            if (!File.Exists(rutaarchivo11))
            {
                FileStream archivo11 = new FileStream(rutaarchivo11, FileMode.Create);
                using (StreamWriter w = new StreamWriter(archivo11))
                {
                    w.Write("BASE DE DATOS II,REDES Y COMUNICACIONES DE DATOS I,SOLUCIONES MOVILES I,CALIDAD Y PRUEBAS DE SOFTWARE,GESTION DE PROYECTOS DE TI");
                }
            }

            if (!File.Exists(rutaarchivo12))
            {
                FileStream archivo12 = new FileStream(rutaarchivo12, FileMode.Create);
                using (StreamWriter w = new StreamWriter(archivo12))
                {
                    w.Write("DESARROLLO DE APLICACIONES WEB II,REDES Y COMUNICACIONES DE DATOS II,INGLES TECNICO,INTELIGENCIA DE NEGOCIOS,SEGURIDAD INFORMATICA");
                }
            }

            if (!File.Exists(rutaarchivo13))
            {
                FileStream archivo13 = new FileStream(rutaarchivo13, FileMode.Create);
                using (StreamWriter w = new StreamWriter(archivo13))
                {
                    w.Write("GESTION DE LA CONFIGURACION Y ADMINISTRACION DE SOFTWARE,REDES Y COMUNICACIONES DE DATOS III,PLANEAMIENTO ESTRATEGICO DE TI,CONSTRUCCION DE SOFTWARE I,AUDITORIA DE SISTEMAS,METODOLOGIA DE LA INVESTIGACION APLICADA");
                }
            }

            if (!File.Exists(rutaarchivo14))
            {
                FileStream archivo14 = new FileStream(rutaarchivo14, FileMode.Create);
                using (StreamWriter w = new StreamWriter(archivo14))
                {
                    w.Write("TALLER DE LIDERAZGO Y ENPRENDIMIENTO,TALLER DE REDES Y COMUNICACION DE DATOS,TALLER DE TESIS,CONSTRUCCION DE SOFTWARE II,GERENCIA DE TI");
                }
            }

            if (!File.Exists(rutaarchivo151))
            {
                FileStream archivo151 = new FileStream(rutaarchivo151, FileMode.Create);
                using (StreamWriter w = new StreamWriter(archivo151))
                {
                    w.Write("MEDIO AMBIENTE Y DESARROLLO SOSTENIBLE,CONTABILIDAD GENERAL,PATRONES DE SOFTWARE,DERECHO INFORMATICO,DISEÑO Y CREACION DE VIDEOJUEGOS,NEGOCIOS Y MARKETING POR INTERNET,TOPICOS DE BASE DE DATOS AVANZADOS,SISTEMA DE INFORMACION DE BANCA Y FINANZAS,SOLUCIONES MOVILES II");
                }
            }

            /*////////////////////////////////////////////////////////////////////////////////////////////docentes*/
            if (!File.Exists(rutaarchivo15))
            {
                FileStream archivo15 = new FileStream(rutaarchivo15, FileMode.Create);
                using (StreamWriter w = new StreamWriter(archivo15))
                {
                    w.Write("Javier Alca Gomez");
                }
            }

            if (!File.Exists(rutaarchivo16))
            {
                FileStream archivo16 = new FileStream(rutaarchivo16, FileMode.Create);
                using (StreamWriter w = new StreamWriter(archivo16))
                {
                    w.Write("Silvia Centella Vildoso");
                }
            }

            if (!File.Exists(rutaarchivo17))
            {
                FileStream archivo17 = new FileStream(rutaarchivo17, FileMode.Create);
                using (StreamWriter w = new StreamWriter(archivo17))
                {
                    w.Write("Tito Ale Nieto");
                }
            }

            if (!File.Exists(rutaarchivo18))
            {
                FileStream archivo18 = new FileStream(rutaarchivo18, FileMode.Create);
                using (StreamWriter w = new StreamWriter(archivo18))
                {
                    w.Write("Elard Rodriguez Marca");
                }
            }

            if (!File.Exists(rutaarchivo19))
            {
                FileStream archivo19 = new FileStream(rutaarchivo19, FileMode.Create);
                using (StreamWriter w = new StreamWriter(archivo19))
                {
                    w.Write("Americo Alca Gomez");
                }
            }

            if (!File.Exists(rutaarchivo20))
            {
                FileStream archivo20 = new FileStream(rutaarchivo20, FileMode.Create);
                using (StreamWriter w = new StreamWriter(archivo20))
                {
                    w.Write("Yanira Valdivia");
                }
            }
                                                                                    /******************************************/
            if (!File.Exists(rutaarchivo21))
            {
                FileStream archivo21 = new FileStream(rutaarchivo21, FileMode.Create);
                using (StreamWriter w = new StreamWriter(archivo21))
                {
                    w.Write("Silvia Centella Vildoso");
                }
            }

            if (!File.Exists(rutaarchivo22))
            {
                FileStream archivo22 = new FileStream(rutaarchivo22, FileMode.Create);
                using (StreamWriter w = new StreamWriter(archivo22))
                {
                    w.Write("Jenny Huayta Curo");
                }
            }

            if (!File.Exists(rutaarchivo221))
            {
                FileStream archivo221 = new FileStream(rutaarchivo221, FileMode.Create);
                using (StreamWriter w = new StreamWriter(archivo221))
                {
                    w.Write("Haydee Raquel Sisa Yataco");
                }
            }

            if (!File.Exists(rutaarchivo23))
            {
                FileStream archivo23 = new FileStream(rutaarchivo23, FileMode.Create);
                using (StreamWriter w = new StreamWriter(archivo23))
                {
                    w.Write("Liliana Vega Bernal");
                }
            }

            if (!File.Exists(rutaarchivo24))
            {
                FileStream archivo24 = new FileStream(rutaarchivo24, FileMode.Create);
                using (StreamWriter w = new StreamWriter(archivo24))
                {
                    w.Write("Minelly Martinez Peñaloza");
                }
            }

            if (!File.Exists(rutaarchivo25))
            {
                FileStream archivo25 = new FileStream(rutaarchivo25, FileMode.Create);
                using (StreamWriter w = new StreamWriter(archivo25))
                {
                    w.Write("Vicente Malaga");
                }
            }
                                                                                           /******************************************/
            if (!File.Exists(rutaarchivo26))
            {
                FileStream archivo26 = new FileStream(rutaarchivo26, FileMode.Create);
                using (StreamWriter w = new StreamWriter(archivo26))
                {
                    w.Write("Javier Alca Gomez");
                }
            }

            if (!File.Exists(rutaarchivo27))
            {
                FileStream archivo27 = new FileStream(rutaarchivo27, FileMode.Create);
                using (StreamWriter w = new StreamWriter(archivo27))
                {
                    w.Write("Jenny Huayta Curo");
                }
            }

            if (!File.Exists(rutaarchivo28))
            {
                FileStream archivo28 = new FileStream(rutaarchivo28, FileMode.Create);
                using (StreamWriter w = new StreamWriter(archivo28))
                {
                    w.Write("Marcia Martinez Salamanca");
                }
            }

            if (!File.Exists(rutaarchivo29))
            {
                FileStream archivo29 = new FileStream(rutaarchivo29, FileMode.Create);
                using (StreamWriter w = new StreamWriter(archivo29))
                {
                    w.Write("Maria Chambilla");
                }
            }

            if (!File.Exists(rutaarchivo30))
            {
                FileStream archivo30 = new FileStream(rutaarchivo30, FileMode.Create);
                using (StreamWriter w = new StreamWriter(archivo30))
                {
                    w.Write("Haydee Raquel Sisa Yataco");
                }
            }

            if (!File.Exists(rutaarchivo31))
            {
                FileStream archivo31 = new FileStream(rutaarchivo31, FileMode.Create);
                using (StreamWriter w = new StreamWriter(archivo31))
                {
                    w.Write("Minelly Martinez Peñaloza");
                }
            }
                                                                                           /******************************************/
            if (!File.Exists(rutaarchivo32))
            {
                FileStream archivo32 = new FileStream(rutaarchivo32, FileMode.Create);
                using (StreamWriter w = new StreamWriter(archivo32))
                {
                    w.Write("Tito Ale Nieto");
                }
            }

            if (!File.Exists(rutaarchivo33))
            {
                FileStream archivo33 = new FileStream(rutaarchivo33, FileMode.Create);
                using (StreamWriter w = new StreamWriter(archivo33))
                {
                    w.Write("Henry Chaiña");
                }
            }

            if (!File.Exists(rutaarchivo34))
            {
                FileStream archivo34 = new FileStream(rutaarchivo34, FileMode.Create);
                using (StreamWriter w = new StreamWriter(archivo34))
                {
                    w.Write("Elard Rodriguez Marca");
                }
            }

            if (!File.Exists(rutaarchivo35))
            {
                FileStream archivo35 = new FileStream(rutaarchivo35, FileMode.Create);
                using (StreamWriter w = new StreamWriter(archivo35))
                {
                    w.Write("Liliana Vega Bernal");
                }
            }

            if (!File.Exists(rutaarchivo36))
            {
                FileStream archivo36 = new FileStream(rutaarchivo36, FileMode.Create);
                using (StreamWriter w = new StreamWriter(archivo36))
                {
                    w.Write("Mariella Ibarra Montesinos");
                }
            }

            if (!File.Exists(rutaarchivo37))
            {
                FileStream archivo37 = new FileStream(rutaarchivo37, FileMode.Create);
                using (StreamWriter w = new StreamWriter(archivo37))
                {
                    w.Write("Jesus Tejerina Rivera");
                }
            }
                                                                                           /******************************************/
            if (!File.Exists(rutaarchivo38))
            {
                FileStream archivo38 = new FileStream(rutaarchivo38, FileMode.Create);
                using (StreamWriter w = new StreamWriter(archivo38))
                {
                    w.Write("Haydee Raquel Sisa Yataco");
                }
            }

            if (!File.Exists(rutaarchivo39))
            {
                FileStream archivo39 = new FileStream(rutaarchivo39, FileMode.Create);
                using (StreamWriter w = new StreamWriter(archivo39))
                {
                    w.Write("Enrique Lanchipa Valencia");
                }
            }

            if (!File.Exists(rutaarchivo40))
            {
                FileStream archivo40 = new FileStream(rutaarchivo40, FileMode.Create);
                using (StreamWriter w = new StreamWriter(archivo40))
                {
                    w.Write("Jesus Tejerina Rivera");
                }
            }

            if (!File.Exists(rutaarchivo41))
            {
                FileStream archivo41 = new FileStream(rutaarchivo41, FileMode.Create);
                using (StreamWriter w = new StreamWriter(archivo41))
                {
                    w.Write("Minelly Martinez Peñaloza");
                }
            }

            if (!File.Exists(rutaarchivo42))
            {
                FileStream archivo42 = new FileStream(rutaarchivo42, FileMode.Create);
                using (StreamWriter w = new StreamWriter(archivo42))
                {
                    w.Write("Mariella Ibarra Montesinos");
                }
            }

            if (!File.Exists(rutaarchivo43))
            {
                FileStream archivo43 = new FileStream(rutaarchivo43, FileMode.Create);
                using (StreamWriter w = new StreamWriter(archivo43))
                {
                    w.Write("Elard Rodriguez Marca");
                }
            }
                                                                                           /******************************************/
            if (!File.Exists(rutaarchivo44))
            {
                FileStream archivo44 = new FileStream(rutaarchivo44, FileMode.Create);
                using (StreamWriter w = new StreamWriter(archivo44))
                {
                    w.Write("Carlos Ruiz Cancino");
                }
            }

            if (!File.Exists(rutaarchivo45))
            {
                FileStream archivo45 = new FileStream(rutaarchivo45, FileMode.Create);
                using (StreamWriter w = new StreamWriter(archivo45))
                {
                    w.Write("Henry Chaiña");
                }
            }

            if (!File.Exists(rutaarchivo46))
            {
                FileStream archivo46 = new FileStream(rutaarchivo46, FileMode.Create);
                using (StreamWriter w = new StreamWriter(archivo46))
                {
                    w.Write("Enrique Lanchipa Valencia");
                }
            }

            if (!File.Exists(rutaarchivo47))
            {
                FileStream archivo47 = new FileStream(rutaarchivo47, FileMode.Create);
                using (StreamWriter w = new StreamWriter(archivo47))
                {
                    w.Write("Tito Ale Nieto");
                }
            }

            if (!File.Exists(rutaarchivo48))
            {
                FileStream archivo48 = new FileStream(rutaarchivo48, FileMode.Create);
                using (StreamWriter w = new StreamWriter(archivo48))
                {
                    w.Write("Martha Paredes Vignola");
                }
            }

            if (!File.Exists(rutaarchivo49))
            {
                FileStream archivo49 = new FileStream(rutaarchivo49, FileMode.Create);
                using (StreamWriter w = new StreamWriter(archivo49))
                {
                    w.Write("Liliana Vega Bernal");
                }
            }
                                                                                           /******************************************/
            if (!File.Exists(rutaarchivo50))
            {
                FileStream archivo50 = new FileStream(rutaarchivo50, FileMode.Create);
                using (StreamWriter w = new StreamWriter(archivo50))
                {
                    w.Write("Patrick Cuadros Quiroga");
                }
            }

            if (!File.Exists(rutaarchivo51))
            {
                FileStream archivo51 = new FileStream(rutaarchivo51, FileMode.Create);
                using (StreamWriter w = new StreamWriter(archivo51))
                {
                    w.Write("Ricardo Sante Zavaleta");
                }
            }

            if (!File.Exists(rutaarchivo52))
            {
                FileStream archivo52 = new FileStream(rutaarchivo52, FileMode.Create);
                using (StreamWriter w = new StreamWriter(archivo52))
                {
                    w.Write("Alberto Flor Rodriguez");
                }
            }

            if (!File.Exists(rutaarchivo53))
            {
                FileStream archivo53 = new FileStream(rutaarchivo53, FileMode.Create);
                using (StreamWriter w = new StreamWriter(archivo53))
                {
                    w.Write("Rafael Poma Laura	");
                }
            }

            if (!File.Exists(rutaarchivo54))
            {
                FileStream archivo54 = new FileStream(rutaarchivo54, FileMode.Create);
                using (StreamWriter w = new StreamWriter(archivo54))
                {
                    w.Write("Martha Paredes Vignola");
                }
            }
                                                                                           /******************************************/
            if (!File.Exists(rutaarchivo55))
            {
                FileStream archivo55 = new FileStream(rutaarchivo55, FileMode.Create);
                using (StreamWriter w = new StreamWriter(archivo55))
                {
                    w.Write("Enrique Lanchipa Valencia");
                }
            }

            if (!File.Exists(rutaarchivo56))
            {
                FileStream archivo56 = new FileStream(rutaarchivo56, FileMode.Create);
                using (StreamWriter w = new StreamWriter(archivo56))
                {
                    w.Write("Henry Chaiña");
                }
            }

            if (!File.Exists(rutaarchivo57))
            {
                FileStream archivo57 = new FileStream(rutaarchivo57, FileMode.Create);
                using (StreamWriter w = new StreamWriter(archivo57))
                {
                    w.Write("Merla Pilco");
                }
            }

            if (!File.Exists(rutaarchivo58))
            {
                FileStream archivo58 = new FileStream(rutaarchivo58, FileMode.Create);
                using (StreamWriter w = new StreamWriter(archivo58))
                {
                    w.Write("Carlos Ruiz Cancino");
                }
            }

            if (!File.Exists(rutaarchivo59))
            {
                FileStream archivo59 = new FileStream(rutaarchivo59, FileMode.Create);
                using (StreamWriter w = new StreamWriter(archivo59))
                {
                    w.Write("Alberto Flor Rodriguez");
                }
            }
                                                                                           /******************************************/
            if (!File.Exists(rutaarchivo60))
            {
                FileStream archivo60 = new FileStream(rutaarchivo60, FileMode.Create);
                using (StreamWriter w = new StreamWriter(archivo60))
                {
                    w.Write("Ricardo Valcárcel Alvarado");
                }
            }

            if (!File.Exists(rutaarchivo61))
            {
                FileStream archivo61 = new FileStream(rutaarchivo61, FileMode.Create);
                using (StreamWriter w = new StreamWriter(archivo61))
                {
                    w.Write("Martin Alcántara");
                }
            }

            if (!File.Exists(rutaarchivo62))
            {
                FileStream archivo62 = new FileStream(rutaarchivo62, FileMode.Create);
                using (StreamWriter w = new StreamWriter(archivo62))
                {
                    w.Write("Rafael Poma Laura	");
                }
            }

            if (!File.Exists(rutaarchivo63))
            {
                FileStream archivo63 = new FileStream(rutaarchivo63, FileMode.Create);
                using (StreamWriter w = new StreamWriter(archivo63))
                {
                    w.Write("Rodolfo Alanoca Llanos");
                }
            }

            if (!File.Exists(rutaarchivo64))
            {
                FileStream archivo64 = new FileStream(rutaarchivo64, FileMode.Create);
                using (StreamWriter w = new StreamWriter(archivo64))
                {
                    w.Write("Roberto Liendo Huabloche");
                }
            }

            if (!File.Exists(rutaarchivo65))
            {
                FileStream archivo65 = new FileStream(rutaarchivo65, FileMode.Create);
                using (StreamWriter w = new StreamWriter(archivo65))
                {
                    w.Write("Erbert Osco Mamani");
                }
            }
                                                                                           /******************************************/
            if (!File.Exists(rutaarchivo66))
            {
                FileStream archivo66 = new FileStream(rutaarchivo66, FileMode.Create);
                using (StreamWriter w = new StreamWriter(archivo66))
                {
                    w.Write("Minelly Martinez Peñaloza");
                }
            }

            if (!File.Exists(rutaarchivo67))
            {
                FileStream archivo67 = new FileStream(rutaarchivo67, FileMode.Create);
                using (StreamWriter w = new StreamWriter(archivo67))
                {
                    w.Write("Martin Alcántara");
                }
            }

            if (!File.Exists(rutaarchivo68))
            {
                FileStream archivo68 = new FileStream(rutaarchivo68, FileMode.Create);
                using (StreamWriter w = new StreamWriter(archivo68))
                {
                    w.Write("Luis Fernandez");
                }
            }

            if (!File.Exists(rutaarchivo69))
            {
                FileStream archivo69 = new FileStream(rutaarchivo69, FileMode.Create);
                using (StreamWriter w = new StreamWriter(archivo69))
                {
                    w.Write("Rodolfo Alanoca Llanos");
                }
            }

            if (!File.Exists(rutaarchivo70))
            {
                FileStream archivo70 = new FileStream(rutaarchivo70, FileMode.Create);
                using (StreamWriter w = new StreamWriter(archivo70))
                {
                    w.Write("Ricardo Valcárcel Alvarado");
                }
            }
                                                                                           /******************************************/
            if (!File.Exists(rutaarchivo71))
            {
                FileStream archivo71 = new FileStream(rutaarchivo71, FileMode.Create);
                using (StreamWriter w = new StreamWriter(archivo71))
                {
                    w.Write("Liliana Vega Bernal");
                }
            }

            if (!File.Exists(rutaarchivo72))
            {
                FileStream archivo72 = new FileStream(rutaarchivo72, FileMode.Create);
                using (StreamWriter w = new StreamWriter(archivo72))
                {
                    w.Write("Docente Invitado");
                }
            }

            if (!File.Exists(rutaarchivo73))
            {
                FileStream archivo73 = new FileStream(rutaarchivo73, FileMode.Create);
                using (StreamWriter w = new StreamWriter(archivo73))
                {
                    w.Write("Docente Invitado");
                }
            }

            if (!File.Exists(rutaarchivo74))
            {
                FileStream archivo74 = new FileStream(rutaarchivo74, FileMode.Create);
                using (StreamWriter w = new StreamWriter(archivo74))
                {
                    w.Write("Carlos Pajuelo Beltran");
                }
            }

            if (!File.Exists(rutaarchivo75))
            {
                FileStream archivo75 = new FileStream(rutaarchivo75, FileMode.Create);
                using (StreamWriter w = new StreamWriter(archivo75))
                {
                    w.Write("Docente Invitado");
                }
            }

            if (!File.Exists(rutaarchivo76))
            {
                FileStream archivo76 = new FileStream(rutaarchivo76, FileMode.Create);
                using (StreamWriter w = new StreamWriter(archivo76))
                {
                    w.Write("Jesus Tejerina Rivera");
                }
            }

            if (!File.Exists(rutaarchivo77))
            {
                FileStream archivo77 = new FileStream(rutaarchivo77, FileMode.Create);
                using (StreamWriter w = new StreamWriter(archivo77))
                {
                    w.Write("Patrick Cuadros Quiroga");
                }
            }

            if (!File.Exists(rutaarchivo78))
            {
                FileStream archivo78 = new FileStream(rutaarchivo78, FileMode.Create);
                using (StreamWriter w = new StreamWriter(archivo78))
                {
                    w.Write("Rodolfo Alanoca Llanos");
                }
            }

            if (!File.Exists(rutaarchivo79))
            {    
                FileStream archivo79 = new FileStream(rutaarchivo79, FileMode.Create);
                using (StreamWriter w = new StreamWriter(archivo79))
                {               
                    w.Write("Alberto Flor Rodriguez");
                }
            }
/*-------------------------------------------------lecturas-----------------------------------------------*/
            string mensajeCi = "";
            string lineCi;

            if (File.Exists(rutaarchivo4))
            {
                if(DdlCiclo.Items.Count <= 0)
                {
                    StreamReader datoci = new StreamReader(rutaarchivo4);

                    while ((lineCi = datoci.ReadLine()) != null)
                    {
                        mensajeCi = lineCi;
                    }

                    char sepCi = ',';

                    string[] cCi = mensajeCi.Split(sepCi);

                    // DdlCiclo.Items.Clear();

                    for (int i = 0; i < cCi.Length; i++)
                    {
                        DdlCiclo.Items.Add(cCi[i]);
                    }
                }                
            }
            else
            {
                
            }

            if (File.Exists(rutaarchivo))
            {
                string line1;
                StreamReader dato = new StreamReader(rutaarchivo);
                string uni = "";

                while ((line1 = dato.ReadLine()) != null)
                {
                    uni = line1;
                }

                TxtUniversidad.Text = uni;
            }
            else
            {
               
            }

            if (File.Exists(rutaarchivo2))
            {
                string line2;
                StreamReader dato = new StreamReader(rutaarchivo2);
                string fac = "";

                while ((line2 = dato.ReadLine()) != null)
                {
                    fac = line2;
                }

                TxtFacultad.Text = fac;
            }
            else
            {
               
            }

            if (File.Exists(rutaarchivo3))
            {
                string line3;
                StreamReader dato = new StreamReader(rutaarchivo3);
                string esc = "";

                while ((line3 = dato.ReadLine()) != null)
                {
                    esc = line3;
                }

                TxtEscuela.Text = esc;
            }
            else
            {
               
            }
            

        }

        void Ocultar()
        {
            BtnSumar.Visible = false;
            TxtCodigo1.Visible = false;
            TxtCodigo2.Visible = false;
            TxtCodigo3.Visible = false;
            TxtNombre1.Visible = false;
            TxtNombre2.Visible = false;
            TxtNombre3.Visible = false;

            BtnSumar1.Visible = false;
            BtnSumar2.Visible = false;
        }

        void TipoPresentacion()
        {

            if (RbtnPresentacion.SelectedIndex == 0)
            {                
                Ocultar();
            }
            else if (RbtnPresentacion.SelectedIndex == 1)
            {
                BtnSumar.Visible = true;
            }
            else
            {
                BtnSumar.Visible = false;
            }
        }              
        
        protected void BtnMostrar_Click(object sender, EventArgs e)
        {
             
        }
        protected void RbtnPresentacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            TipoPresentacion();
        }

        protected void DdlCiclo_SelectedIndexChanged1(object sender, EventArgs e)
        {
            DdlCurso.Items.Clear();

            string ciclo = Convert.ToString(DdlCiclo.SelectedItem);

            switch (ciclo)
            {
                case "I Ciclo":
                    string cursos1 = rutadirectorio + "curso1.txt";
                    StreamReader dato = new StreamReader(cursos1);
                    string line;
                    string mensaje = "";

                    while ((line = dato.ReadLine()) != null)
                    {
                        mensaje = line;
                    }

                    char sep = ',';

                    string[] c = mensaje.Split(sep);

                    for (int i = 0; i < c.Length; i++)
                    {
                        DdlCurso.Items.Add(c[i]);
                    }
                    break;
                case "II Ciclo":
                    string cursos2 = rutadirectorio + "curso2.txt";
                    StreamReader dato2 = new StreamReader(cursos2);
                    string line2;
                    string mensaje2 = "";

                    while ((line2 = dato2.ReadLine()) != null)
                    {
                        mensaje2 = line2;
                    }

                    char sep2 = ',';

                    string[] c2 = mensaje2.Split(sep2);

                    for (int i = 0; i < c2.Length; i++)
                    {
                        DdlCurso.Items.Add(c2[i]);
                    }
                    break;
                case "III Ciclo":
                    string cursos3 = rutadirectorio + "curso3.txt";
                    StreamReader dato3 = new StreamReader(cursos3);
                    string line3;
                    string mensaje3 = "";

                    while ((line3 = dato3.ReadLine()) != null)
                    {
                        mensaje3 = line3;
                    }

                    char sep3 = ',';

                    string[] c3 = mensaje3.Split(sep3);

                    for (int i = 0; i < c3.Length; i++)
                    {
                        DdlCurso.Items.Add(c3[i]);
                    }
                    break;
                case "IV Ciclo":
                    string cursos4 = rutadirectorio + "curso4.txt";
                    StreamReader dato4 = new StreamReader(cursos4);
                    string line4;
                    string mensaje4 = "";

                    while ((line4 = dato4.ReadLine()) != null)
                    {
                        mensaje4 = line4;
                    }

                    char sep4 = ',';

                    string[] c4 = mensaje4.Split(sep4);

                    for (int i = 0; i < c4.Length; i++)
                    {
                        DdlCurso.Items.Add(c4[i]);
                    }
                    break;
                case "V Ciclo":
                    string cursos5 = rutadirectorio + "curso5.txt";
                    StreamReader dato5 = new StreamReader(cursos5);
                    string line5;
                    string mensaje5 = "";

                    while ((line5 = dato5.ReadLine()) != null)
                    {
                        mensaje5 = line5;
                    }

                    char sep5 = ',';

                    string[] c5 = mensaje5.Split(sep5);

                    for (int i = 0; i < c5.Length; i++)
                    {
                        DdlCurso.Items.Add(c5[i]);
                    }
                    break;
                case "VI Ciclo":
                    string cursos6 = rutadirectorio + "curso6.txt";
                    StreamReader dato6 = new StreamReader(cursos6);
                    string line6;
                    string mensaje6 = "";

                    while ((line6 = dato6.ReadLine()) != null)
                    {
                        mensaje6 = line6;
                    }

                    char sep6 = ',';

                    string[] c6 = mensaje6.Split(sep6);

                    for (int i = 0; i < c6.Length; i++)
                    {
                        DdlCurso.Items.Add(c6[i]);
                    }
                    break;
                case "VII Ciclo":
                    string cursos7 = rutadirectorio + "curso3.txt";
                    StreamReader dato7 = new StreamReader(cursos7);
                    string line7;
                    string mensaje7 = "";

                    while ((line7 = dato7.ReadLine()) != null)
                    {
                        mensaje7 = line7;
                    }

                    char sep7 = ',';

                    string[] c7 = mensaje7.Split(sep7);

                    for (int i = 0; i < c7.Length; i++)
                    {
                        DdlCurso.Items.Add(c7[i]);
                    }
                    break;
                case "VIII Ciclo":
                    string cursos8 = rutadirectorio + "curso8.txt";
                    StreamReader dato8 = new StreamReader(cursos8);
                    string line8;
                    string mensaje8 = "";

                    while ((line8 = dato8.ReadLine()) != null)
                    {
                        mensaje8 = line8;
                    }

                    char sep8 = ',';

                    string[] c8 = mensaje8.Split(sep8);

                    for (int i = 0; i < c8.Length; i++)
                    {
                        DdlCurso.Items.Add(c8[i]);
                    }
                    break;
                case "IX Ciclo":
                    string cursos9 = rutadirectorio + "curso9.txt";
                    StreamReader dato9 = new StreamReader(cursos9);
                    string line9;
                    string mensaje9 = "";

                    while ((line9 = dato9.ReadLine()) != null)
                    {
                        mensaje9 = line9;
                    }

                    char sep9 = ',';

                    string[] c9 = mensaje9.Split(sep9);

                    for (int i = 0; i < c9.Length; i++)
                    {
                        DdlCurso.Items.Add(c9[i]);
                    }
                    break;
                case "X Ciclo":
                    string cursos10 = rutadirectorio + "curso10.txt";
                    StreamReader dato10 = new StreamReader(cursos10);
                    string line10;
                    string mensaje10 = "";

                    while ((line10 = dato10.ReadLine()) != null)
                    {
                        mensaje10 = line10;
                    }

                    char sep10 = ',';

                    string[] c10 = mensaje10.Split(sep10);

                    for (int i = 0; i < c10.Length; i++)
                    {
                        DdlCurso.Items.Add(c10[i]);
                    }
                    break;
                case "Electivos":
                    string elec = rutadirectorio + "electivos.txt";
                    StreamReader datoelec = new StreamReader(elec);
                    string linelec;
                    string mensajelec = "";

                    while ((linelec = datoelec.ReadLine()) != null)
                    {
                        mensajelec = linelec;
                    }

                    char seplec = ',';

                    string[] cel = mensajelec.Split(seplec);

                    for (int i = 0; i < cel.Length; i++)
                    {
                        DdlCurso.Items.Add(cel[i]);
                    }
                    break;
            }
        }

        protected void DdlCurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            string doc = Convert.ToString(DdlCurso.SelectedItem);
            string cur = rutadirectorio + doc + ".txt";
            StreamReader docente = new StreamReader(cur);
            string mesg = "";
            string linedoc;

            while ((linedoc = docente.ReadLine()) != null)
            {
                mesg = linedoc;
            }

            TxtDocente.Text = mesg;
        }

        protected void BtnSumar_Click(object sender, EventArgs e)
        {
            TxtCodigo.Visible = true;
            TxtNombre.Visible = true;
            TxtCodigo1.Visible = true;
            TxtNombre1.Visible = true;
            BtnSumar1.Visible = true;
        }

        protected void BtnSumar1_Click(object sender, EventArgs e)
        {
            TxtCodigo.Visible = true;
            TxtNombre.Visible = true;
            TxtCodigo1.Visible = true;
            TxtNombre1.Visible = true;
            TxtCodigo2.Visible = true;
            TxtNombre2.Visible = true;
            BtnSumar2.Visible = true;
        }

        protected void BtnSumar2_Click(object sender, EventArgs e)
        {
            TxtCodigo.Visible = true;
            TxtNombre.Visible = true;
            TxtCodigo1.Visible = true;
            TxtNombre1.Visible = true;
            TxtCodigo2.Visible = true;
            TxtNombre2.Visible = true;
            TxtCodigo3.Visible = true;
            TxtNombre3.Visible = true;
        }

        public void tipoCaratula()
        {
            if(RbtnTipo.SelectedIndex == 0)
            {
                tipo = "TRABAJO";
            }
            else if(RbtnTipo.SelectedIndex == 1)
            {
                tipo = "INFORME";
            }
            else
            {
                tipo = "SELECCIONE";
            }

        }
    }
}