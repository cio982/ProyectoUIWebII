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
        protected void Page_Load(object sender, EventArgs e)
        {
            string rutadirectorio = "D:\\EJER3\\";
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
            string rutaarchivo15 = rutadirectorio + "electivos.txt";
            /*docentes-cursos=66*/
            string rutaarchivo15 = rutadirectorio + "electivos.txt";
            string rutaarchivo15 = rutadirectorio + "electivos.txt";
            string rutaarchivo15 = rutadirectorio + "electivos.txt";
            string rutaarchivo15 = rutadirectorio + "electivos.txt";
            string rutaarchivo15 = rutadirectorio + "electivos.txt";
            string rutaarchivo15 = rutadirectorio + "electivos.txt";
            string rutaarchivo15 = rutadirectorio + "electivos.txt";
            string rutaarchivo15 = rutadirectorio + "electivos.txt";
            string rutaarchivo15 = rutadirectorio + "electivos.txt";
            string rutaarchivo15 = rutadirectorio + "electivos.txt";
            string rutaarchivo15 = rutadirectorio + "electivos.txt";
            string rutaarchivo15 = rutadirectorio + "electivos.txt";
            string rutaarchivo15 = rutadirectorio + "electivos.txt";
            string rutaarchivo15 = rutadirectorio + "electivos.txt";
            string rutaarchivo15 = rutadirectorio + "electivos.txt";
            string rutaarchivo15 = rutadirectorio + "electivos.txt";
            string rutaarchivo15 = rutadirectorio + "electivos.txt";
            string rutaarchivo15 = rutadirectorio + "electivos.txt";
            string rutaarchivo15 = rutadirectorio + "electivos.txt";
            string rutaarchivo15 = rutadirectorio + "electivos.txt";
            string rutaarchivo15 = rutadirectorio + "electivos.txt";
            string rutaarchivo15 = rutadirectorio + "electivos.txt";
            string rutaarchivo15 = rutadirectorio + "electivos.txt";
            string rutaarchivo15 = rutadirectorio + "electivos.txt";
            string rutaarchivo15 = rutadirectorio + "electivos.txt";
            string rutaarchivo15 = rutadirectorio + "electivos.txt";
            string rutaarchivo15 = rutadirectorio + "electivos.txt";
            string rutaarchivo15 = rutadirectorio + "electivos.txt";
            string rutaarchivo15 = rutadirectorio + "electivos.txt";
            string rutaarchivo15 = rutadirectorio + "electivos.txt";
            string rutaarchivo15 = rutadirectorio + "electivos.txt";
            string rutaarchivo15 = rutadirectorio + "electivos.txt";
            string rutaarchivo15 = rutadirectorio + "electivos.txt";
            string rutaarchivo15 = rutadirectorio + "electivos.txt";
            string rutaarchivo15 = rutadirectorio + "electivos.txt";
            string rutaarchivo15 = rutadirectorio + "electivos.txt";
            string rutaarchivo15 = rutadirectorio + "electivos.txt";
            string rutaarchivo15 = rutadirectorio + "electivos.txt";
            string rutaarchivo15 = rutadirectorio + "electivos.txt";
            string rutaarchivo15 = rutadirectorio + "electivos.txt";
            string rutaarchivo15 = rutadirectorio + "electivos.txt";
            string rutaarchivo15 = rutadirectorio + "electivos.txt";
            string rutaarchivo15 = rutadirectorio + "electivos.txt";
            string rutaarchivo15 = rutadirectorio + "electivos.txt";
            string rutaarchivo15 = rutadirectorio + "electivos.txt";
            string rutaarchivo15 = rutadirectorio + "electivos.txt";
            string rutaarchivo15 = rutadirectorio + "electivos.txt";
            string rutaarchivo15 = rutadirectorio + "electivos.txt";
            string rutaarchivo15 = rutadirectorio + "electivos.txt";
            string rutaarchivo15 = rutadirectorio + "electivos.txt";
            string rutaarchivo15 = rutadirectorio + "electivos.txt";
            string rutaarchivo15 = rutadirectorio + "electivos.txt";
            /**/

            /*//////////////////////////////////////////////////////////////////////////////////////////datos*/
            if (!File.Exists(rutadirectorio)) {
                string directorio = Path.Combine(rutadirectorio);
                Directory.CreateDirectory(directorio);
            }

            if (!File.Exists(rutaarchivo)){
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

            if (!File.Exists(rutaarchivo15))
            {
                FileStream archivo15 = new FileStream(rutaarchivo15, FileMode.Create);
                using (StreamWriter w = new StreamWriter(archivo15))
                {
                    w.Write("MEDIO AMBIENTE Y DESARROLLO SOSTENIBLE,CONTABILIDAD GENERAL,PATRONES DE SOFTWARE,DERECHO INFORMATICO,DISEÑO Y CREACION DE VIDEOJUEGOS,NEGOCIOS Y MARKETING POR INTERNET,TOPICOS DE BASE DE DATOS AVANZADOS,SISTEMA DE INFORMACION DE BANCA Y FINANZAS,SOLUCIONES MOVILES II");
                }
            }

            /*////////////////////////////////////////////////////////////////////////////////////////////docentes*/
        }

        protected void BtnMostrar_Click(object sender, EventArgs e)
        {
             
        }
    }
}