using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using System.Windows.Forms;



namespace TASKILLER
{
    public class GestionDatos
    {
        private static string clave = "MiClaveSecreta123";
        private static string rutaCifrada = Path.Combine(Application.StartupPath, "resources", "Data", "TaskillerData.enc");

        public static void GuardarDatos(
            List<Proyecto> proyectos,
            List<Tarea> tareas,
            List<Usuario> usuarios,
            List<Rol> roles)
        {
            var obj = new
            {
                listaProyectos = proyectos,
                listaTareas = tareas,
                listaUsuarios = usuarios,
                listaRoles = roles
            };

            string json = JsonConvert.SerializeObject(obj, Formatting.Indented);

            byte[] cifrado = BlowfishHelper.Cifrar(json, clave);

            File.WriteAllBytes(rutaCifrada, cifrado);
        }
    }
}
