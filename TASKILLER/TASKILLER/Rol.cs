using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASKILLER
{
    public class Rol
    {
        public Guid Id { get; set; }
        public String Nombre { get; set; }
        public List<String> Acceso { get;set; }

        public Rol() { }
        public Rol(String nombre, List<String> acceso) { 
            this.Id = Guid.NewGuid();
            this.Nombre = nombre;
            this.Acceso = acceso;
        }
    }
}
