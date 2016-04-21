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
    public partial class generador : System.Web.UI.Page
    {
        //Curso
        private ArrayList RegistrosCurso = new ArrayList();
        private Curso Curso = new Curso();

        //Ciclo
        private ArrayList RegistrosCiclo = new ArrayList();
        private Ciclo Ciclo = new Ciclo();



        protected void Page_Load(object sender, EventArgs e)
        {
            RegistrosCurso = new ArrayList();
            Curso = new Curso();

            RegistrosCiclo = new ArrayList();
            Ciclo = new Ciclo();



            LeerCiclos();
            ImprimirCiclo();

            LeerCursos();
            //ImprimirPorCiclo("1");
        }


        private void LeerCursos()
        {
            string fichero = @"d:\Ficheros\Curso.txt";
            try
            {
                StreamReader Lector = new StreamReader(fichero);
                String lineas = Lector.ReadLine();
                while (lineas !="null")
                {
                    Char[] delimitador = {','};
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
      

 
        //private void imprimir()
        //{
        //    foreach (object RegistrosCurso in RegistrosCurso)
        //    {
        //        Curso = (Curso)RegistrosCurso;
        //        imprimirtodos();
        //    }
        //}
        //private void imprimirtodos()
        //{
        //    LstbCurso.Items.Add(new ListItem(Curso.cur_nombre, Curso.cur_id));
        //}
        private void ImprimirCiclo()
        {
            //DdlCiclo.Items.Clear();
            foreach (object RegistrosCiclo in RegistrosCiclo)
            {
                Ciclo = (Ciclo)RegistrosCiclo;
                DdlCiclo.Items.Add(Ciclo.ciclo_id);
            }
        }
        private void ImprimirPorCiclo(String ciclo)
        {
            LstbCurso.Items.Clear();
            foreach (object RegistrosCurso in RegistrosCurso)
            {
                Curso = (Curso)RegistrosCurso;
                if (Curso.cur_ciclo == ciclo)
                {
                    LstbCurso.Items.Add(new ListItem(Curso.cur_nombre, Curso.cur_id));
                }
            }
        }

    

        //private void GuardarXhorario()
        //{
        //    string fichero = @"d:\Ficheros\xhorario.txt";
        //    String xid = LstbCurso.SelectedItem.Text;
        //    String xnom = LstbCurso.SelectedValue;
        //    string lines = xid+","+xnom;

        //    // Write the string to a file. @"d:\Ficheros\xhorario.txt";
        //    StreamWriter file = new StreamWriter(fichero);
        //    file.WriteLine(lines);

        //    file.Close();
        //}


        protected void Button1_Click(object sender, EventArgs e)
        {
            //if (LstCursosSeleccionados.Items.Count == 0)
            //{
            //    LstCursosSeleccionados.Items.Add(new ListItem(LstbCurso.SelectedItem.Text, LstbCurso.SelectedValue));
            //}
            //else
            //{
            //    for (int i = 0; i < LstCursosSeleccionados.Items.Count; i++)
            //    {
            //        if (Convert.ToUInt16(LstbCurso.SelectedValue) != Convert.ToUInt16(LstCursosSeleccionados.Items[i].Value))
            //        {
            //            LstCursosSeleccionados.Items.Add(new ListItem(LstbCurso.SelectedItem.Text, LstbCurso.SelectedValue));
            //        }
            //    }
            //}
            LstCursosSeleccionados.Items.Add(new ListItem(LstbCurso.SelectedItem.Text, LstbCurso.SelectedValue));
            
           
        }


        protected void DdlCiclo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnSeleccionarCiclo_Click(object sender, EventArgs e)
        {
            String xciclo = DdlCiclo.SelectedValue;
            ImprimirPorCiclo(xciclo);

            lblCiclo.Text = "( ciclo: " + DdlCiclo.SelectedItem.Text + " )";
            DdlCiclo.Items.Clear();
            ImprimirCiclo();
            
        }

        protected void BtnGenerar_Click(object sender, EventArgs e)
        {
            string fichero = @"d:\Ficheros\xhorario.txt";
            StreamWriter file = new StreamWriter(fichero);
            int m;
            m = LstCursosSeleccionados.Items.Count;
            for (int i = 0; i < m; i++)
            {
                //file.WriteLine(LstCursosSeleccionados.Items[i].ToString());
                file.WriteLine(LstCursosSeleccionados.Items[i].Value);
            }
            file.Close();

            Response.Redirect("horario_generado.aspx");
        }

        protected void btnQuitarCurso_Click(object sender, EventArgs e)
        {
            LstCursosSeleccionados.Items.Remove(LstCursosSeleccionados.SelectedItem);
        }
    }

}