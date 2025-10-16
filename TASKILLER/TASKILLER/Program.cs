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
            Rol admin = new Rol("admin", new List<string> { "CrearUsuario", "EliminarUsuario", "ModificarUsuario", "VerUsuarios", "CrearTarea", "EliminarTarea", "ModificarTarea", "VerTareas" });
            roles.Add(admin);
            usuarios.Add(new Usuario("admin", "admin@taskiller.com", "admin123", admin));
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormLogin());
        }
    }
}
