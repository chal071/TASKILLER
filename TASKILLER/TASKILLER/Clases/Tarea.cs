using System;
using System.Collections.Generic;

namespace TASKILLER
{
    public enum Prioridad
    {
        Alta,
        Media,
        Baja
    }
    public enum Estado
    {
        Por_Comenzar,
        En_Progreso,
        Entregado,
        Revisado,
        Bloqueado
    }
    public class Tarea
    {
        public Guid Id { get; set; }
        public String Titulo { get; set; }
        public String Descripcion { get; set; }
        public Prioridad Prioridad { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFinal { get; set; }
        public List<Guid> listaUsuarios { get; set; }
        public Guid IdProyecto { get; set; }
        public Estado Estado { get; set; }
        public Guid? IdTareaPadre { get; set; }
        public List<Guid> Subtareas { get; set; }

        public Tarea() { }

        public Tarea(Guid IdTarea, String Nombre, String Descripcion, Prioridad Prioridad, DateTime
            FechaInicio, DateTime FechaFinal, List<Guid> UsuariosAsignados, Guid IdProyecto, Estado Estado)
        {
            this.Id = Guid.NewGuid();
            this.Titulo = Nombre;
            this.Descripcion = Descripcion;
            this.Prioridad = Prioridad;
            this.FechaInicio = FechaInicio;
            this.FechaFinal = FechaFinal;
            this.listaUsuarios = UsuariosAsignados;
            this.IdProyecto = IdProyecto;
            this.Estado = Estado;
        }

        public Tarea(Guid IdTarea, String Nombre, String Descripcion, Prioridad Prioridad, DateTime
            FechaInicio, DateTime FechaFinal, List<Guid> UsuariosAsignados, Guid IdProyecto, Estado Estado,
            Guid IdTareaPadre, List<Guid> Subtareas)
        {
            this.Id = Guid.NewGuid();
            this.Titulo = Nombre;
            this.Descripcion = Descripcion;
            this.Prioridad = Prioridad;
            this.FechaInicio = FechaInicio;
            this.FechaFinal = FechaFinal;
            this.listaUsuarios = UsuariosAsignados;
            this.IdProyecto = IdProyecto;
            this.Estado = Estado;
            this.IdTareaPadre = IdTareaPadre;
            this.Subtareas = Subtareas;
        }
    }
}
