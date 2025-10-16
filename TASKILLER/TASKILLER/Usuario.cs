using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASKILLER
{
    public class Usuario
    {
        public Guid IdUsuario  { get; set; }
        public String Nombre { get; set; }
        public String Mail { get; set;}
        public String Contrasena { get; set; }
        public Rol Rol { get; set; }

        public Usuario() { }

        public Usuario(String Nombre, String Mail, String Contrasena, Rol Rol)
        {
            this.IdUsuario = Guid.NewGuid();
            this.Nombre = Nombre;
            this.Mail = Mail;
            this.Contrasena = Contrasena;
            this.Rol = Rol;
        }
    }
}

