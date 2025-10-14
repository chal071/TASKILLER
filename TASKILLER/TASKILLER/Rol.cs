using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASKILLER
{
    internal class Rol
    {
        public Guid IdRol { get; set; }
        public String Nombre { get; set; }

        public List<String> Acceso { get;set; }

    }
}
