using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace TASKILLER
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {   
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Fuentes.CargarFuentes();
            Datos d = GestionDatos.CargarDatos();
            Usuario usuario = new Usuario();
            Application.Run(new FormCreacionUsuario(d, usuario));

        }
       
    }
}
