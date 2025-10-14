using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASKILLER
{
    internal class Usuario
    {
        public Guid IdUsuario  { get; set; }
        public String Nombre { get; set; }
        public String Mail { get; set;}
        public String Contrasena { get; set; }
        public Rol Rol { get; set; }

    }
}

