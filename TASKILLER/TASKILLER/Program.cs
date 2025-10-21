using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TASKILLER
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        public static List<Usuario> usuarios = new List<Usuario>();
        public static List<Rol> roles = new List<Rol>();
        public static Usuario usuarioActual;

        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Fuentes.CargarFuentes();
            Application.Run(new FormLogin());
        }
    }
}
