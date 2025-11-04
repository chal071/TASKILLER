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
        public static List<Proyecto> proyectos;
        public static List<Tarea> tareas;
        public static List<Usuario> usuarios;
        public static List<Rol> roles;
        [STAThread]
        private static void Main()
        {   
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Fuentes.CargarFuentes();
            CargarDatos();
            roles.Add(new Rol("admin", new List<string> {}));
            usuarios.Add(new Usuario("admin", "admin", "admin@taskiller.com", "admin123", );
            Application.Run(new FormLogin());
        }
        private static void CargarDatos()
        {
            string rutaCifrada = Path.Combine(Application.StartupPath, "resources", "Data", "TaskillerData.enc");
            string clave = "MiClaveSecreta123";
            string rutaOriginal = Path.Combine(Application.StartupPath, "resources", "Data", "TaskillerData.json");

            string json;

            if (File.Exists(rutaCifrada))
            {
                byte[] datosCifrados = File.ReadAllBytes(rutaCifrada);
                json = BlowfishHelper.Descifrar(datosCifrados, clave);
            }
            else
            {
                json = File.ReadAllText(rutaOriginal);

                byte[] cifrado = BlowfishHelper.Cifrar(json, clave);
                File.WriteAllBytes(rutaCifrada, cifrado);
            }

            JObject obj = JObject.Parse(json);
            proyectos = obj["listaProyectos"].ToObject<List<Proyecto>>();
            tareas = obj["listaTareas"].ToObject<List<Tarea>>();
            usuarios = obj["listaUsuarios"].ToObject<List<Usuario>>();
            roles = obj["listaRoles"].ToObject<List<Rol>>();
            Console.WriteLine("Proyectos:");

            foreach (var p in proyectos)
                Console.WriteLine($"- {p.Titulo} ({p.Id})");

            Console.WriteLine("Tareas:");
            foreach (var t in tareas)
                Console.WriteLine($"- {t.Nombre} ({t.Id})");

            Console.WriteLine("Usuarios:");
            foreach (var u in usuarios)
                Console.WriteLine($"- {u.Nombre} ({u.Id})");

            Console.WriteLine("Roles:");
            foreach (var r in roles)
                Console.WriteLine($"- {r.Nombre} ({r.Id})");
        }
    }
}
