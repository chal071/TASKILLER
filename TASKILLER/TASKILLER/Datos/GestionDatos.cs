using System.Collections.Generic;
using System.IO;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;



namespace TASKILLER
{
    public class GestionDatos
    {
       private static string path = Path.Combine(Application.StartupPath, "resources", "Data", "TaskillerData.json");

        public static Datos CargarDatos()
        {
            if (!File.Exists(path))
            {
                return new Datos(new List<Proyecto>(), new List<Tarea>(), new List<Usuario>(), new List<Rol>());
            }

            string json = File.ReadAllText(path);
            JObject jDatos = JObject.Parse(json);
            Datos datos = jDatos.ToObject<Datos>();

            return datos;
        }

        public static void GuardarDatos(Datos d)
        {
            JObject jDatos = new JObject
            {
                ["Proyectos"] = JArray.FromObject(d.listaProyectos), ["Tareas"] = JArray.FromObject(d.listaTareas),
                ["Usuarios"] = JArray.FromObject(d.listaUsuarios), ["Roles"] = JArray.FromObject(d.listaRoles)
            };

            File.WriteAllText(path, jDatos.ToString(Formatting.Indented));
        }
    }
}
