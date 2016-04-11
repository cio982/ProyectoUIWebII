using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ejercicio02
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnListar_Click(object sender, EventArgs e)
        {
            LeerFichero();
        }

        public void LeerFichero11()
        {
            int counter = 0;
            string line;

            // Read the file and display it line by line.
            System.IO.StreamReader file =
                new System.IO.StreamReader(@"d:\Ficheros\horario.txt");
            while ((line = file.ReadLine()) != null)
            {
               
                LblLista.Text = line;
                //System.Console.WriteLine(line);
                counter++;
            }

            file.Close();
            LblLista.Text = Convert.ToString(counter);
            //System.Console.WriteLine("There were {0} lines.", counter);
            //// Suspend the screen.
            //System.Console.ReadLine();
        }

        public void LeerFichero() {
            string fichero = @"\Ficheros\horario.txt";
            String resultado = "";
            try
            {
                using (StreamReader lector = new StreamReader(fichero))
                {
                    while (lector.Peek() > -1)
                    {
                        string linea = lector.ReadLine();
                        if (!String.IsNullOrEmpty(linea))
                        {
                            resultado += linea + "<br>";
                            //Console.WriteLine(linea);
                        }
                    }
                }
                LblLista.Text = resultado;
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                LblLista.Text = "ERROR";
            }
        }
       
        
    }
}