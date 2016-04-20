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

            /*////////////////////////////////////////////////////////////////////////////////////////////datos*/
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
                    w.Write("CALCULO I,ALGEBRA LINEAL,INTRODUCCION A LA INGENIERIA DE SISTEMAS,INTRODUCCION A LA PROGRAMACION,COMUNICACION ORAL Y ESCRITA,METODOLOGIA DEL TRABAJO UNIVERSITARIO");
                }
            }

            if (!File.Exists(rutaarchivo6))
            {
                FileStream archivo6 = new FileStream(rutaarchivo6, FileMode.Create);
                using (StreamWriter w = new StreamWriter(archivo6))
                {
                    w.Write("CALCULO II,MATEMATICA DISCRETA I,SISTEMAS DE INFORMACION,ESTRUCTURA DE DATOS Y ALGORITMOS,PROGRAMACION I");
                }
            }

            if (!File.Exists(rutaarchivo7))
            {
                FileStream archivo7 = new FileStream(rutaarchivo7, FileMode.Create);
                using (StreamWriter w = new StreamWriter(archivo7))
                {
                    w.Write("FISICA GENERAL,MATEMATICA DISCRETA II,ESTADISTICA DESCRIPTIVA,MODELO DE PROCESOS DE NEGOCIOS,PROGRAMACION ORIENTADA A OBJETOS,PROGRAMACION II");
                }
            }

            if (!File.Exists(rutaarchivo8))
            {
                FileStream archivo8 = new FileStream(rutaarchivo8, FileMode.Create);
                using (StreamWriter w = new StreamWriter(archivo8))
                {
                    w.Write("FISICA ELECTRICA APLICADA,INTRODUCCION AL DESARROLLO WEB,ESTADISTICA INFERENCIAL,INGENIERIA DE REQUERIMIENTOS,DISEÑO Y MODELAMIENTO VIRTUAL,DISEÑO DE INTERFACES E INTERACCION");
                }
            }

            if (!File.Exists(rutaarchivo9))
            {
                FileStream archivo9 = new FileStream(rutaarchivo9, FileMode.Create);
                using (StreamWriter w = new StreamWriter(archivo9))
                {
                    w.Write("DISEÑO Y ARQUITECTURA DE SOFTWARE,SISTEMAS OPERATIVOS I,DISEÑO DE BASE DE DATOS,PROGRAMACION LINEAL,PROGRAMACION III,INGENIERIA ECONOMICA DE SOFTWARE");
                }
            }

            if (!File.Exists(rutaarchivo10))
            {
                FileStream archivo10 = new FileStream(rutaarchivo10, FileMode.Create);
                using (StreamWriter w = new StreamWriter(archivo10))
                {
                    w.Write("APLICACIONES MOVILES I,ARQUITECTURA DEL COMPUTADOR,GESTION DE BASE DE DATOS,INGENIERIA DE SOFTWARE,SISTEMAS OPERATIVOS II,GESTION DE LA CALIDAD DE SOFTWARE");
                }
            }

            if (!File.Exists(rutaarchivo11))
            {
                FileStream archivo11 = new FileStream(rutaarchivo11, FileMode.Create);
                using (StreamWriter w = new StreamWriter(archivo11))
                {
                    w.Write("PROGRAMACION WEB I,REDES Y COMUNICACIONES DE DATOS I,MINERIA DE DATOS,NEGOCIOS ELECTRONICOS,GESTION DE PROYECTOS");
                }
            }

            if (!File.Exists(rutaarchivo12))
            {
                FileStream archivo12 = new FileStream(rutaarchivo12, FileMode.Create);
                using (StreamWriter w = new StreamWriter(archivo12))
                {
                    w.Write("PROGRAMACION WEB II,REDES Y COMUNICACIONES DE DATOS II,TOPICOS AVANZADOS DE BASE DE DATOS,CONSTRUCCION DE SOFTWARE I,SEGURIDAD INFORMATICA,ETICA PROFESIONAL");
                }
            }

            if (!File.Exists(rutaarchivo13))
            {
                FileStream archivo13 = new FileStream(rutaarchivo13, FileMode.Create);
                using (StreamWriter w = new StreamWriter(archivo13))
                {
                    w.Write("GESTION DE LA CONFIGURACION Y MANTENIMIENTO DE SOFTWARE,REDES Y COMUNICACIONES DE DATOS III,PLANEAMIENTO DE TI,CONSTRUCCION DE SOFTWARE II,TALLER DE TESIS I");
                }
            }

            if (!File.Exists(rutaarchivo14))
            {
                FileStream archivo14 = new FileStream(rutaarchivo14, FileMode.Create);
                using (StreamWriter w = new StreamWriter(archivo14))
                {
                    w.Write("PRUEBAS DE SOFTWARE,TALLER DE REDES E INFRAESTRUCTURA DE TI,GERENCIA DE SI-TI,TALLER DE LIDERAZGO Y EMPRENDIMIENTO,TALLER DE TESIS II");
                }
            }

            if (!File.Exists(rutaarchivo15))
            {
                FileStream archivo15 = new FileStream(rutaarchivo15, FileMode.Create);
                using (StreamWriter w = new StreamWriter(archivo15))
                {
                    w.Write("MEDIO AMBIENTE Y DESARROLLO SOSTENIBLE,APLICACIONES MOVILES II,DERECHO INFORMATICO,GESTION DE CONOCIMIENTO,SEMINARIO DE APLICACIONES,AUDITORIA DE SISTEMAS,SISTEMAS DE INFORMACION DE BANCA Y FINANZAS,SEMINARIOS DE REDES");
                }
            }

            /*////////////////////////////////////////////////////////////////////////////////////////////docentes*/
        }

        protected void BtnMostrar_Click(object sender, EventArgs e)
        {
             
        }
    }
}