using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASKILLER
{
    public class Datos
    {
        public List<Proyecto> listaProyectos { get; set; }
        public List<Tarea> listaTareas { get; set; }
        public List<Usuario> listaUsuarios { get; set; }
        public List<Rol> listaRoles { get; set; }

        public Datos(List<Proyecto> p, List<Tarea> t, List<Usuario> u, List<Rol> r) { 
            this.listaProyectos = p;
            this.listaTareas = t;
            this.listaUsuarios = u;
            this.listaRoles = r;
        }
    }
}
