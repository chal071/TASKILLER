using System;
using System.Collections.Generic;

namespace TASKILLER
{

    public class Proyecto
    {
        public Guid Id { get; set; }
        public string Titulo { get; set; }
        public String Descripcion { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFinal { get; set; }
        public Estado Estado { get; set; }
        public Guid IdCreador { get; set; }
        public List<Guid> listaUsuarios { get; set; }

        public Proyecto() { }

        public Proyecto (string titulo, String descripcion, DateTime fechaInicio, DateTime fechaFinal, 
            Estado estado, Guid idcreador,  List<Guid> usuarios)
        {
            this.Id = Guid.NewGuid();
            this.Titulo = titulo;
            this.Descripcion = descripcion;
            this.FechaInicio = fechaInicio;
            this.FechaFinal = fechaFinal;
            this.Estado = estado;
            this.IdCreador = idcreador;
            this.listaUsuarios = usuarios;
        }
    }
}
