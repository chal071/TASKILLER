using System;
using System.Collections.Generic;

namespace TASKILLER
{
    public enum Estado
    {
        Por_Comenzar = 1,
        En_Progreso = 2,
        Entregado = 3,
        Revisado = 4,
        Bloqueado = 5
    }
    public class Proyecto
    {
        public Guid Id { get; set; }
        public string Titulo { get; set; }
        public String Descripcion { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFinal { get; set; }
        public Estado Estado { get; set; }
        public  List<Guid> listaUsuarios { get; set; }

        public Proyecto() { }

        public Proyecto (string titulo, String descripcion, DateTime fechaInicio, DateTime fechaFinal, 
            Estado estado, List<Guid> usuarios)
        {
            this.Id = Guid.NewGuid();
            this.Titulo = titulo;
            this.Descripcion = descripcion;
            this.FechaInicio = fechaInicio;
            this.FechaFinal = fechaFinal;
            this.Estado = estado;
            this.listaUsuarios = usuarios;
        }
    }
}
