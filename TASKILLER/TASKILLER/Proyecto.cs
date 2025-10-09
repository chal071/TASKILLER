using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASKILLER
{
    public class Proyecto
    {
        public string Titulo { get; set; }
        public int FechaInicio { get; set; }
        public int FechaFinal { get; set; }
        public Proyecto() { }

        public Proyecto (string Titulo, int FechaInicio, int FechaFinal)
        {
            this.Titulo = Titulo;
            this.FechaInicio = FechaInicio;
            this.FechaFinal = FechaFinal;
        }

       
    }
}
