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
        public String Apellido {  get; set; }
        public String Mail { get; set;}
        public String Contrasena { get; set; }
        public Rol Rol { get; set; }


        public Usuario(string nombre, String apellido, String mail, String contrasena, Rol rol )
        {
            IdUsuario = Guid.NewGuid();
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Mail = mail;
            this.Contrasena = contrasena;
            this.Rol = rol;
        }
    }
}

