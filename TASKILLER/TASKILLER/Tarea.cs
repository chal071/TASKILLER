using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASKILLER
{
    public class Tarea
    {
        public Guid IdTarea { get; set; }
        public String Nombre { get; set; }
        public String Descripcion { get; set; }
        public int Prioridad { get; set; } // 1: Alta 2: Media 3: Baja
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFinal { get; set; }
        public List<Usuario> UsuariosAsignados { get; set; }
        public Guid IdProyecto { get; set; }
        public int Estado { get; set; } // 1: Por comenzar 2: En progreso 3: Entregado 4: Revisado 5: Bloqueado
        public Guid IdTareaPadre { get; set; }
        public List<Tarea> Subtareas { get; set; }

        public Tarea() { }

        public Tarea(Guid IdTarea, String Nombre, String Descripcion, int Prioridad, DateTime FechaInicio, DateTime FechaFinal, List<Usuario> UsuariosAsignados, Guid IdProyecto, int Estado)
        {
            this.IdTarea = Guid.NewGuid();
            this.Nombre = Nombre;
            this.Descripcion = Descripcion;
            this.Prioridad = Prioridad;
            this.FechaInicio = FechaInicio;
            this.FechaFinal = FechaFinal;
            this.UsuariosAsignados = UsuariosAsignados;
            this.IdProyecto = IdProyecto;
            this.Estado = Estado;
        }

        public Tarea(Guid IdTarea, String Nombre, String Descripcion, int Prioridad, DateTime FechaInicio, DateTime FechaFinal, List<Usuario> UsuariosAsignados, Guid IdProyecto, int Estado, Guid IdTareaPadre, List<Tarea> Subtareas)
        {
            this.IdTarea = Guid.NewGuid();
            this.Nombre = Nombre;
            this.Descripcion = Descripcion;
            this.Prioridad = Prioridad;
            this.FechaInicio = FechaInicio;
            this.FechaFinal = FechaFinal;
            this.UsuariosAsignados = UsuariosAsignados;
            this.IdProyecto = IdProyecto;
            this.Estado = Estado;
            this.IdTareaPadre = IdTareaPadre;
            this.Subtareas = Subtareas;
        }

    }
}
