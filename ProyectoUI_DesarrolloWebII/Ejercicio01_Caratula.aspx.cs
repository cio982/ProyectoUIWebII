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
            string rutadirectorio = "E:\\EJER3\\";
            string rutaarchivo = rutadirectorio + "Datos.txt";



            if (!File.Exists(rutadirectorio)) {
                string directorio = Path.Combine(rutadirectorio);
                Directory.CreateDirectory(directorio);
            }

            if (!File.Exists(rutaarchivo)){
                FileStream archivo = new FileStream(rutaarchivo, FileMode.Create);
            }
           


           // DefaultComboBoxModel model = null;

            //if (EJER2.mkdir())
            //{

            //}
            //else if (!archivo.exists())
            //{
            //    try
            //    {
            //        archivo.createNewFile();
            //    }
            //    catch (IOException ex)
            //    {
            //        ex.printStackTrace();
            //    }
            //}
        }
    }
}