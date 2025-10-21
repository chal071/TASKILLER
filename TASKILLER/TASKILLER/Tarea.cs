using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASKILLER
{
    public enum Prioridad
    {
        Alta = 1,
        Media = 2,
        Baja = 3
    }

    public class Tarea
    {
        public Guid Id { get; set; }
        public String Nombre { get; set; }
        public String Descripcion { get; set; }
        public Prioridad Prioridad { get; set; } 
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFinal { get; set; }
        public List<Guid> UsuariosAsignados { get; set; }
        public Guid IdProyecto { get; set; }
        public int Estado { get; set; } // 1: Por comenzar 2: En progreso 3: Entregado 4: Revisado 5: Bloqueado
        public Guid? IdTareaPadre { get; set; }
        public List<Tarea> Subtareas { get; set; }

        public Tarea() { }

        public Tarea(Guid IdTarea, String Nombre, String Descripcion, Prioridad Prioridad, DateTime 
            FechaInicio, DateTime FechaFinal, List<Guid> UsuariosAsignados, Guid IdProyecto, int Estado)
        {
            this.Id = Guid.NewGuid();
            this.Nombre = Nombre;
            this.Descripcion = Descripcion;
            this.Prioridad = Prioridad;
            this.FechaInicio = FechaInicio;
            this.FechaFinal = FechaFinal;
            this.UsuariosAsignados = UsuariosAsignados;
            this.IdProyecto = IdProyecto;
            this.Estado = Estado;
        }

        public Tarea(Guid IdTarea, String Nombre, String Descripcion, Prioridad Prioridad, DateTime 
            FechaInicio, DateTime FechaFinal, List<Guid> UsuariosAsignados, Guid IdProyecto, int Estado,
            Guid IdTareaPadre, List<Tarea> Subtareas)
        {
            this.Id = Guid.NewGuid();
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
