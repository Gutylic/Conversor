using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace Conversor
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnConversor_Click(object sender, EventArgs e)
        {
            if (!FileUpload_Ejercicio.HasFile)
            {
                string Mensaje = @"<script type='text/javascript'>   
                                   alert('Es obligatorio cargar un archivo');
                                   </script>";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "", Mensaje, false);
                return;
            }

            Session["fileName"] = FileUpload_Ejercicio.FileName;

            string filename = Path.Combine(Server.MapPath("~/corregido"), (string)Session["fileName"]);
            FileUpload_Ejercicio.SaveAs(filename);
            StreamReader file = new StreamReader(filename, System.Text.Encoding.UTF8);
            
            
            string texto = file.ReadToEnd();
            file.Close();
            
            
            Session["Datos"] = texto;
            string[] datos = Session["Datos"].ToString().Split('╝');
            Session["Enunciado"] = datos[0];
            Session["Enunciado_Limpio"] = datos[1];
            Session["Titulo"] = datos[2];
            Session["Tipo_Producto"] = datos[4];
            Session["Realizada_Explicacion"] = datos[8];
            Session["Ejercicio"] = datos[5];
            Session["Video"] = datos[7];


            StreamWriter Archivo = File.CreateText("C:\\corregido/" + FileUpload_Ejercicio.FileName); // carga el archivo corregido del enunciado en c:

            Archivo.Write((string)Session["Enunciado"]);
            Archivo.Write("╝");
            Archivo.Write((string)Session["Enunciado_Limpio"]);
            Archivo.Write("╝");
            Archivo.Write((string)Session["Titulo"]);
            Archivo.Write("╝");
            Archivo.Write((string)Session["Tipo_Producto"]);
            Archivo.Write("╝");
            Archivo.Write((string)Session["Video"]);
            Archivo.Write("╝");
            Archivo.Write((string)Session["Realizada_Explicacion"]);
            Archivo.Write("╝");
            Archivo.Write((string)Session["Ejercicio"]);
            Archivo.Write("╝");
            
            Archivo.Flush();
            Archivo.Close();



        }
    }
}